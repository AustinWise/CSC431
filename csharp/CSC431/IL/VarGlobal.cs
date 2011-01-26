using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.IL
{
    class VarGlobal : VarBase
    {
        private string name;

        public VarGlobal(string name)
        {
            this.name = name;
        }

        public override BasicBlock<MilocInstruction> Store(int source)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new StoreglobalInstruction(source, name));
            return b;
        }

        public override BasicBlock<MilocInstruction> Load(int target)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new LoadglobalInstruction(name, target));
            b.Reg = target;
            return b;
        }
    }
}
