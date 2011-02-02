using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class BasicBlock<T> : Node<T> where T : Instruction
    {
        private List<Node<T>> nexts = new List<Node<T>>();
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
                return nexts.ToArray();
            }
        }

        public override void SetNext(Node<T> next)
        {
            this.nexts.Add(next);
        }

        public void Merge()
        {
            BasicBlock<T> other;
            while (this.nexts.Count == 1 && (other = nexts[0] as BasicBlock<T>) != null)
            {
                this.code.AddRange(other.code);
                this.nexts.Clear();
                this.nexts.AddRange(other.nexts);
            }
        }

        protected override void PrintCore(System.IO.TextWriter tw)
        {
            foreach (var l in this.code)
            {
                tw.WriteLine(l.ToString());
            }
        }

        public override Node<T> FirstNode
        {
            get { return this; }
        }

        protected override Node<Target> ConvertCore<Target>(IInstructionConverter<T, Target> conv)
        {
            var copy = new BasicBlock<Target>();
            copy.code.AddRange(conv.Convert(new InstructionStream<T>(code)));
            copy.Reg = this.register;
            copy.StructType = StructType;
            return copy;
        }
    }
}
