using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSC431.CFG
{
    public class Instruction
    {
        private static int VirtualRegisterCounter = 0;
        public static int VirtualRegister()
        {
            return Interlocked.Increment(ref VirtualRegisterCounter);
        }

        public Instruction(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public bool CcSet { get; protected set; }
    }
}
