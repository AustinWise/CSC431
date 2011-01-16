using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class LoopBlock : Node
    {
        private MultiBlock condition;
        private SeqBlock body;
        private bool isFixed = false;

        public LoopBlock(BasicBlock condition, SeqBlock body)
        {
            //TODO: add jump instructions
            this.condition = condition.ToMulti();
            this.body = body;
            this.body.SetNext(condition);
        }

        public override Node[] Nexts
        {
            get { return new Node[] { condition }; }
        }

        public override void SetNext(Node next)
        {
            if (isFixed)
                throw new Exception("next was already set");
            isFixed = true;
            condition.SetNext(next);
        }

        public override bool IsFixedUp
        {
            get
            {
                return isFixed;
            }
        }

        public override void Print(System.IO.TextWriter tw)
        {
            tw.WriteLine("L{0}:", condition.Label);
            condition.Print(tw);
            tw.WriteLine("L{0}:", body.Label);

            if (Nexts.Length != 1)
                throw new Exception("wut");

            tw.WriteLine("L{0}:", Nexts[0].Label);
        }
    }
}
