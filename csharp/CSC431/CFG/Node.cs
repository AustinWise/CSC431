using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace CSC431.CFG
{
    public abstract class Node
    {
        private static int LabelCounter = 0;

        public Node()
        {
            this.Label = Interlocked.Increment(ref LabelCounter);
        }

        public int Label { get; private set; }

        public abstract Node[] Nexts { get; }

        abstract public void SetNext(Node next);

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

        public void Visit(Action<Node> fun)
        {
            VisitInner(new List<Node>(), fun);
        }

        private void VisitInner(List<Node> seen, Action<Node> fun)
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

        public abstract void Print(TextWriter tw);
    }
}
