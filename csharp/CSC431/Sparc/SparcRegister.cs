using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.Sparc
{
    public enum SparcReg : int
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
        fp, //i6,
        i7, //returnAddress
        o0,
        o1,
        o2,
        o3,
        o4,
        o5,
        sp, //o6,
        o7, //outReturnAddress
        g0,
        g1,
        g2,
        g3,
        g4,
        g5,
        g6,
        g7
    }
    public class SparcRegister : Register
    {
        //this is so that virtual registers and sparc registers
        //can be placed into a bit array together
        public static readonly int[] IntValueMap;
        static SparcRegister()
        {
            var vals = Enum.GetValues(typeof(SparcReg));
            IntValueMap = new int[vals.Length];
            foreach (var v in vals)
            {
                IntValueMap[(int)v] = Instruction.VirtualRegister();
            }
        }

        /// <summary>
        /// Makes sure virtual register map has been created.
        /// </summary>
        /// <returns></returns>
        public static int EnsureMap()
        {
            return IntValueMap[0];
        }

        private SparcReg val;

        public SparcRegister(SparcReg reg)
        {
            this.val = reg;
        }

        public override int IntVal
        {
            get { return IntValueMap[(int)val]; }
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}
