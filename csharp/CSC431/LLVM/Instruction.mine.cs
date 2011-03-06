using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.LLVM
{
    public partial class LoadiInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("%{0} = add i32 {1}, 0", RegDest0, Immed0);
        }
    }
    public partial class RetvalueInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("ret i32 %{0}", RegSource0);
        }
    }
    public partial class BrcondInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("br i1 %{0}, label %L{1}, label %L{2}", this.RegSource0, this.Label0, this.Label1);
        }
    }
    public partial class BrInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("br label %L{0}", this.Label0);
        }
    }
    public partial class RetvoidInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = "ret void";
        }
    }
    public partial class LoadInstruction
    {
        public bool IsGlobal { get; set; }
        public FrontEnd.Type Type;

        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("%{0} = load {3}* {2}{1}", RegDest0, RegSource0, IsGlobal ? "@" : "%", Type.isStruct() ? "%" + Type.getStructType() + "*" : "i32");
        }
    }
    public partial class StoreInstruction
    {
        public bool IsGlobal { get; set; }
        public bool IsNull { get; set; }
        public FrontEnd.Type Type;

        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("store {3} {0}, {3}* {2}{1}", IsNull ? "null" : "%" + RegSource0.ToString(), RegSource1, IsGlobal ? "@" : "%", Type.isStruct() ? "%" + Type.getStructType() + "*" : "i32");
        }
    }
    public class StringInstruction : LlvmInstruction
    {
        private string val;

        public StringInstruction(string val, params object[] args)
            : base("string instr")
        {
            this.val = string.Format(val, args);
        }

        public override CFG.Register[] SourceRegs
        {
            get { throw new NotImplementedException(); }
        }

        public override CFG.Register[] DestRegs
        {
            get { throw new NotImplementedException(); }
        }

        public override string ToString()
        {
            return val;
        }
    }
}
