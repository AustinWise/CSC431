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
                var bb = n as BasicBlock<T>;
                bb.Merge();
                this.IsReturn |= bb.IsReturn;
                if (last is BasicBlock<T>)
                {
                    (last as BasicBlock<T>).Add(bb);
                    return;
                }
            }

            this.last.SetNext(n.FirstNode);
            this.nodes.Add(n);
            this.last = n;
        }

        public void AddAtTop(Node<T> n)
        {
            if (nodes.Count == 0)
            {
                this.Add(n);
                return;
            }

            n.SetNext(nodes[0]);
            this.nodes.Insert(0, n);
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

        protected override void PrintCore(System.IO.TextWriter tw, Printer<T> printer)
        {
            foreach (var n in nodes)
            {
                n.Print(tw, printer);
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
