using System.Reflection.Emit;
using System;

namespace CSC431.Stack
{
    abstract class VarBase
    {
        public VarBase(Type t)
        {
            this.VarType = t;
        }

        /// <summary>
        /// Pops one item off the stack, storing it.
        /// </summary>
        /// <param name="il"></param>
        public abstract void Store(ILGenerator il);

        /// <summary>
        /// Pushes one item onto the stack.
        /// </summary>
        /// <param name="il"></param>
        public abstract void Load(ILGenerator il);

        public Type VarType { get; private set; }
    }
}
