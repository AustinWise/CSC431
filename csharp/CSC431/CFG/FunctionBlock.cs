using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    class FunctionBlock : Node
    {
        public string Name { get; private set; }
        public SeqBlock Body { get; private set; }

        public FunctionBlock(string name, SeqBlock body)
        {
            this.Name = name;
            this.Body = body;
        }

        public override Node[] Nexts
        {
            get { return new Node[] { Body }; }
        }

        public override void SetNext(Node next)
        {
            throw new NotSupportedException();
        }
    }
}
