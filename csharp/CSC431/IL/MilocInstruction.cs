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

        public MilocInstruction(string name)
            : base(name)
        {
        }
    }
}
