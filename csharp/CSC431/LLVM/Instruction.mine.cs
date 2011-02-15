using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.LLVM
{
    public partial class LoadiInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("%{0} = add i32 {1}, 0", RegDest0, Immed0);
        }
    }
    public partial class RetvalueInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("ret i32 %{0}", RegSource0);
        }
    }
    public partial class RetvoidInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = "ret void";
        }
    }
}
