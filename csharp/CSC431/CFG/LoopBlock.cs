using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.ILOC;

namespace CSC431.CFG
{
    public class LoopBlock : Node
    {
        private MultiBlock Condition;
        private SeqBlock Body;
        private bool isFixed = false;
        private int condReg;

        public LoopBlock(BasicBlock condition, SeqBlock body)
        {
            this.condReg = condition.Reg;

            this.Condition = condition.ToMulti();
            this.Body = body;
            this.Body.SetNext(condition);

            body.Add(new JumpiInstruction(this.Condition.Label));

            this.Condition.PrintLabel = true;
            this.Body.PrintLabel = true;
        }

        public override Node[] Nexts
        {
            get { return new Node[] { Condition }; }
        }

        public override void SetNext(Node next)
        {
            if (isFixed)
                throw new Exception("next was already set");
            isFixed = true;
            Condition.SetNext(next);

            next.PrintLabel = true;

            int reg = Instruction.VirtualRegister();
            this.Condition.AddLine(new LoadiInstruction(reg, 1));
            this.Condition.AddLine(new CompInstruction(condReg, reg));
            this.Condition.AddLine(new CbreqInstruction(Body.Label, next.Label));
        }

        public override bool IsFixedUp
        {
            get
            {
                return isFixed && Nexts.Length == 1;
            }
        }

        protected override void PrintCore(System.IO.TextWriter tw)
        {
            Condition.PrintLabel = true;
            Body.PrintLabel = true;

            Condition.Print(tw);
            Body.Print(tw);
        }
    }
}
