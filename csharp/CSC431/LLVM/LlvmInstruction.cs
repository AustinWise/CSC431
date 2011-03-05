using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.LLVM
{
    public abstract class LlvmInstruction : Instruction
    {
        public LlvmInstruction(string name)
            : base(name)
        {
        }

        public override bool IsCritical
        {
            get { return true; }
        }
    }
}
