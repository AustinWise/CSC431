using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.IL
{
    public partial class LoadaiFieldInstruction
    {
        public int FieldIndex { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            (newInstr as LoadaiFieldInstruction).FieldIndex = FieldIndex;
        }
    }
    public partial class StoreaiFieldInstruction
    {
        public int FieldIndex { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            (newInstr as StoreaiFieldInstruction).FieldIndex = FieldIndex;
        }
    }
    public partial class LoadaiVarInstruction
    {
        public int ArgIndex { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            (newInstr as LoadaiVarInstruction).ArgIndex = ArgIndex;
        }
    }
    public partial class StoreaiVarInstruction
    {
        public int ArgIndex { get; set; }

        internal override void CopyExtraData(MilocInstruction newInstr)
        {
            (newInstr as StoreaiVarInstruction).ArgIndex = ArgIndex;
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
}
