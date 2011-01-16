using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.ILOC
{
    class SingleRegisterInstruction : Instruction
    {
        public SingleRegisterInstruction(string name, int reg)
            : base(name)
        {
            this.Reg = reg;
        }

        public int Reg { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} r{1}", Name, Reg);
        }
    }
}
