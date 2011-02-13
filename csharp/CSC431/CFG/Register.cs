﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public abstract class Register
    {
        public abstract int IntVal { get; }

        public static implicit operator Register(int reg)
        {
            return new VirtualRegister(reg);
        }
    }
}