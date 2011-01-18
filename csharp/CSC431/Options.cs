using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Antlr.Runtime;

namespace CSC431
{
    public static class Options
    {
        static Options()
        {
            InputFile = null;
            DisplayAST = false;
        }

        private const String DISPLAYAST = "-displayAST";

        public static String InputFile { get; set; }
        public static bool DisplayAST { get; set; }

        public static void ParseParameters(String[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Equals(DISPLAYAST))
                {
                    DisplayAST = true;
                }
                else if (args[i][0] == '-')
                {
                    throw new Exception("unexpected option: " + args[i]);
                }
                else if (InputFile != null)
                {
                    throw new Exception("too many files specified");
                }
                else
                {
                    InputFile = args[i];
                }
            }
        }
    }
}
