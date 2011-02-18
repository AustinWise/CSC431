using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Antlr.Runtime;
using NDesk.Options;
using CSC431.Steps;

namespace CSC431
{
    public static class Options
    {
        public static TaskLocal<Stream> InputSource = new TaskLocal<Stream>();
        private static TaskLocal<String> InputFile = new TaskLocal<string>();
        public static TaskLocal<bool> DisplayAST = new TaskLocal<bool>();
        public static TaskLocal<bool> DumpIL = new TaskLocal<bool>();
        public static TaskLocal<string> ClrExec = new TaskLocal<string>();
        public static TaskLocal<bool> Llvm = new TaskLocal<bool>();

        public static void ParseParameters(String[] args)
        {
            var os = new OptionSet()
            {
                {"displayAST", v=> DisplayAST.Value = v != null},
                {"dumpIL", v=> DumpIL.Value = v != null},
                {"clrExe=", v=> ClrExec.Value = v},
                {"llvm", v=> Llvm.Value = v != null},
            };

            var extras = os.Parse(args);
            foreach (var e in extras)
            {
                if (e.StartsWith("-"))
                    throw new EvilException("unexpected option: " + e);
                else if (InputFile.Value != null)
                {
                    throw new EvilException("too many files specified");
                }
                else
                {
                    InputFile.Value = e;
                }
            }

            if (InputFile.Value == null)
            {
                InputSource.Value = Console.OpenStandardInput();
            }
            else
            {
                InputSource.Value = new FileStream(Options.InputFile.Value, FileMode.Open, FileAccess.Read);
            }
        }

        public static Step CreatePipe(Func<InStep<CSC431.CFG.ProgramBlock<Sparc.SparcInstruction>>> outputer)
        {
            var pipe = FrontEndSteps.CreateLexer()
                .FollowWith(FrontEndSteps.Parse());

            if (Options.DisplayAST.Value)
                pipe.FollowWith(FrontEndSteps.PrintAst());

            var typeChecked = pipe.FollowWith(FrontEndSteps.TypeCheck());
            var flow = typeChecked.FollowWith(IlSteps.MakeCFG()).FollowWith(IlSteps.CleanUpCfg());

            if (Options.DumpIL.Value)
                flow.FollowWith(IlSteps.PrintCFG());

            if (Options.Llvm.Value)
            {
                var llvm = flow.FollowWith(LlvmSteps.ConvertToLlvm());
                //llvm.FollowWith(LlvmSteps.PrintCFG());
                llvm.FollowWith(LlvmSteps.BitcodeToSparc());
            }

            if (!(Options.DumpIL.Value || Options.Llvm.Value))
            {
                flow.FollowWith(Analysis.FunctionsCalled.Step())
                    .FollowWith(SparcSteps.ConvertToSparc())
                    .FollowWith(SparcSteps.RegisterAllocation())
                    .FollowWith(outputer());
            }

            if (!string.IsNullOrEmpty(Options.ClrExec.Value))
                typeChecked.FollowWith(StackSteps.MakeClrExe());

            return pipe;
        }
    }
}
