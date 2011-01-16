using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    class MultiBlock : Node
    {
        public MultiBlock()
        {
            this.code = new List<ILOC.Instruction>();
        }

        public MultiBlock(List<ILOC.Instruction> code)
        {
            this.code = code;
        }

        private List<CSC431.ILOC.Instruction> code;
        private List<Node> nexts = new List<Node>();

        public void AddLine(CSC431.ILOC.Instruction line)
        {
            code.Add(line);
        }

        public override Node[] Nexts
        {
            get { return nexts.ToArray(); }
        }

        public override void SetNext(Node next)
        {
            nexts.Add(next);
        }
    }
}
