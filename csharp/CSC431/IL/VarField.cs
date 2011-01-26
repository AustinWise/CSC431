using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.IL
{
    class VarField : VarBase
    {
        public override BasicBlock<MilocInstruction> Store(int source)
        {
            throw new NotImplementedException();
        }

        public override BasicBlock<MilocInstruction> Load(int target)
        {
            throw new NotImplementedException();
        }
    }
}
