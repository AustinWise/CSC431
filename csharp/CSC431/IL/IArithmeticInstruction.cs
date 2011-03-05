using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.IL
{
    public interface IArithmeticInstruction
    {
        VirtualRegister RegSource0 { get; }
        VirtualRegister RegSource1 { get; }
        VirtualRegister RegDest0 { get; }
        int? ConstantValue(int? x, int? y);
    }
}
