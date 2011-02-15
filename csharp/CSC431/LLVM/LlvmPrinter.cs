using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.LLVM
{
    public class LlvmPrinter:Printer<LlvmInstruction>
    {
        public override void PrintFileHeader(System.IO.TextWriter tw, ProgramBlock<LlvmInstruction> prog)
        {
        }

        public override void PrintFunctionHeader(System.IO.TextWriter tw, FunctionBlock<LlvmInstruction> f)
        {
            var funType = Program.Stable.getType(f.Name);
            var funTable = Program.Stable.Children.Where(t => t.Name == f.Name).First();
            tw.Write("define ");
            tw.Write(funType.getReturnType().isVoid() ? "void" : "i32");
            tw.Write(" @{0}(", f.Name);

            var args = funTable.Formals;
            for (int i = 0; i < args.Count; i++)
            {
                tw.Write("i32 %{0}", args[i]);
                if (i != args.Count - 1)
                    tw.Write(", ");
            }

            tw.WriteLine(") {");
        }

        public override void PrintFileFooter(System.IO.TextWriter tw, ProgramBlock<LlvmInstruction> prog)
        {
        }

        public override void PrintFunctionFooter(System.IO.TextWriter tw, FunctionBlock<LlvmInstruction> f)
        {
            tw.WriteLine("}");
        }

        public override void PrintNodeHeader(System.IO.TextWriter tw, Node<LlvmInstruction> f)
        {
            if (f.PrintLabel)
                tw.WriteLine("L{0}:", f.Label);
        }
    }
}
