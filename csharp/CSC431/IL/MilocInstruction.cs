using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.IL
{
    public abstract class MilocInstruction : Instruction
    {
        public const string ReadGlobalName = "ReadGlobalVarHopefullyNoProgramHasAVarNamedThisBecauseThenThingsWillBeScrewedUp";
        public static readonly TaskLocal<VirtualRegister> IccReg = new TaskLocal<VirtualRegister>(() => new VirtualRegister(VirtRegAlloc.AllocSlow()));

        public MilocInstruction(string name)
            : base(name)
        {
        }

        internal virtual void CopyExtraData(MilocInstruction newInstr)
        {
        }

        public virtual int? ConstantValue(int? x, int? y)
        {
            return null;
        }
    }
}
