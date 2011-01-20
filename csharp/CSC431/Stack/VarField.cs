using System.Reflection;
using System.Reflection.Emit;
using System;

namespace CSC431.Stack
{
    class VarField : VarBase
    {
        private FieldInfo field;

        public VarField(FieldInfo field)
            : base(field.FieldType)
        {
            this.field = field;
        }

        public override void Store(ILGenerator il)
        {
            if (field.IsStatic)
                il.Emit(OpCodes.Stsfld, field);
            else
                il.Emit(OpCodes.Stfld, field);
        }

        public override void Load(ILGenerator il)
        {
            if (field.IsStatic)
                il.Emit(OpCodes.Ldsfld, field);
            else
                il.Emit(OpCodes.Ldfld, field);
        }
    }
}
