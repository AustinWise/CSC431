using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.Sparc
{
    public class SparcPrinter : Printer<SparcInstruction>
    {
        public override void PrintFileHeader(System.IO.TextWriter tw, ProgramBlock<SparcInstruction> prog)
        {
            tw.WriteLine("	.section        \".text\"");
        }

        public override void PrintFunctionHeader(System.IO.TextWriter tw, FunctionBlock<SparcInstruction> f)
        {
            tw.WriteLine("	.align 4");
            tw.WriteLine("	.global {0}", f.Name);
            tw.WriteLine(".type    {0}, #function", f.Name);
            tw.WriteLine("{0}:", f.Name);
        }

        public override void PrintFileFooter(System.IO.TextWriter tw, ProgramBlock<SparcInstruction> prog)
        {
            foreach (var g in Program.Stable.Declares)
            {
                if (g.Value.isFun())
                    continue;
                tw.WriteLine("	.common {0},4,4", g.Key);
            }
            tw.WriteLine(Properties.Resources.SparcDataSection);
        }

        public override void PrintFunctionFooter(System.IO.TextWriter tw, FunctionBlock<SparcInstruction> f)
        {
            tw.WriteLine("	.size    {0}, .-{0}", f.Name);
        }

        public override void PrintNodeHeader(System.IO.TextWriter tw, Node<SparcInstruction> f)
        {
            if (f.PrintLabel)
                tw.WriteLine(".L{0}:", f.Label);
        }
    }
}
