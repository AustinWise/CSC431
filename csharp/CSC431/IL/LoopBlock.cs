using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.IL;

namespace CSC431.IL
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

            this.Body.Add(new JumpiInstruction(this.Condition.Label));
            this.Body.SetNext(condition);

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

            int reg = Instruction.VirtualRegister();
            this.Condition.AddLine(new LoadiInstruction(1, reg));
            this.Condition.AddLine(new CompInstruction(condReg, reg));
            this.Condition.AddLine(new CbreqInstruction(Body.Label, next.Label));

            Condition.SetNext(next);

            next.PrintLabel = true;

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
