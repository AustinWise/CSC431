using System;
using System.Collections.Generic;
using System.Text;
using CSC431.Steps;
using System.Threading.Tasks;

namespace CSC431
{
    public static class Program
    {
        public static readonly TaskLocal<FrontEnd.StructTypes> Stypes = new TaskLocal<FrontEnd.StructTypes>();
        public static readonly TaskLocal<FrontEnd.SymbolTable> Stable = new TaskLocal<FrontEnd.SymbolTable>();

        public static int Main(String[] args)
        {
            var t = new Task(() =>
            {
                Options.ParseParameters(args);
                if (Options.DisplayHelp.Value)
                    Options.WriteOptionDescriptions(Console.Out);
                else if (Options.DisplayStepGraph.Value)
                    Console.WriteLine(Step.MakeGraph(Options.CreatePipe(null)));
                else
                    Step.DoAll(Options.CreatePipe(Console.Out));
            });
            t.RunSynchronously();

            if (t.IsFaulted)
            {
                var ex = (t.Exception as AggregateException).InnerExceptions[0];

                string str;
                if (ex is EvilException)
                {
                    var evEx = ex as EvilException;
                    str = "Error: " + evEx.System.ToString() + ": ";
                    if (evEx.System == EvilSystem.Llvm)
                        str += "\n";
                }
                else
                {
                    str = "INTERNAL ERROR, you broke the compiler: ";
                }
                str += ex.Message;
                if (ex.InnerException != null)
                    str += "\n\t" + ex.InnerException.Message;

                Console.WriteLine(str);
                Console.WriteLine("Run with -help for information about command line switches.");

                return 1;
            }

            return 0;
        }
    }
}