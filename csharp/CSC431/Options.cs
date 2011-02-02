using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Antlr.Runtime;
using NDesk.Options;

namespace CSC431
{
    public static class Options
    {
        static Options()
        {
            InputFile = null;
            DisplayAST = false;
        }

        public static String InputFile { get; set; }
        public static bool DisplayAST { get; set; }
        public static bool DumpIL { get; set; }
        public static string ClrExec { get; set; }
        public static bool Llvm { get; set; }

        public static void ParseParameters(String[] args)
        {
            var os = new OptionSet()
            {
                {"displayAST", v=> DisplayAST = v != null},
                {"dumpIL", v=> DumpIL = v != null},
                {"clrExe=", v=> ClrExec = v},
                {"llvm", v=> Llvm = v != null},
            };

            var extras = os.Parse(args);
            foreach (var e in extras)
            {
                if (e.StartsWith("-"))
                    throw new EvilException("unexpected option: " + e);
                else if (InputFile != null)
                {
                    throw new EvilException("too many files specified");
                }
                else
                {
                    InputFile = e;
                }
            }
        }
    }
}
