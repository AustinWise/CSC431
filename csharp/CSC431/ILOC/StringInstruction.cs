using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.ILOC
{
    public class StringInstruction : Instruction
    {
        public StringInstruction(string name, string str)
            : base(name)
        {
            this.Str = str;
        }

        public string Str { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Str);
        }
    }
}
