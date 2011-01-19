using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Stack
{
    public abstract class StackInstruction : CSC431.CFG.Instruction
    {
        public StackInstruction(string name)
            : base(name)
        {
        }
    }
}
