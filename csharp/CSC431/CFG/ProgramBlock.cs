using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    class ProgramBlock : Node
    {
        public List<FunctionBlock> Functions { get; private set; }

        public ProgramBlock(List<FunctionBlock> funs)
        {
            this.Functions = funs;
        }

        public override Node[] Nexts
        {
            get { return Functions.ToArray(); }
        }

        public override void SetNext(Node next)
        {
            throw new NotSupportedException();
        }
    }
}
