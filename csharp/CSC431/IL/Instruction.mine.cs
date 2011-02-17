using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.IL
{
    public partial class LoadaiFieldInstruction
    {
        public int FieldIndex { get; set; }
    }
    public partial class StoreaiFieldInstruction
    {
        public int FieldIndex { get; set; }
    }
    public partial class LoadaiVarInstruction
    {
        public int ArgIndex { get; set; }
    }
    public partial class StoreaiVarInstruction
    {
        public int ArgIndex { get; set; }
    }
}
