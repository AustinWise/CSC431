using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    class SeqBlock : Node
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
    }
}
