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
        private SparcRegister[] virtToSparc;
        private BitArray candidateColors;
        private readonly int numColors;
        private readonly List<int> emptyList = new List<int>();
        private List<string> coloringDone = new List<string>();

        public RegisterAllocation()
        {
            candidateColors = new BitArray(SparcRegister.IntValueMap.Max() + 1);
            virtToSparc = new SparcRegister[candidateColors.Length];

            foreach (SparcReg r in Enum.GetValues(typeof(SparcReg)))
            {
                var s = new SparcRegister(r);
                virtToSparc[s.IntVal] = s;
            }

            var canColors = new List<SparcRegister>();
            canColors.Add(new SparcRegister(SparcReg.l0));
            canColors.Add(new SparcRegister(SparcReg.l1));
            canColors.Add(new SparcRegister(SparcReg.l2));
            canColors.Add(new SparcRegister(SparcReg.l3));
            canColors.Add(new SparcRegister(SparcReg.l4));
            canColors.Add(new SparcRegister(SparcReg.l5));
            canColors.Add(new SparcRegister(SparcReg.l6));
            canColors.Add(new SparcRegister(SparcReg.l7));

            numColors = canColors.Count;

            foreach (var c in canColors)
            {
                if (c.IntVal == 0)
                    throw new Exception("no register should have an intval of 0, the register allocator depends on this");
                candidateColors[c.IntVal] = true;
            }



            //data the may be inject in setupVars()
            genSets = new Dictionary<BasicBlock<SparcInstruction>, BitArray>();
            killSets = new Dictionary<BasicBlock<SparcInstruction>, BitArray>();
            liveoutSets = new Dictionary<BasicBlock<SparcInstruction>, BitArray>();
            allDepGraphs = new Dictionary<FunctionBlock<SparcInstruction>, BitArray[]>();
            colorMapping = new Dictionary<string, SparcRegister[]>();
        }

        private void addEdge(BitArray[] dg, int x, int y)
        {
            dg[x][y] = true;
            dg[y][x] = true;
        }
        private void removeEdge(BitArray[] dg, int x, int y)
        {
            dg[x][y] = false;
            dg[y][x] = false;
        }
        private void removeEdges(BitArray[] dg, int x, BitArray edges)
        {
            for (int y = 0; y < dg.Length; y++)
            {
                if (edges[y])
                {
                    dg[x][y] = false;
                    dg[y][x] = false;
                }
            }
        }
        private void addEdges(BitArray[] dg, int x, BitArray edges)
        {
            for (int y = 0; y < dg.Length; y++)
            {
                if (edges[y])
                {
                    dg[x][y] = true;
                    dg[y][x] = true;
                }
            }
        }

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
        Dictionary<string, SparcRegister[]> colorMapping;
        BitArray spilleds;

        private void setupVars(ProgramBlock<SparcInstruction> start)
        {
            foreach (var f in start.Functions)
            {
                if (coloringDone.Contains(f.Name))
                    continue;

                f.VisitBlocks(b =>
                {
                    genSets[b] = new BitArray(numRegs);
                    killSets[b] = new BitArray(numRegs);
                    liveoutSets[b] = new BitArray(numRegs);
                });
            }

            foreach (var f in start.Functions)
            {
                if (coloringDone.Contains(f.Name))
                    continue;

                var aDepGraph = new BitArray[numRegs];
                for (int i = 0; i < numRegs; i++)
                {
                    aDepGraph[i] = new BitArray(numRegs);
                }
                allDepGraphs[f] = aDepGraph;
            }

            foreach (var f in start.Functions)
            {
                if (coloringDone.Contains(f.Name))
                    continue;

                colorMapping[f.Name] = new SparcRegister[numRegs];
            }
        }

        private void doGenAndKill(ProgramBlock<SparcInstruction> start)
        {
            foreach (var f in start.Functions)
            {
                if (coloringDone.Contains(f.Name))
                    continue;

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
                    if (coloringDone.Contains(f.Name))
                        continue;

                    f.VisitBlocks(b =>
                    {
                        var gset = genSets[b];
                        var kset = killSets[b];
                        var lset = liveoutSets[b];
                        var newLset = new BitArray(numRegs);

                        if (!b.IsReturn)
                        {
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
                        }

                        var countingSet = new BitArray(lset);
                        countingSet.Xor(newLset);
                        var countArr = new int[countingSet.IntArraySize()];
                        countingSet.CopyTo(countArr, 0);

                        for (int i = 0; i < countArr.Length; i++)
                        {
                            changed |= countArr[i] != 0;
                        }

                        if (changed)
                        {
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
                if (coloringDone.Contains(f.Name))
                    continue;

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
                                if (lset[i] && r.IntVal != i)
                                {
                                    addEdge(dg, i, r.IntVal);
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

        private class NodeAndEdges
        {
            public int Reg;
            public BitArray Edges;
        }

        private bool isConstrained(int reg, BitArray edges)
        {
            var edgeCount = edges.NumberOfBitsSet();

            return edgeCount >= numColors;
        }

        private int compareConstrainedness(BitArray[] dg, int r1, int r2)
        {
            return dg[r2].NumberOfBitsSet() - dg[r1].NumberOfBitsSet();
        }

        private List<int> colorFunction(FunctionBlock<SparcInstruction> f)
        {
            var uncolorableRegs = new List<int>();

            var dg = allDepGraphs[f];
            var map = colorMapping[f.Name];

            var stack = new Stack<NodeAndEdges>(numRegs);

            var notConstrained = Enumerable.Range(0, numRegs).Where(r => !isConstrained(r, dg[r])).ToList();
            var constrained = Enumerable.Range(0, numRegs).Where(r => isConstrained(r, dg[r])).ToList();
            var constrainedAndUncolorable = new List<int>(constrained);

            //Push all unconstrained nodes first
            foreach (var r in notConstrained)
            {
                var bits = dg[r];

                stack.Push(new NodeAndEdges() { Reg = r, Edges = new BitArray(bits) });
                removeEdges(dg, r, bits);
            }

            //Console.WriteLine("\t{0}:{1} reg constr", f.Name, constrained.Count);

            //While there still exists constrained registers
            while (constrained.Count != 0)
            {
                var constrainedNdx = constrained.MaxIndex(r => dg[r].NumberOfBitsSet());
                var reg = constrained[constrainedNdx];
                var bits = dg[reg];

                stack.Push(new NodeAndEdges() { Reg = reg, Edges = new BitArray(bits) });
                removeEdges(dg, reg, bits);

                constrained.Remove(reg);
            }

            while (stack.Count != 0)
            {
                var val = stack.Pop();
                var bits = val.Edges;
                SparcRegister reg = getSparcRegister(val.Reg);

                if (reg == null)
                {
                    var cans = new BitArray(candidateColors);
                    for (int i = 0; i < bits.Length; i++)
                    {
                        if (bits[i])
                            cans[map[i].IntVal] = false;
                    }
                    reg = virtToSparc[cans.FirstTrueIndex()];
                }

                if (reg == null)
                {
                    break;
                }

                constrainedAndUncolorable.Remove(val.Reg);

                map[val.Reg] = reg;
                addEdges(dg, val.Reg, bits);
            }

            constrainedAndUncolorable.Sort((r1, r2) => compareConstrainedness(dg, r1, r2));
            return constrainedAndUncolorable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <returns>-1 if all nodes were colorable, otherwise the id of the virtual register that coud not be colored.</returns>
        private Dictionary<string, List<int>> colorGraph(ProgramBlock<SparcInstruction> start)
        {
            var functionsToUncoloredRegisters = new Dictionary<string, List<int>>();

            foreach (var f in start.Functions)
            {
                if (coloringDone.Contains(f.Name))
                    continue;
                
                functionsToUncoloredRegisters[f.Name] = colorFunction(f);

                if (functionsToUncoloredRegisters[f.Name].Count == 0)
                    coloringDone.Add(f.Name);
            }

            return functionsToUncoloredRegisters;
        }

        public ProgramBlock<SparcInstruction> DoAllocation(ProgramBlock<SparcInstruction> start)
        {
            numRegs = getMaxRegValue(start) + 1;
            spilleds = new BitArray(numRegs);

            while (true)
            {
                setupVars(start);
                doGenAndKill(start);
                doLiveoutSets(start);
                doGraph(start);
                var uncoloredRegs = colorGraph(start);

                if (uncoloredRegs.Select(r => r.Value.Count).Sum() == 0)
                    break;

                var regsToSpill = new BitArray(numRegs);

                foreach (var kvp in uncoloredRegs)
                {
                    if (kvp.Value.Count != 0)
                    {
                        var rToSpill = kvp.Value.Where(r => !spilleds[r]).Where(r => getSparcRegister(r) == null).First();
                        regsToSpill.Set(rToSpill, true);
                    }
                }

                spilleds.Or(regsToSpill);

                start = (ProgramBlock<SparcInstruction>)start.Convert(new SpillConverter(regsToSpill));

                //Console.WriteLine("spilled {0} regs, trying again", regsToSpill.TrueIndexs().Count());
            }

            //print(start);

            return (ProgramBlock<SparcInstruction>)start.Convert(new SparcRegisterConverter(colorMapping));
        }

        private void print(ProgramBlock<SparcInstruction> start)
        {
            foreach (var k in genSets.Keys)
            {
                Console.WriteLine("Block {0} with {1} instrs", k.Label, k.Code.Count);
                var kset = killSets[k];
                var gset = genSets[k];
                var lset = liveoutSets[k];
                for (int i = 0; i < numRegs; i++)
                {
                    if (gset[i])
                        Console.WriteLine("g:{0}", getRegister(i));
                    if (kset[i])
                        Console.WriteLine("k:{0}", getRegister(i));
                    if (lset[i])
                        Console.WriteLine("l:{0}", getRegister(i));
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
                    Console.Write("{0},", getRegister(i));
                }
                Console.WriteLine();
                for (int i = 0; i < numRegs; i++)
                {
                    Console.Write("{0},", getRegister(i));
                    for (int j = 0; j < numRegs; j++)
                    {
                        Console.Write("{0},", dgraph[i][j] ? "█" : "░");
                    }
                    Console.WriteLine();
                }
            }
        }

        private Register getRegister(int id)
        {
            if (id >= virtToSparc.Length || virtToSparc[id] == null)
                return new VirtualRegister(id);
            return virtToSparc[id];
        }

        private SparcRegister getSparcRegister(int id)
        {
            if (id >= virtToSparc.Length || virtToSparc[id] == null)
                return null;
            return virtToSparc[id];
        }
    }
}
