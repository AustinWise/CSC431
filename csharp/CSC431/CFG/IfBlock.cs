﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    class IfBlock : Node
    {
        private MultiBlock condition;
        private SeqBlock trueBody;
        private SeqBlock falseBody;
        private bool isFixed = false;

        public IfBlock(BasicBlock condition, SeqBlock trueBody, SeqBlock falseBody)
        {
            //TODO: need to add jump instrs
            this.condition = condition.ToMulti();
            this.trueBody = trueBody;
            this.falseBody = falseBody;
            this.condition.SetNext(trueBody);
            this.condition.SetNext(falseBody);
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
            trueBody.SetNext(next);
            falseBody.SetNext(next);
        }

        public override bool IsFixedUp
        {
            get
            {
                return isFixed;
            }
        }
    }
}
