using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.LLVM
{
    enum ConditionType
    {
        eq,
        ne,
        sgt,
        sge,
        slt,
        sle
    }
    class IcmpInstruction : LlvmInstruction
    {
        private ConditionType cond;
        private int rd, r1, r2;

        public IcmpInstruction(ConditionType cond, int rd, int r1, int r2)
            : base("icmp")
        {
            this.cond = cond;
            this.r1 = r1;
            this.r2 = r2;
            this.rd = rd;
        }

        public override int[] SourceRegs
        {
            get { throw new NotImplementedException(); }
        }

        public override int[] DestRegs
        {
            get { throw new NotImplementedException(); }
        }

        public override string ToString()
        {
            return string.Format("%r{3} = icmp {0} i32 {1}, {2}", cond, r1, r2, rd);
        }
    }
}
