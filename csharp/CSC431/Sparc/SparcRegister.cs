using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.Sparc
{
    public enum SparcReg
    {
        l0,
        l1,
        l2,
        l3,
        l4,
        l5,
        l6,
        l7,
        i0,
        i1,
        i2,
        i3,
        i4,
        i5,
        i6,
        i7,
        o0,
        o1,
        o2,
        o3,
        o4,
        o5,
        o6,
        o7,
        g0,
        g1,
        g2,
        g3,
        g4,
        g5,
        g6,
        g7,

        sp
    }
    public class SparcRegister : Register
    {
        private SparcReg val;

        public SparcRegister(SparcReg reg)
        {
            this.val = reg;
        }

        public override int IntVal
        {
            get { return (int)val; }
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}
