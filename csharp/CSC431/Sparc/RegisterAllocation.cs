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
