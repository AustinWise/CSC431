using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class SeqBlock : Node
    {
        private List<Node> nodes = new List<Node>();
        private Node last;
        private bool isFixed = false;

        public SeqBlock()
        {
            this.last = new BasicBlock();
            this.nodes.Add(last);
        }

        public void Add(Node n)
        {
            if (n is BasicBlock)
                ((BasicBlock)n).Merge();

            this.last.SetNext(n);
            this.nodes.Add(n);
            this.last = n;
        }

        public override Node[] Nexts
        {
            get { return new Node[] { nodes[0] }; }
        }

        public override void SetNext(Node next)
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

        public override void Print(System.IO.TextWriter tw)
        {
            foreach (var n in nodes)
            {
                n.Print(tw);
            }
        }
    }
}
