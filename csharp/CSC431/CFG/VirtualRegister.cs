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

        public static implicit operator VirtualRegister(int reg)
        {
            return new VirtualRegister(reg);
        }

        public static bool operator ==(VirtualRegister a, VirtualRegister b)
        {
            return a.intVal == b.intVal;
        }

        public static bool operator !=(VirtualRegister a, VirtualRegister b)
        {
            return a.intVal != b.intVal;
        }

        public override bool Equals(object obj)
        {
            var other = obj as VirtualRegister;
            if (other == null)
                return false;
            return this.intVal == other.intVal;
        }

        public override int GetHashCode()
        {
            return intVal;
        }
    }
}
