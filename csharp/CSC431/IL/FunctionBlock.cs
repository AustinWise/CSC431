using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.IL
{
    public class FunctionBlock<T> : Node<T> where T : Instruction
    {
        public string Name { get; private set; }
        public SeqBlock<T> Body { get; private set; }

        public FunctionBlock(string name, SeqBlock<T> body)
        {
            this.Name = name;
            this.Body = body;
        }

        public override Node<T>[] Nexts
        {
            get { return new Node<T>[] { Body }; }
        }

        public override void SetNext(Node<T> next)
        {
            throw new NotSupportedException();
        }

        protected override void PrintCore(System.IO.TextWriter tw)
        {
            tw.WriteLine("{0}:", Name);
            Body.Print(tw);
        }
    }
}
