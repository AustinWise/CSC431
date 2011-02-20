using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.Sparc
{
    public abstract class SparcInstruction : Instruction
    {
        public SparcInstruction(string name)
            : base(name)
        {
        }

    }
}
