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
        public static InOutStep<ProgramBlock<MilocInstruction>, ProgramBlock<SparcInstruction>> ConvertToSparc()
        {
            return new InOutStep<ProgramBlock<MilocInstruction>, ProgramBlock<SparcInstruction>>(c =>
            {
                return c.Convert(new MilocConverter<SparcInstruction>(new SparcTranslator())) as ProgramBlock<SparcInstruction>;
            });
        }

        public static InStep<ProgramBlock<SparcInstruction>> PrintCFG(System.IO.TextWriter outfile)
        {
            return new InStep<ProgramBlock<SparcInstruction>>(c =>
            {
                c.Print(outfile, new SparcPrinter());
            });
        }

        public static TransformStep<ProgramBlock<SparcInstruction>> RegisterAllocation()
        {
            return new TransformStep<ProgramBlock<SparcInstruction>>(prog => new RegisterAllocation().DoAllocation(prog));
        }

        public static TransformStep<ProgramBlock<SparcInstruction>> SetStacks()
        {
            return new TransformStep<ProgramBlock<SparcInstruction>>(prog =>
            {
                foreach (var f in prog.Functions)
                {
                    var thisF = f;
                    thisF.VisitBlocks(b =>
                    {
                        foreach (var i in b.Code)
                        {
                            var save = i as SaveInstruction;
                            if (save != null)
                            {
                                save.SetStackSizes(thisF);
                            }
                        }
                    });
                }
                return prog;
            });
        }
    }
}
