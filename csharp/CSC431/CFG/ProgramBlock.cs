using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class ProgramBlock<T> : Node<T> where T : Instruction
    {
        public List<FunctionBlock<T>> Functions { get; private set; }

        public ProgramBlock(List<FunctionBlock<T>> funs)
        {
            this.Functions = funs;
        }

        public override Node<T>[] Nexts
        {
            get { return Functions.ToArray(); }
        }

        public override void SetNext(Node<T> next)
        {
            throw new NotSupportedException();
        }

        protected override void PrintCore(System.IO.TextWriter tw)
        {
            foreach (var f in Functions)
            {
                tw.WriteLine("@function {0}", f.Name);
            }

            tw.WriteLine();

            foreach (var f in Functions)
            {
                f.Print(tw);
                tw.WriteLine();
            }
        }
    }
}
