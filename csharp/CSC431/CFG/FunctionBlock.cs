using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class FunctionBlock<T> : Node<T> where T : Instruction
    {
        public string Name { get; private set; }
        public SeqBlock<T> Body { get; private set; }
        public List<string> Locals { get; private set; }

        public FunctionBlock(string name, SeqBlock<T> body)
        {
            this.Name = name;
            this.Body = body;
            this.Locals = new List<string>();
        }

        public override Node<T>[] Nexts
        {
            get { return Body.Nexts; }
        }

        public override void SetNext(Node<T> next)
        {
            throw new NotSupportedException();
        }

        protected override void PrintCore(System.IO.TextWriter tw, Printer<T> printer)
        {
            printer.PrintFunctionHeader(tw, this);
            Body.Print(tw, printer);
            printer.PrintFunctionFooter(tw, this);
        }

        public override Node<T> FirstNode
        {
            get { return Body.FirstNode; }
        }

        public void VistBlocks(Action<Node<T>> fun)
        {
            var seen = new List<Node<T>>();
            var q = new Queue<Node<T>>();
            q.Enqueue(this.FirstNode);
            seen.Add(this.FirstNode);
            while (q.Count != 0)
            {
                var node = q.Dequeue();
                fun(node);
                foreach (var next in node.Nexts)
                {
                    if (!seen.Contains(next))
                    {
                        seen.Add(next);
                        q.Enqueue(next);
                    }
                }
            }
        }

        protected override Node<Target> ConvertCore<Target>(IInstructionConverter<T, Target> conv)
        {
            var copy = new FunctionBlock<Target>(Name, Body.Convert(conv) as SeqBlock<Target>);
            var topBlock = new BasicBlock<Target>();
            topBlock.Add(conv.FunctionStart(copy));
            copy.Body.AddAtTop(topBlock);
            copy.Body.SetNext(new BasicBlock<Target>());
            copy.Locals = new List<string>(Locals);
            return copy;
        }
    }
}
