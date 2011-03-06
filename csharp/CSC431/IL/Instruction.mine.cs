using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.IL
{
    public partial class StoreglobalInstruction
    {
        public bool IsNull { get; set; }
        public string Type { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as StoreglobalInstruction;
            other.IsNull = IsNull;
            other.Type = Type;
        }
    }
    public partial class LoadglobalInstruction
    {
        public string Type { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as LoadglobalInstruction;
            other.Type = Type;
        }
    }
    public partial class LoadaiFieldInstruction
    {
        public int FieldIndex { get; set; }
        public string FieldType { get; set; }
        public string ContainingType { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as LoadaiFieldInstruction;
            other.FieldIndex = FieldIndex;
            other.FieldType = FieldType;
            other.ContainingType = ContainingType;
        }
    }
    public partial class StoreaiFieldInstruction
    {
        public int FieldIndex { get; set; }
        public string FieldType { get; set; }
        public string ContainingType { get; set; }
        public bool IsNull { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as StoreaiFieldInstruction;
            other.FieldIndex = FieldIndex;
            other.FieldType = FieldType;
            other.ContainingType = ContainingType;
            other.IsNull = IsNull;
        }
    }
    public partial class LoadaiVarInstruction
    {
        public int ArgIndex { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as LoadaiVarInstruction;
            other.ArgIndex = ArgIndex;
        }
    }
    public partial class StoreaiVarInstruction
    {
        public int ArgIndex { get; set; }
        public bool IsNull { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as StoreaiVarInstruction;
            other.ArgIndex = ArgIndex;
            other.IsNull = IsNull;
        }
    }
    public partial class MovInstruction
    {
        public int ArgIndex { get; set; }
        public int ArgReg { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as MovInstruction;
            other.ArgIndex = ArgIndex;
            other.ArgReg = ArgReg;
        }
    }
    public partial class DelInstruction : ITyped
    {
        public string StructType { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as DelInstruction;
            other.StructType = StructType;
        }

        public FrontEnd.Type TargetType { get { return null; } }
        public FrontEnd.Type Source0Type { get { return FrontEnd.Type.structType(StructType); } }
        public FrontEnd.Type Source1Type { get { return null; } }
    }
    public partial class LoadiInstruction : ITyped
    {
        public bool IsNull { get; set; }
        public string Type { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as LoadiInstruction;
            other.IsNull = IsNull;
            other.Type = Type;
        }

        public FrontEnd.Type TargetType { get { return IsNull ? null : FrontEnd.Type.intType(); } }
        public FrontEnd.Type Source0Type { get { return null; } }
        public FrontEnd.Type Source1Type { get { return null; } }
    }
    public partial class CompInstruction : ITyped
    {
        public string StructType1 { get; set; }
        public string StructType2 { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as CompInstruction;
            other.StructType1 = StructType1;
            other.StructType2 = StructType2;
        }

        public FrontEnd.Type TargetType { get { return null; } }
        public FrontEnd.Type Source0Type { get { return StructType1 == null ? null : FrontEnd.Type.structType(StructType1); } }
        public FrontEnd.Type Source1Type { get { return StructType2 == null ? null : FrontEnd.Type.structType(StructType2); } }
    }

    public partial class StoreretInstruction : ITyped
    {
        public string CurrentFunction { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as StoreretInstruction;
            other.CurrentFunction = CurrentFunction;
        }

        public FrontEnd.Type TargetType { get { return null; } }
        public FrontEnd.Type Source0Type { get { return Program.Stable.Value.getType(CurrentFunction).getReturnType(); } }
        public FrontEnd.Type Source1Type { get { return null; } }
    }

    public partial class StoreoutargumentInstruction : ITyped
    {
        public FrontEnd.Type Type { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            var other = newInstr as StoreoutargumentInstruction;
            other.Type = Type;
        }

        public FrontEnd.Type TargetType { get { return null; } }
        public FrontEnd.Type Source0Type { get { return Type; } }
        public FrontEnd.Type Source1Type { get { return null; } }
    }
}
