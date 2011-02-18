using System;
using System.Collections.Generic;
using System.Text;
using CSC431.Steps;
using System.Threading.Tasks;

namespace CSC431
{
    public static class Program
    {
        public static TaskLocal<FrontEnd.StructTypes> Stypes = new TaskLocal<FrontEnd.StructTypes>();
        public static TaskLocal<FrontEnd.SymbolTable> Stable = new TaskLocal<FrontEnd.SymbolTable>();

        public static int Main(String[] args)
        {
            args = new[] { "test.ev" };
            var t = new Task(() =>
            {
                Options.ParseParameters(args);
                Step.DoAll(Options.CreatePipe(SparcSteps.PrintCFG));
            });
            t.RunSynchronously();

            if (t.IsFaulted)
            {
                var ex = t.Exception as AggregateException;
                Console.WriteLine(ex.InnerExceptions[0].Message);
                return 1;
            }

            return 0;
        }
    }
}