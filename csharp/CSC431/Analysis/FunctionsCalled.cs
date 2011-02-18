using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;
using CSC431.IL;
using CSC431.Steps;

namespace CSC431.Analysis
{
    public static class FunctionsCalled
    {
        private static ProgramBlock<MilocInstruction> Do(ProgramBlock<MilocInstruction> prog)
        {
            foreach (var f in prog.Functions)
            {
                var calleds = new List<string>();
                f.VisitBlocks(b =>
                {
                    foreach (var i in b.Code)
                    {
                        var call = i as CallInstruction;
                        if (call != null)
                        {
                            if (!calleds.Contains(call.Str0))
                            {
                                calleds.Add(call.Str0);
                            }
                        }
                    }
                });
                f.FunctionsCalled = calleds;

                var argCounts = calleds.Select(funName => Program.Stable.Children.Where(n => n.Name == funName).First().Formals.Count);
                if (argCounts.Any())
                    f.MaxOutArgs = argCounts.Max();
            }

            return prog;
        }

        public static TransformStep<ProgramBlock<MilocInstruction>> Step()
        {
            return new TransformStep<ProgramBlock<MilocInstruction>>(Do);
        }
    }
}
