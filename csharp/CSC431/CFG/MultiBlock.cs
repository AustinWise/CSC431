using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class MultiBlock<T> : Node<T> where T : Instruction
    {
        public MultiBlock(int label)
        {
            this.code = new List<T>();
            this.Label = label;
        }

        public MultiBlock(int label, List<T> code)
        {
            this.code = code;
            this.Label = label;
        }

        private List<T> code;
        private List<Node<T>> nexts = new List<Node<T>>();

        public void AddLine(T line)
        {
            code.Add(line);
        }

        public override Node<T>[] Nexts
        {
            get { return nexts.ToArray(); }
        }

        public override void SetNext(Node<T> next)
        {
            nexts.Add(next);
        }

        protected override void PrintCore(System.IO.TextWriter tw)
        {
            foreach (var l in this.code)
            {
                tw.WriteLine(l.ToString());
            }
        }
    }
}
