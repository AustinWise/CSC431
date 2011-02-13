using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class ProgramBlock<T> : Node<T> where T : Instruction
    {
        public List<FunctionBlock<T>> Functions { get; private set; }

        public ProgramBlock(IEnumerable<FunctionBlock<T>> funs)
        {
            this.Functions = funs.ToList();
        }

        public override Node<T>[] Nexts
        {
            get { return Functions.ToArray(); }
        }

        public override void SetNext(Node<T> next)
        {
            throw new NotSupportedException();
        }

        protected override void PrintCore(System.IO.TextWriter tw, Printer<T> printer)
        {
            printer.PrintFileHeader(tw, this);

            foreach (var f in Functions)
            {
                f.Print(tw, printer);
            }

            printer.PrintFileFooter(tw, this);
        }

        public override Node<T> FirstNode
        {
            get { throw new NotSupportedException(); }
        }

        protected override Node<Target> ConvertCore<Target>(IInstructionConverter<T, Target> conv)
        {
            return new ProgramBlock<Target>(from f in Functions select f.Convert(conv) as FunctionBlock<Target>);
        }
    }
}
