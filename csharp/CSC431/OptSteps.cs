using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.Steps;
using CSC431.CFG;

namespace CSC431
{
    public static class OptSteps
    {
        public static TransformStep<ProgramBlock<IL.MilocInstruction>> CommonSubExprElim()
        {
            return new TransformStep<ProgramBlock<IL.MilocInstruction>>(Analysis.CommonSubExprElim.DoOpt);
        }

        public static TransformStep<ProgramBlock<IL.MilocInstruction>> UselessCodeRemoval()
        {
            return new TransformStep<ProgramBlock<IL.MilocInstruction>>(prog =>
            {
                var rd = new Analysis.ReachingDef<IL.MilocInstruction>(prog);
                return prog;
            });
        }
    }
}
