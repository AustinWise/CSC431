using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public abstract class Register
    {
        public abstract int IntVal { get; }

        public override bool Equals(object obj)
        {
            var other = obj as Register;
            if (other == null)
                return false;
            return this.IntVal == other.IntVal;
        }

        public override int GetHashCode()
        {
            return IntVal;
        }
    }
}
