﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSC431.CFG
{
    public abstract class Instruction
    {
        public Instruction(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public bool CcSet { get; protected set; }
        public abstract Register[] SourceRegs { get; }
        public abstract Register[] DestRegs { get; }
        public abstract bool IsCritical { get; }

        /// <summary>
        /// Not propagated between clones.
        /// </summary>
        public bool Mark { get; set; }
    }
}
