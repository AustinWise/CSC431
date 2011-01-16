using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.ILOC
{
    public class DoubleRegisterInstruction : Instruction
    {
        public DoubleRegisterInstruction(string name, int rx, int ry)
            : base(name)
        {
            this.Rx = rx;
            this.Ry = ry;
        }

        public int Rx { get; private set; }
        public int Ry { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} r{1}, r{2}", Rx, Ry);
        }
    }
}
