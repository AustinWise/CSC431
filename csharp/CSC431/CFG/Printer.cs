using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSC431.CFG
{
    public abstract class Printer<T> where T : Instruction
    {
        public abstract void PrintFileHeader(TextWriter tw, ProgramBlock<T> prog);
        public abstract void PrintFunctionHeader(TextWriter tw, FunctionBlock<T> f);
        public abstract void PrintFileFooter(TextWriter tw, ProgramBlock<T> prog);
        public abstract void PrintFunctionFooter(TextWriter tw, FunctionBlock<T> f);
        public abstract void PrintNodeHeader(TextWriter tw, Node<T> f);
    }
}
