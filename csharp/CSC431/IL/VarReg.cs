using System;
using CSC431.CFG;

namespace CSC431.IL
{
    class VarReg : VarBase
    {
        private int reg;

        public VarReg(int reg, string type)
            : base(type)
        {
            this.reg = reg;
            this.ArgIndex = -1;
        }

        public override BasicBlock<MilocInstruction> Store(int source)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new MovInstruction(source, this.reg) { ArgIndex = ArgIndex, ArgReg = reg });
            return b;
        }

        public override BasicBlock<MilocInstruction> Load(int target)
        {
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new MovInstruction(this.reg, target) { ArgIndex = ArgIndex, ArgReg = reg });
            b.Reg = target;
            return b;
        }

        public int ArgIndex { get; set; }
    }
}
