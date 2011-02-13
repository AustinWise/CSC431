using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

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
        private Register rd, r1, r2;

        public IcmpInstruction(ConditionType cond, Register rd, Register r1, Register r2)
            : base("icmp")
        {
            this.cond = cond;
            this.r1 = r1;
            this.r2 = r2;
            this.rd = rd;
        }

        public override Register[] SourceRegs
        {
            get { throw new NotImplementedException(); }
        }

        public override Register[] DestRegs
        {
            get { throw new NotImplementedException(); }
        }

        public override string ToString()
        {
            return string.Format("%r{3} = icmp {0} i32 {1}, {2}", cond, r1, r2, rd);
        }
    }
}
