using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.ILOC
{
    public class StringImmediateRegisterInstruction : Instruction
    {
        public StringImmediateRegisterInstruction(string name, string str, int i, int reg)
            : base(name)
        {
            this.Str = str;
            this.I = i;
            this.Reg = reg;
        }

        public string Str { get; private set; }
        public int I { get; private set; }
        public int Reg { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}, r{3}", Name, Str, I, Reg);
        }
    }
}
