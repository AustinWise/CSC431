using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    class BasicBlock : Node
    {
        private Node next;
        private List<CSC431.ILOC.Instruction> code = new List<ILOC.Instruction>();

        private int register = -1;
        /// <summary>
        /// Used when there is a single expression in a basic block to record which register has the expression result in it.
        /// </summary>
        /// <remarks>
        /// Only valid when creating the inital control flow graph, may be lost later.
        /// </remarks>
        public int ExpressionRegister
        {
            get
            {
                if (register == -1)
                    throw new Exception("Register was not set.");
                return register;
            }
            set
            {
                this.register = value;
            }
        }

        public void AddLine(CSC431.ILOC.Instruction line)
        {
            code.Add(line);
        }

        public override Node[] Nexts
        {
            get
            {
                if (next == null)
                    return new Node[0];
                return new Node[] { next };
            }
        }

        public override void SetNext(Node next)
        {
            this.next = next;
        }

        public MultiBlock ToMulti()
        {
            var b = new MultiBlock(this.code);
            if (next != null)
                b.SetNext(next);
            return b;
        }

        public void Merge()
        {
            BasicBlock other;
            if ((other = next as BasicBlock) != null)
            {
                this.code.AddRange(other.code);
                this.next = other.next;
            }
        }
    }
}
