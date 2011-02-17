using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;
using System.Collections;

namespace CSC431.Sparc
{
    class RegisterAllocation
    {
        private int getMaxRegValue(ProgramBlock<SparcInstruction> start)
        {
            var allReg = new List<Register>();
            foreach (var f in start.Functions)
            {
                f.VisitBlocks(b =>
                {
                    foreach (var instr in b.Code)
                    {
                        allReg.AddRange(instr.SourceRegs);
                        allReg.AddRange(instr.DestRegs);
                    }
                });
            }

            return allReg.Select(r => r.IntVal).Max();
        }

        Dictionary<BasicBlock<SparcInstruction>, BitArray> genSets;
        Dictionary<BasicBlock<SparcInstruction>, BitArray> killSets;
        Dictionary<BasicBlock<SparcInstruction>, BitArray> liveoutSets;
        int numRegs;
        Dictionary<FunctionBlock<SparcInstruction>, BitArray[]> allDepGraphs;

        private void setupVars(ProgramBlock<SparcInstruction> start)
        {
            numRegs = getMaxRegValue(start) + 1;

            genSets = new Dictionary<BasicBlock<SparcInstruction>, BitArray>();
            killSets = new Dictionary<BasicBlock<SparcInstruction>, BitArray>();
            liveoutSets = new Dictionary<BasicBlock<SparcInstruction>, BitArray>();
            foreach (var f in start.Functions)
            {
                f.VisitBlocks(b =>
                {
                    genSets[b] = new BitArray(numRegs);
                    killSets[b] = new BitArray(numRegs);
                    liveoutSets[b] = new BitArray(numRegs);
                });
            }

            allDepGraphs = new Dictionary<FunctionBlock<SparcInstruction>, BitArray[]>();
            foreach (var f in start.Functions)
            {
                var aDepGraph = new BitArray[numRegs];
                for (int i = 0; i < numRegs; i++)
                {
                    aDepGraph[i] = new BitArray(numRegs);
                }
                allDepGraphs[f] = aDepGraph;
            }
        }

        private void doGenAndKill(ProgramBlock<SparcInstruction> start)
        {
            foreach (var f in start.Functions)
            {
                f.VisitBlocks(b =>
                {
                    var gset = genSets[b];
                    var kset = killSets[b];
                    foreach (var instr in b.Code)
                    {
                        instr.SourceRegs.Where(r => !kset[r.IntVal]).Map(r => gset.Set(r.IntVal, true));
                        instr.DestRegs.Map(r => kset.Set(r.IntVal, true));
                    }
                });
            }
        }

        private void doLiveoutSets(ProgramBlock<SparcInstruction> start)
        {
            bool changed = false;
            do
            {
                changed = false;

                foreach (var f in start.Functions)
                {
                    f.VisitBlocks(b =>
                    {
                        var gset = genSets[b];
                        var kset = killSets[b];
                        var lset = liveoutSets[b];
                        var newLset = new BitArray(numRegs);
                        foreach (var suc in b.Nexts)
                        {
                            var sucKset = killSets[suc as BasicBlock<SparcInstruction>];
                            var sucGset = genSets[suc as BasicBlock<SparcInstruction>];
                            var sucLset = liveoutSets[suc as BasicBlock<SparcInstruction>];
                            var sucSet = new BitArray(numRegs);

                            //do lset - kset
                            sucSet.Or(sucLset).Xor(sucKset).And(sucLset);

                            //do gen union with the above
                            sucSet.Or(sucGset);

                            //union with new lset
                            newLset.Or(sucSet);
                        }

                        if (newLset.Cast<bool>().Zip(lset.Cast<bool>(), (o1, o2) => o1 == o2).Where(v => !v).Any())
                        {
                            changed = true;
                            liveoutSets[b] = newLset;
                        }
                    });
                }
            }
            while (changed);
        }

        private void doGraph(ProgramBlock<SparcInstruction> start)
        {
            foreach (var f in start.Functions)
            {
                var dg = allDepGraphs[f];
                f.VisitBlocks(b =>
                {
                    var lset = new BitArray(liveoutSets[b]);
                    foreach (var instr in Enumerable.Reverse(b.Code))
                    {
                        //1) add an edge from t to each member of live out (in the interfence graph)
                        foreach (var r in instr.DestRegs)
                        {
                            for (int i = 0; i < numRegs; i++)
                            {
                                if (lset[i])
                                {
                                    dg[i][r.IntVal] = true;
                                    dg[r.IntVal][i] = true;
                                }
                            }
                        }

                        //2) remove target from LO
                        foreach (var r in instr.DestRegs)
                        {
                            lset[r.IntVal] = false;
                        }

                        //3) add sources to LO
                        foreach (var r in instr.SourceRegs)
                        {
                            lset[r.IntVal] = true;
                        }
                    }
                });
            }
        }

        public ProgramBlock<SparcInstruction> DoAllocation(ProgramBlock<SparcInstruction> start)
        {
            //DEBUG CRAP
            var virtToSpar = new Dictionary<int, SparcRegister>();
            for (int i = 0; i < SparcRegister.IntValueMap.Length; i++)
            {
                virtToSpar.Add(SparcRegister.IntValueMap[i], new SparcRegister((SparcReg)i));
            }
            //END DEBUG CRAP

            setupVars(start);
            doGenAndKill(start);
            doLiveoutSets(start);
            doGraph(start);

            //liveout


            //DEBUG
            foreach (var k in genSets.Keys)
            {
                Console.WriteLine("Block {0} with {1} instrs", k.Label, k.Code.Count);
                var kset = killSets[k];
                var gset = genSets[k];
                var lset = liveoutSets[k];
                for (int i = 0; i < numRegs; i++)
                {
                    if (gset[i])
                        Console.WriteLine("g:{0}", getRegister(virtToSpar, i));
                    if (kset[i])
                        Console.WriteLine("k:{0}", getRegister(virtToSpar, i));
                    if (lset[i])
                        Console.WriteLine("l:{0}", getRegister(virtToSpar, i));
                }
                Console.WriteLine();
            }

            Console.WriteLine("derp graphs");
            foreach (var f in start.Functions)
            {
                Console.WriteLine("fun {0}:", f.Name);
                var dgraph = allDepGraphs[f];
                Console.Write(",");
                for (int i = 0; i < numRegs; i++)
                {
                    Console.Write("{0},", getRegister(virtToSpar, i));
                }
                Console.WriteLine();
                for (int i = 0; i < numRegs; i++)
                {
                    Console.Write("{0},", getRegister(virtToSpar, i));
                    for (int j = 0; j < numRegs; j++)
                    {
                        Console.Write("{0},", dgraph[i][j] ? "█" : "░");
                    }
                    Console.WriteLine();
                }
            }

            return start;
        }

        private Register getRegister(Dictionary<int, SparcRegister> dic, int id)
        {
            if (dic.ContainsKey(id))
                return dic[id];
            return new VirtualRegister(id);
        }
    }
}
