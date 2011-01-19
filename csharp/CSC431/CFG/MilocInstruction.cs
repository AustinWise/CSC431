using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public abstract class MilocInstruction : Instruction
    {
        public MilocInstruction(string name)
            : base(name)
        {
        }
    }
}
