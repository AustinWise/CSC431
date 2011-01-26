using System;
using CSC431.CFG;

namespace CSC431.IL
{
    class VarReg : VarBase
    {
        private int reg;

        public VarReg(int reg)
            : base()
        {
            this.reg = reg;
        }

        public override BasicBlock<MilocInstruction> Store(int source)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new MovInstruction(source, this.reg));
            return b;
        }

        public override BasicBlock<MilocInstruction> Load(int target)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new MovInstruction(this.reg, target));
            b.Reg = target;
            return b;
        }
    }
}
