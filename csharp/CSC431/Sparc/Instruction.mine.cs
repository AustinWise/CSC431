﻿using System;
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

    public partial class SethiInstruction
    {
        public bool IsConstantData { get; set; }

        partial void MyCopyExtraDataToNewInstance(SethiInstruction newObj)
        {
            newObj.IsConstantData = IsConstantData;
        }
    }

    public partial class OrlInstruction
    {
        public bool IsConstantData { get; set; }

        partial void MyCopyExtraDataToNewInstance(OrlInstruction newObj)
        {
            newObj.IsConstantData = IsConstantData;
        }
    }
}
