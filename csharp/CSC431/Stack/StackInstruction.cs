using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Stack
{
    public abstract class StackInstruction : CSC431.CFG.Instruction
    {
        public StackInstruction(string name, int popped, int pushed)
            : base(name)
        {
            this.Popped = popped;
            this.Pushed = pushed;
        }

        public int Pushed { get; private set; }
        public int Popped { get; private set; }

    }
}
