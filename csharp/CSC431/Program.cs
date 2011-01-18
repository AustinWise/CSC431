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
            args = new[] { "test.ev" };
            Options.ParseParameters(args);

            var pipe = FrontEndSteps.CreateLexer
                .FollowWith(FrontEndSteps.Parse);

            if (Options.DisplayAST)
                pipe.FollowWith(FrontEndSteps.PrintAst);

            var flow = pipe.FollowWith(FrontEndSteps.TypeCheck)
                .FollowWith(IlSteps.MakeCFG);

            flow.FollowWith(IlSteps.CleanUpCfg).FollowWith(IlSteps.PrintCFG);

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