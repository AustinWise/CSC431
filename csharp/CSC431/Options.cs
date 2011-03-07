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
        public static readonly TaskLocal<Stream> InputSource = new TaskLocal<Stream>();
        private static readonly TaskLocal<String> InputFile = new TaskLocal<string>();
        public static readonly TaskLocal<bool> DisplayAST = new TaskLocal<bool>();
        public static readonly TaskLocal<bool> DumpIL = new TaskLocal<bool>();
        public static readonly TaskLocal<bool> DumpLL = new TaskLocal<bool>();
        public static readonly TaskLocal<string> ClrExec = new TaskLocal<string>();
        public static readonly TaskLocal<bool> Llvm = new TaskLocal<bool>();
        public static readonly TaskLocal<bool> DisableRegAlloc = new TaskLocal<bool>();
        public static readonly TaskLocal<bool> DisableOpt = new TaskLocal<bool>();
        public static readonly TaskLocal<bool> DisplayHelp = new TaskLocal<bool>();
        public static readonly TaskLocal<bool> DisplayStepGraph = new TaskLocal<bool>();
        public static readonly TaskLocal<LlvmArch> LlvmArch = new TaskLocal<LlvmArch>(CSC431.LlvmArch.SparcV9);

        private static readonly OptionSet optionSet;

        static Options()
        {
            optionSet = new OptionSet()
            {
                {"displayAST", "Displays the AST.", v=> DisplayAST.Value = v != null},
                {"dumpIL", "Dumps the generated miloc.  The unoptimized dump should be compatible with Mochi.", v=> DumpIL.Value = v != null},
                {"noOpt", "Disables optimizations.", v=> DisableOpt.Value = v != null},
                {"clrExe=", "Creates a .NET EXE with the given name.", v=> ClrExec.Value = v},
                {"llvm", "Uses LLVM for optimization and code generation. Incomplete.", v=> Llvm.Value = v != null},
                {"llvmArch=", "Architecture to generate code for. Valid values are x86, x64, and SparcV9.  Defaults to SparcV9.", (LlvmArch v) => LlvmArch.Value=v},
                {"dumpLL", "Dumps the generated LLVM code.", v=> DumpLL.Value = v != null},
                {"displayGraph", "Displays the compiler's dataflow graph for the given arguments.", v=> DisplayStepGraph.Value = v != null},
                {"help|h|?", "Displays this help message.", v=> DisplayHelp.Value = v != null},
            };
        }

        public static void ParseParameters(String[] args)
        {
            var extras = optionSet.Parse(args);
            foreach (var e in extras)
            {
                if (e.StartsWith("-"))
                    throw new EvilException(EvilSystem.Options, "Unexpected option: " + e);
                else if (InputFile.Value != null)
                {
                    throw new EvilException(EvilSystem.Options, "Too many files specified.");
                }
                else
                {
                    InputFile.Value = e;
                }
            }

            if (Options.Llvm.Value)
                Options.DisableOpt.Value = true;

            if (InputFile.Value == null)
            {
                InputSource.Value = Console.OpenStandardInput();
            }
            else
            {
                try
                {
                    InputSource.Value = new FileStream(Options.InputFile.Value, FileMode.Open, FileAccess.Read);
                }
                catch (IOException ex)
                {
                    throw new EvilException(EvilSystem.Options, "Failed to open file.", ex);
                }
            }
        }

        public static Step CreatePipe(TextWriter outfile)
        {
            var pipe = FrontEndSteps.CreateLexer()
                .FollowWith(FrontEndSteps.Parse());

            if (Options.DisplayAST.Value)
            {
                pipe.FollowWith(FrontEndSteps.PrintAst());
                return pipe.AsStep();
            }

            var typeChecked = pipe.FollowWith(FrontEndSteps.TypeCheck());
            var flow = typeChecked.FollowWith(IlSteps.MakeCFG()).FollowWith(IlSteps.CleanUpCfg());

            if (Options.DumpIL.Value)
                flow.FollowWith(IlSteps.PrintCFG("dump.il"));

            if (Options.Llvm.Value)
            {
                var llvm = flow.FollowWith(LlvmSteps.PropegateNullPointers())
                    .FollowWith(LlvmSteps.ConvertToLlvm());
                if (Options.DumpLL.Value)
                    llvm.FollowWith(LlvmSteps.PrintCFG());
                llvm.FollowWith(LlvmSteps.BitcodeToSparc(outfile));
            }

            if (!Options.DisableOpt.Value)
            {
                flow = flow.FollowWith(OptSteps.ConstantFolding());
                flow = flow.FollowWith(OptSteps.PowerReduction());
                flow = flow.FollowWith(OptSteps.UselessCodeRemoval());
                //flow = flow.FollowWith(OptSteps.CommonSubExprElim());

                if (Options.DumpIL.Value)
                    flow.FollowWith(IlSteps.PrintCFG("afterOpt.il"));
            }


            if (!Options.Llvm.Value)
            {
                var sparc = flow.FollowWith(Analysis.FunctionsCalled.Step())
                    .FollowWith(SparcSteps.ConvertToSparc());

                if (!Options.DisableRegAlloc.Value)
                    sparc = sparc.FollowWith(SparcSteps.RegisterAllocation());

                sparc.FollowWith(SparcSteps.SetStacks())
                     .FollowWith(SparcSteps.PrintCFG(outfile));
            }

            if (!string.IsNullOrEmpty(Options.ClrExec.Value))
                typeChecked.FollowWith(StackSteps.MakeClrExe());

            return pipe.AsStep();
        }

        public static void WriteOptionDescriptions(TextWriter o)
        {
            optionSet.WriteOptionDescriptions(o);
        }
    }
}
