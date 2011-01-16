using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class ProgramBlock : Node
    {
        public List<FunctionBlock> Functions { get; private set; }

        public ProgramBlock(List<FunctionBlock> funs)
        {
            this.Functions = funs;
        }

        public override Node[] Nexts
        {
            get { return Functions.ToArray(); }
        }

        public override void SetNext(Node next)
        {
            throw new NotSupportedException();
        }

        public override void Print(System.IO.TextWriter tw)
        {
            foreach (var f in Functions)
            {
                tw.WriteLine("@function {0}", f.Name);
            }

            tw.WriteLine();

            foreach (var f in Functions)
            {
                f.Print(tw);
                tw.WriteLine();
            }
        }
    }
}
