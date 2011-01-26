using System.Reflection.Emit;
using System;
using CSC431.CFG;

namespace CSC431.IL
{
    abstract class VarBase
    {
        public VarBase()
        {
        }

        /// <summary>
        /// Pops one item off the stack, storing it.
        /// </summary>
        /// <param name="il"></param>
        public abstract BasicBlock<MilocInstruction> Store(int source);

        /// <summary>
        /// Pushes one item onto the stack.
        /// </summary>
        /// <param name="il"></param>
        public abstract BasicBlock<MilocInstruction> Load(int target);
    }
}
