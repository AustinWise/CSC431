using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.ILOC
{
    class SingleLabelInstruction : Instruction
    {
        public SingleLabelInstruction(string name, int label)
            : base(name)
        {
            this.Label = label;
        }

        public int Label { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} L{1}", Name, Label);
        }
    }
}
