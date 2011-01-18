using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.IL
{
    public class BasicBlock : Node
    {
        private Node next;
        private List<CSC431.IL.Instruction> code = new List<IL.Instruction>();
        
        public const int InvalidReg = -1;
        public const int CCNotReg = -2;

        private int register = InvalidReg;
        /// <summary>
        /// Used when there is a single expression in a basic block to record which register has the expression result in it.
        /// </summary>
        /// <remarks>
        /// Only valid when creating the inital control flow graph, may be lost later.
        /// </remarks>
        public int Reg
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

        /// <summary>
        /// Contains the type of struct that <see cref="Reg"/> points to.  Null/empty string
        /// means that Reg does not contain a pointer to a struct.
        /// </summary>
        /// <remarks>
        /// This is for use in the selector and lvalue rules.
        /// </remarks>
        public string StructType { get; set; }

        public void Add(CSC431.IL.Instruction line)
        {
            code.Add(line);
        }
        public void Add(BasicBlock lines)
        {
            code.AddRange(lines.code);
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
            while ((other = next as BasicBlock) != null)
            {
                this.code.AddRange(other.code);
                this.next = other.next;
            }
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
