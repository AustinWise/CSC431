using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.LLVM
{
    class SelectInstruction : LlvmInstruction
    {
        private int rcond, rd, trueValue, falseValue;
        public SelectInstruction(int rcond, int rd, int trueValue, int falseValue)
            : base("select")
        {
            this.rcond = rcond;
            this.rd = rd;
            this.trueValue = trueValue;
            this.falseValue = falseValue;
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
            return string.Format("%r{0} = select i1 {3}, i32 {1}, i32 {2}", rd, trueValue, falseValue, rcond);
        }
    }
}
