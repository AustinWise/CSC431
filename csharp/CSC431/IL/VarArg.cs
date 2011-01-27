using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.IL
{
    class VarArg : VarBase
    {
        private string name;
        private int ndx;
        private int reg = BasicBlock<MilocInstruction>.InvalidReg;

        public VarArg(string name, int ndx, string type)
            : base(type)
        {
            this.name = name;
            this.ndx = ndx;
        }

        public override BasicBlock<MilocInstruction> Store(int source)
        {
            if (reg == BasicBlock<MilocInstruction>.InvalidReg)
                reg = Instruction.VirtualRegister();
            var b = new BasicBlock<MilocInstruction>();
            b.Add(new MovInstruction(source, reg));
            return b;
        }

        public override BasicBlock<MilocInstruction> Load(int target)
        {
            var b = new BasicBlock<MilocInstruction>();
            if (reg == BasicBlock<MilocInstruction>.InvalidReg)
                b.Add(new LoadinargumentInstruction(name, ndx, target));
            else
                b.Add(new MovInstruction(reg, target));
            b.Reg = target;
            return b;
        }
    }
}
