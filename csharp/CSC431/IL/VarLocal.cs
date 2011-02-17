using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.IL
{
    class VarLocal : VarBase
    {
        private string name;

        public VarLocal(string name, string type)
            : base(type)
        {
            this.name = name;
            this.ArgIndex = -1;
        }

        public override BasicBlock<MilocInstruction> Store(int source)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new StoreaiVarInstruction(source, name) { ArgIndex = ArgIndex });
            return b;
        }

        public override BasicBlock<MilocInstruction> Load(int target)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new LoadaiVarInstruction(name, target) { ArgIndex = ArgIndex });
            b.Reg = target;
            return b;
        }

        public int ArgIndex { get; set; }
    }
}
