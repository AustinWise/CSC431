using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.ILOC;

namespace CSC431.CFG
{
    public class IfBlock : Node
    {
        private MultiBlock Condition;
        private SeqBlock TrueBody;
        private SeqBlock FalseBody;
        private bool isFixed = false;

        public IfBlock(BasicBlock condition, SeqBlock trueBody, SeqBlock falseBody)
        {
            this.Condition = condition.ToMulti();
            this.Condition.SetNext(trueBody);
            this.Condition.SetNext(falseBody);
            this.TrueBody = trueBody;
            this.FalseBody = falseBody;

            int reg = Instruction.VirtualRegister();
            this.Condition.AddLine(new LoadiInstruction(reg, 1));
            this.Condition.AddLine(new CompInstruction(condition.Reg, reg));
            this.Condition.AddLine(new CbreqInstruction(TrueBody.Label, FalseBody.Label));
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
            TrueBody.Add(new JumpiInstruction(next.Label));
            TrueBody.SetNext(next);
            FalseBody.SetNext(next);

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
            TrueBody.PrintLabel = true;
            FalseBody.PrintLabel = true;

            Condition.Print(tw);
            TrueBody.Print(tw);
            FalseBody.Print(tw);
        }
    }
}
