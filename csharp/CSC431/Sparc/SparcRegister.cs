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
        //Const versions of the registers to cut down on object creation
        public static readonly SparcRegister SP = new SparcRegister(SparcReg.sp);
        public static readonly SparcRegister FP = new SparcRegister(SparcReg.fp);

        //this is so that virtual registers and sparc registers
        //can be placed into a bit array together
        public static readonly TaskLocal<int[]> IntValueMap;
        static SparcRegister()
        {
            IntValueMap = new TaskLocal<int[]>(() =>
            {
                var vals = Enum.GetValues(typeof(SparcReg));
                var ret = new int[vals.Length];
                var ra = VirtRegAlloc.Instance;
                foreach (var v in vals)
                {
                    ret[(int)v] = ra.Alloc();
                }
                return ret;
            });
        }

        /// <summary>
        /// Makes sure virtual register map has been created.
        /// </summary>
        /// <returns></returns>
        public static int EnsureMap()
        {
            return IntValueMap.Value[0];
        }

        private SparcReg val;

        public SparcRegister(SparcReg reg)
        {
            this.val = reg;
        }

        public override int IntVal
        {
            get { return IntValueMap.Value[(int)val]; }
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}
