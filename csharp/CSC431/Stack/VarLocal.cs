using System.Reflection.Emit;

namespace CSC431.Stack
{
    class VarLocal : VarBase
    {
        private LocalBuilder local;

        public VarLocal(LocalBuilder builder)
            : base(builder.LocalType)
        {
            local = builder;
        }

        public override void Store(ILGenerator il)
        {
            il.Emit(OpCodes.Stloc, local);
        }

        public override void Load(ILGenerator il)
        {
            il.Emit(OpCodes.Ldloc, local);
        }
    }
}
