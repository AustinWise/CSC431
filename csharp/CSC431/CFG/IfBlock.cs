using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.CFG
{
    public class IfBlock<T> : Node<T> where T : Instruction
    {
        private BasicBlock<T> Condition;
        private SeqBlock<T> TrueBody;
        private SeqBlock<T> FalseBody;
        private Label NextLabel;
        private bool isFixed = false;

        public IfBlock(BasicBlock<T> condition, SeqBlock<T> trueBody, SeqBlock<T> falseBody, Label nextLabel)
        {
            this.Condition = condition;
            this.Condition.SetNext(trueBody.FirstNode);
            this.Condition.SetNext(falseBody.FirstNode);
            this.TrueBody = trueBody;
            this.FalseBody = falseBody;
            this.NextLabel = nextLabel;
            this.IsReturn = TrueBody.IsReturn & FalseBody.IsReturn;
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

            TrueBody.SetNext(next.FirstNode);
            FalseBody.SetNext(next.FirstNode);
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

        protected override void PrintCore(System.IO.TextWriter tw, Printer<T> printer)
        {
            TrueBody.PrintLabel = true;
            FalseBody.PrintLabel = true;

            Condition.Print(tw, printer);
            TrueBody.Print(tw, printer);
            FalseBody.Print(tw, printer);
        }

        public override Node<T> FirstNode
        {
            get { return Condition; }
        }

        protected override Node<Target> ConvertCore<Target>(IInstructionConverter<T, Target> conv)
        {
            return new IfBlock<Target>(Condition.Convert(conv) as BasicBlock<Target>, TrueBody.Convert(conv) as SeqBlock<Target>, FalseBody.Convert(conv) as SeqBlock<Target>, new Label());
        }
    }
}
