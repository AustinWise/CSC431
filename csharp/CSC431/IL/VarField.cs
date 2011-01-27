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

        public VarField(string name, int addressReg, string type)
            : base(type)
        {
            this.name = name;
            this.addressReg = addressReg;
        }

        public override BasicBlock<MilocInstruction> Store(int source)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new StoreaiFieldInstruction(source, addressReg, name));
            return b;
        }

        public override BasicBlock<MilocInstruction> Load(int target)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new LoadaiFieldInstruction(addressReg, name, target));
            b.Reg = target;
            return b;
        }
    }
}
