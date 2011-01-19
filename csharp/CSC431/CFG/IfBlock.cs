using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.CFG
{
    public class IfBlock<T> : Node<T> where T : Instruction
    {
        private MultiBlock<T> Condition;
        private SeqBlock<T> TrueBody;
        private SeqBlock<T> FalseBody;
        private Label<T> NextLabel;
        private bool isFixed = false;

        public IfBlock(BasicBlock<T> condition, SeqBlock<T> trueBody, SeqBlock<T> falseBody, Label<T> nextLabel)
        {
            this.Condition = condition.ToMulti();
            this.Condition.SetNext(trueBody);
            this.Condition.SetNext(falseBody);
            this.TrueBody = trueBody;
            this.FalseBody = falseBody;
            this.NextLabel = nextLabel;
        }

        public override Node<T>[] Nexts
        {
            get { return new Node<T>[] { Condition }; }
        }

        public override void SetNext(Node<T> next)
        {
            if (isFixed)
                throw new Exception("next was already set");
            isFixed = true;

            TrueBody.SetNext(next);
            FalseBody.SetNext(next);
            NextLabel.Mark(next);

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
