using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.CFG
{
    public class SeqBlock<T> : Node<T> where T : Instruction
    {
        private List<Node<T>> nodes = new List<Node<T>>();
        private Node<T> last;
        private bool isFixed = false;

        public SeqBlock()
        {
            this.last = new BasicBlock<T>();
            this.nodes.Add(last);
        }

        public void Add(Node<T> n)
        {
            if (n is BasicBlock<T>)
                ((BasicBlock<T>)n).Merge();

            this.last.SetNext(n);
            this.nodes.Add(n);
            this.last = n;
        }

        public void Add(T n)
        {
            var b = new BasicBlock<T>();
            b.Add(n);
            this.Add(b);
        }

        public override Node<T>[] Nexts
        {
            get { return new Node<T>[] { nodes[0] }; }
        }

        public override void SetNext(Node<T> next)
        {
            if (isFixed)
                throw new Exception("can't set last twice.");
            isFixed = true;
            this.last.SetNext(next);
        }

        public override bool IsFixedUp
        {
            get
            {
                return isFixed;
            }
        }

        protected override void PrintCore(System.IO.TextWriter tw)
        {
            foreach (var n in nodes)
            {
                n.Print(tw);
            }
        }
    }
}
