using System;
using System.Collections.Generic;
using System.Text;
using CSC431.Steps;

namespace CSC431
{
    public static class Program
    {
        public static FrontEnd.StructTypes Stypes;
        public static FrontEnd.SymbolTable Stable;

        public static void Main(String[] args)
        {
            args = new[] { "test.ev" };
            try
            {
                Options.ParseParameters(args);
            }
            catch (EvilException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            var pipe = FrontEndSteps.CreateLexer()
                .FollowWith(FrontEndSteps.Parse());

            if (Options.DisplayAST)
                pipe.FollowWith(FrontEndSteps.PrintAst());

            var typeChecked = pipe.FollowWith(FrontEndSteps.TypeCheck());
            var flow = typeChecked.FollowWith(IlSteps.MakeCFG()).FollowWith(IlSteps.CleanUpCfg());

            if (Options.DumpIL)
                flow.FollowWith(IlSteps.PrintCFG());

            if (Options.Llvm)
            {
                var llvm = flow.FollowWith(LlvmSteps.ConvertToLlvm());
                //llvm.FollowWith(LlvmSteps.PrintCFG());
                llvm.FollowWith(LlvmSteps.BitcodeToSparc());
            }

            if (!(Options.DumpIL || Options.Llvm))
            {
                flow.FollowWith(Analysis.FunctionsCalled.Step())
                    .FollowWith(SparcSteps.ConvertToSparc())
                    .FollowWith(SparcSteps.RegisterAllocation())
                    .FollowWith(SparcSteps.PrintCFG());
            }

            if (!string.IsNullOrEmpty(Options.ClrExec))
                typeChecked.FollowWith(StackSteps.MakeClrExe());

            try
            {
                Step.DoAll(pipe);
            }
            catch (EvilException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}