using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.IL;

namespace CSC431.IL
{
    public class LoopBlock<T> : Node<T> where T : Instruction
    {
        private MultiBlock<T> Condition;
        private SeqBlock<T> Body;
        private Label<T> NextLabel;
        private bool isFixed = false;
        private int condReg;

        public LoopBlock(BasicBlock<T> condition, SeqBlock<T> body, Label<T> nextLabel)
        {
            this.condReg = condition.Reg;

            this.Condition = condition.ToMulti();
            this.Body = body;
            this.NextLabel = nextLabel;

            this.Body.SetNext(condition);

            this.Condition.PrintLabel = true;
            this.Body.PrintLabel = true;
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

            NextLabel.Mark(next);
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
