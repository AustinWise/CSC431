using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.IL
{
    public class MultiBlock : Node
    {
        public MultiBlock()
        {
            this.code = new List<IL.Instruction>();
        }

        public MultiBlock(List<IL.Instruction> code)
        {
            this.code = code;
        }

        private List<CSC431.IL.Instruction> code;
        private List<Node> nexts = new List<Node>();

        public void AddLine(CSC431.IL.Instruction line)
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

        protected override void PrintCore(System.IO.TextWriter tw)
        {
            foreach (var l in this.code)
            {
                tw.WriteLine(l.ToString());
            }
        }
    }
}
