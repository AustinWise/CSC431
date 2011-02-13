using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.CFG
{
    public class LoopBlock<T> : Node<T> where T : Instruction
    {
        private BasicBlock<T> Condition;
        private SeqBlock<T> Body;
        private Label<T> NextLabel;
        private bool isFixed = false;
        private int condReg;

        public LoopBlock(BasicBlock<T> condition, SeqBlock<T> body, Label<T> nextLabel)
        {
            this.condReg = condition.Reg;

            this.Condition = condition;
            this.Body = body;
            this.NextLabel = nextLabel;

            this.Body.SetNext(this.Condition.FirstNode);
            this.Condition.SetNext(this.Body.FirstNode);

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

            NextLabel.Mark(next.FirstNode);
            Condition.SetNext(next.FirstNode);

            next.PrintLabel = true;
        }

        public override bool IsFixedUp
        {
            get
            {
                return isFixed && Nexts.Length == 1;
            }
        }

        protected override void PrintCore(System.IO.TextWriter tw, Printer<T> printer)
        {
            Condition.PrintLabel = true;
            Body.PrintLabel = true;

            Condition.Print(tw, printer);
            Body.Print(tw, printer);
        }

        public override Node<T> FirstNode
        {
            get { return Condition; }
        }

        protected override Node<Target> ConvertCore<Target>(IInstructionConverter<T, Target> conv)
        {
            return new LoopBlock<Target>(Condition.Convert(conv) as BasicBlock<Target>, Body.Convert(conv) as SeqBlock<Target>, new Label<Target>());
        }
    }
}
