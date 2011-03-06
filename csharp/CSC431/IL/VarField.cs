using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.IL
{
    class VarField : VarBase
    {
        private string name;
        private int addressReg;
        private int fieldIndex;
        private string containingType;

        public VarField(string name, int addressReg, string containingType, string type, int fieldIndex)
            : base(type)
        {
            this.name = name;
            this.addressReg = addressReg;
            this.fieldIndex = fieldIndex;
            this.containingType = containingType;
        }

        public override BasicBlock<MilocInstruction> Store(int source)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new StoreaiFieldInstruction(source, addressReg, name) { ContainingType = containingType, FieldIndex = fieldIndex, FieldType = this.Type });
            return b;
        }

        public override BasicBlock<MilocInstruction> Load(int target)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new LoadaiFieldInstruction(addressReg, name, target) { ContainingType = containingType, FieldIndex = fieldIndex, FieldType = this.Type });
            b.Reg = target;
            return b;
        }
    }
}
