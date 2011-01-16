using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.ILOC
{
    class NoArgInstruction : Instruction
    {
        public NoArgInstruction(string name)
            : base(name)
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
