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
        private VirtualRegister rd, r1, r2;
        private string type;

        public IcmpInstruction(ConditionType cond, VirtualRegister rd, VirtualRegister r1, VirtualRegister r2, string type)
            : base("icmp")
        {
            this.cond = cond;
            this.r1 = r1;
            this.r2 = r2;
            this.rd = rd;
            this.type = type;
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
            return string.Format("%{3} = icmp {0} {4} %{1}, %{2}", cond, r1, r2, rd, type != null ? "%" + type + "*" : "i32");
        }
    }
    class IcmpConstInstruction : LlvmInstruction
    {
        private ConditionType cond;
        private VirtualRegister rd, r1;
        private int immed;

        public IcmpConstInstruction(ConditionType cond, VirtualRegister rd, VirtualRegister r1, int immed)
            : base("icmp")
        {
            this.cond = cond;
            this.r1 = r1;
            this.immed = immed;
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
            return string.Format("%{3} = icmp {0} i32 %{1}, {2}", cond, r1, immed, rd);
        }
    }
}
