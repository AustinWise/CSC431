using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;
using CSC431.LLVM;

namespace CSC431.IL
{
    public class MilocPrinter : Printer<MilocInstruction>
    {
        public override void PrintFileHeader(System.IO.TextWriter tw, ProgramBlock<MilocInstruction> prog)
        {
            foreach (var f in prog.Functions)
            {
                tw.WriteLine("@function {0}", f.Name);
            }
            foreach (var f in prog.Functions)
            {
                foreach (var l in f.Locals)
                {
                    tw.WriteLine("@local {0}:{1}", f.Name, l);
                }
            }

            tw.WriteLine();
        }

        public override void PrintFunctionHeader(System.IO.TextWriter tw, FunctionBlock<MilocInstruction> f)
        {
            tw.WriteLine("{0}:", f.Name);
        }

        public override void PrintFileFooter(System.IO.TextWriter tw, ProgramBlock<MilocInstruction> prog)
        {
        }

        public override void PrintFunctionFooter(System.IO.TextWriter tw, FunctionBlock<MilocInstruction> f)
        {
            tw.WriteLine();
        }

        public override void PrintNodeHeader(System.IO.TextWriter tw, Node<MilocInstruction> n)
        {
            if (n.PrintLabel)
                tw.WriteLine("L{0}:", n.Label);
        }
    }
}
