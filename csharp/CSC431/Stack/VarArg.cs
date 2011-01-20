using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

namespace CSC431.Stack
{
    class VarArg : VarBase
    {
        private int arg;

        public VarArg(Type t, int arg)
            : base(t)
        {
            this.arg = arg;
        }

        public override void Store(ILGenerator il)
        {
            throw new NotSupportedException();
        }

        public override void Load(ILGenerator il)
        {
            il.Emit(OpCodes.Ldarg, arg);
        }
    }
}
