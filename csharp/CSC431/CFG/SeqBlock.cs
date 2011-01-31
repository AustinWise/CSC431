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
            {
                ((BasicBlock<T>)n).Merge();
                if (last is BasicBlock<T>)
                {
                    (last as BasicBlock<T>).Add(n as BasicBlock<T>);
                    return;
                }
            }

            this.last.SetNext(n.FirstNode);
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
            get { return nodes[0].Nexts; }
        }

        public override void SetNext(Node<T> next)
        {
            if (isFixed)
                throw new Exception("can't set last twice.");
            isFixed = true;
            this.last.SetNext(next.FirstNode);
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

        public override Node<T> FirstNode
        {
            get { return this.nodes[0].FirstNode; }
        }

        protected override Node<Target> ConvertCore<Target>(IInstructionConverter<T, Target> conv)
        {
            var copy = new SeqBlock<Target>();
            foreach (var n in nodes)
            {
                copy.Add(n.Convert(conv));
            }
            return copy;
        }
    }
}
