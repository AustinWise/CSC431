using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;
using System.Collections;

namespace CSC431.Sparc
{
    public abstract class SparcInstruction : Instruction
    {
        public SparcInstruction(string name)
            : base(name)
        {
        }

        public abstract IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset);
        public abstract SparcInstruction ConvertRegister(SparcRegister[] map);
    }
}
