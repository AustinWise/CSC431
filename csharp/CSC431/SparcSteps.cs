using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.Steps;
using CSC431.Sparc;
using CSC431.CFG;
using CSC431.IL;

namespace CSC431
{
    static class SparcSteps
    {
        public static InOutStep<ProgramBlock<MilocInstruction>, ProgramBlock<SparcInstruction>> ConvertToLlvm()
        {
            return new InOutStep<ProgramBlock<MilocInstruction>, ProgramBlock<SparcInstruction>>(c =>
            {
                return c.Convert(new MilocConverter<SparcInstruction>(new SparcTranslator())) as ProgramBlock<SparcInstruction>;
            });
        }

        public static InStep<ProgramBlock<SparcInstruction>> PrintCFG()
        {
            return new InStep<ProgramBlock<SparcInstruction>>(c =>
            {
                c.Print(Console.Out, new SparcPrinter());
            });
        }
    }
}
