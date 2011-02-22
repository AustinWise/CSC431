using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.LLVM
{
    class LlvmRegister : CFG.Register
    {
        private string val;

        public LlvmRegister(string val)
        {
            this.val = val;
        }

        public override int IntVal
        {
            get { throw new NotSupportedException(); }
        }

        public override string ToString()
        {
            return val;
        }
    }
}
