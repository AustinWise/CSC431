using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.ILOC
{
    class DoubleLabelInstruction : Instruction
    {
        public DoubleLabelInstruction(string name, int l1, int l2)
            : base(name)
        {
            this.L1 = l1;
            this.L2 = l2;
        }

        public int L1 { get; private set; }
        public int L2 { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} L{1}, L{2}", Name, L1, L2);
        }
    }
}
