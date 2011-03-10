using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.IL;
using CSC431.CFG;

namespace CSC431.Analysis
{
    class CopyPropagation : IterativeDataflow<MilocInstruction>
    {
        private Dictionary<BasicBlock<MilocInstruction>, List<MovInstruction>> genSets;
        private Dictionary<BasicBlock<MilocInstruction>, List<int>> killSets;
        private Dictionary<BasicBlock<MilocInstruction>, List<MovInstruction>> reachingCopies;


        public CopyPropagation()
        {
            genSets = new Dictionary<BasicBlock<MilocInstruction>, List<MovInstruction>>();
            killSets = new Dictionary<BasicBlock<MilocInstruction>, List<int>>();
            reachingCopies = new Dictionary<BasicBlock<MilocInstruction>, List<MovInstruction>>();
        }

        protected override void CalculateLocal(FunctionBlock<MilocInstruction> fun, BasicBlock<MilocInstruction> block)
        {
            var gen = new List<MovInstruction>();
            var kill = new List<int>();

            for (int i = block.Code.Count - 1; i >= 0; i--)
            {
                var instr = block.Code[i];
                if (instr is MovInstruction)
                {
                    var mov = instr as MovInstruction;
                    if (!kill.Contains(mov.RegDest0.IntVal) && !kill.Contains(mov.RegSource0.IntVal))
                    {
                        gen.Add(mov);
                    }
                }
                foreach (var r in instr.DestRegs)
                {
                    kill.Add(r.IntVal);
                }
            }

            genSets[block] = gen;
            killSets[block] = kill;
        }

        protected override bool Propagate(FunctionBlock<MilocInstruction> fun, BasicBlock<MilocInstruction> block)
        {
            foreach (var p in GetPredecessors(block))
            {

            }

            bool changed = false;
            return changed;
        }
    }
}
