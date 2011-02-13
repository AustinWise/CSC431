using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace CSC431.CFG
{
    public abstract class Node<T> where T : Instruction
    {
        private static int LabelCounter = 0;

        public Node()
        {
            this.Label = Interlocked.Increment(ref LabelCounter);
        }

        public bool PrintLabel { get; set; }
        public int Label { get; protected set; }

        public abstract Node<T>[] Nexts { get; }
        public abstract Node<T> FirstNode { get; }
        public bool IsReturn { get; set; }

        abstract public void SetNext(Node<T> next);

        /// <summary>
        /// Indicates that there the tree is ready to use.
        /// </summary>
        public virtual bool IsFixedUp
        {
            get
            {
                return true;
            }
        }

        public void Visit(Action<Node<T>> fun)
        {
            VisitInner(new List<Node<T>>(), fun);
        }

        private void VisitInner(List<Node<T>> seen, Action<Node<T>> fun)
        {
            if (seen.Contains(this))
                return;
            seen.Add(this);

            fun(this);
            foreach (var n in this.Nexts)
            {
                n.VisitInner(seen, fun);
            }
        }

        public void Print(TextWriter tw, Printer<T> printer)
        {
            printer.PrintNodeHeader(tw, this);
            PrintCore(tw, printer);
        }

        protected abstract void PrintCore(TextWriter tw, Printer<T> printer);

        public Node<Target> Convert<Target>(IInstructionConverter<T, Target> conv) where Target : Instruction
        {
            var copy = this.ConvertCore(conv);
            copy.Label = Label;
            copy.IsReturn = IsReturn;
            return copy;
        }

        protected abstract Node<Target> ConvertCore<Target>(IInstructionConverter<T, Target> conv) where Target : Instruction;
    }
}
