using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class BasicBlock<T> : Node<T> where T : Instruction
    {
        private Node<T> next;
        private List<T> code = new List<T>();

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

        public void Add(T line)
        {
            code.Add(line);
        }
        public void Add(BasicBlock<T> lines)
        {
            code.AddRange(lines.code);
        }

        public override Node<T>[] Nexts
        {
            get
            {
                if (next == null)
                    return new Node<T>[0];
                return new Node<T>[] { next };
            }
        }

        public override void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public MultiBlock<T> ToMulti()
        {
            var b = new MultiBlock<T>(this.Label, this.code);
            if (next != null)
                b.SetNext(next);
            return b;
        }

        public void Merge()
        {
            BasicBlock<T> other;
            while ((other = next as BasicBlock<T>) != null)
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
