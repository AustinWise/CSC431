using System;
using System.Collections.Generic;
using System.Text;
using CSC431.Steps;

namespace CSC431
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            Options.ParseParameters(args);

            var pipe = FrontEndSteps.CreateLexer
                .FollowWith(FrontEndSteps.Parse);

            if (Options.DisplayAST)
                pipe.FollowWith(FrontEndSteps.PrintAst);

            var typeChecked = pipe.FollowWith(FrontEndSteps.TypeCheck);
            var flow = typeChecked.FollowWith(IlSteps.MakeCFG);
            flow.FollowWith(IlSteps.CleanUpCfg).FollowWith(IlSteps.PrintCFG);

            typeChecked.FollowWith(StackSteps.MakeClrExe);

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