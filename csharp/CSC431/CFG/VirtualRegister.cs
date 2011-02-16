using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class VirtualRegister : Register
    {
        private int intVal;

        public VirtualRegister(int val)
        {
            this.intVal = val;
        }

        public override int IntVal
        {
            get { return this.intVal; }
        }

        public override string ToString()
        {
            return string.Format("r{0}", intVal);
        }
    }
}
