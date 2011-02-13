using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.Steps;
using CSC431.CFG;
using CSC431.IL;
using CSC431.LLVM;

namespace CSC431
{
    static class LlvmSteps
    {
        public static InOutStep<ProgramBlock<MilocInstruction>, ProgramBlock<LlvmInstruction>> ConvertToLlvm()
        {
            return new InOutStep<ProgramBlock<MilocInstruction>, ProgramBlock<LlvmInstruction>>(c =>
            {
                return c.Convert(new MilocConverter<LlvmInstruction>(new LlvmTranslator())) as ProgramBlock<LlvmInstruction>;
            });
        }

        public static InStep<ProgramBlock<LlvmInstruction>> PrintCFG()
        {
            return new InStep<ProgramBlock<LlvmInstruction>>(c =>
            {
                c.Print(Console.Out, null);
            });
        }
    }
}
