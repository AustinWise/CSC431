﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.Steps;
using CSC431.CFG;
using CSC431.Analysis;

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
            return new TransformStep<ProgramBlock<IL.MilocInstruction>>(new UselessCodeRemoval().DoOpt);
        }

        public static TransformStep<ProgramBlock<IL.MilocInstruction>> PowerReduction()
        {
            return new TransformStep<ProgramBlock<IL.MilocInstruction>>(new PowerReduction().DoOpt);
        }

        public static TransformStep<ProgramBlock<IL.MilocInstruction>> ConstantFolding()
        {
            return new TransformStep<ProgramBlock<IL.MilocInstruction>>(ConstantFoldingConverter.DoOpt);
        }
    }
}
