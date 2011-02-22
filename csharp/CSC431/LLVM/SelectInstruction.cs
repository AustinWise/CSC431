using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.LLVM
{
    class SelectInstruction : LlvmInstruction
    {
        private VirtualRegister rcond, rd;
        private int trueValue, falseValue;
        public SelectInstruction(int rcond, VirtualRegister rd, int trueValue, int falseValue)
            : base("select")
        {
            this.rcond = rcond;
            this.rd = rd;
            this.trueValue = trueValue;
            this.falseValue = falseValue;
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
            return string.Format("%{0} = select i1 %{3}, i32 {1}, i32 {2}", rd, trueValue, falseValue, rcond);
        }
    }
}
