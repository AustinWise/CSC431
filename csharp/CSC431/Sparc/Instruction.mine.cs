using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Sparc
{
    public partial class StwInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("{3} %{0}, [%{1} + {2}]", RegSource0, RegSource1, Immed0, Name);
        }
    }

    public partial class LdswInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("{3} [%{0} + {1}], %{2}", RegSource0, Immed0, RegDest0, Name);
        }
    }

    public partial class SethistrInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("{0} %hi({1}), %{2}", Name, Str0, RegDest0);
        }
    }

    public partial class OrlstrInstruction
    {
        partial void ToStringCore(ref string ret)
        {
            ret = string.Format("{0} %{1}, %lo({2}), %{3}", Name, RegSource0, Str0, RegDest0);
        }
    }

    public partial class SaveInstruction
    {
        private int spSize = 0;

        public void SetStackSizes(CSC431.CFG.FunctionBlock<SparcInstruction> f)
        {
            spSize = 92;

            if (f.MaxOutArgs > 6)
            {
                spSize += (f.MaxOutArgs - 6) * 4;
            }

            spSize += f.Locals.Count * 4;

            //doubleword align
            if (0 != (spSize & 0x7))
            {
                spSize >>= 3;
                spSize++;
                spSize <<= 3;
            }
        }

        partial void ToStringCore(ref string ret)
        {
            if (spSize == 0)
                throw new Exception("stack size not set");
            ret = string.Format("save %sp, -{0}, %sp", spSize);
        }
    }
}
