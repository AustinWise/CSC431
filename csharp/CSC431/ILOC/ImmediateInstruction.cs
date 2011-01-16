using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.ILOC
{
    public class ImmediateInstruction : Instruction
    {
        public ImmediateInstruction(string name, int reg, int val)
            : base(name)
        {
            this.Reg = reg;
            this.Value = val;
        }

        public int Reg { get; private set; }
        public int Value { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {2}, r{1}", Name, Reg, Value);
        }
    }
}
