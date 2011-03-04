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


        public void VisitBlocks(Action<BasicBlock<T>> fun)
        {
            VisitBlocks(fun, true);
        }

        public void VisitBlocks(Action<BasicBlock<T>> fun, bool topToBottom)
        {
            var seen = new List<Node<T>>();
            var q = new Queue<Node<T>>();
            q.Enqueue(this.FirstNode);
            seen.Add(this.FirstNode);
            while (q.Count != 0)
            {
                var node = q.Dequeue();
                if (topToBottom)
                    fun(node as BasicBlock<T>);
                foreach (var next in node.Nexts)
                {
                    if (!seen.Contains(next))
                    {
                        seen.Add(next);
                        q.Enqueue(next);
                    }
                }
            }

            if (!topToBottom)
            {
                for (int i = seen.Count - 1; i >= 0; i--)
                {
                    fun((BasicBlock<T>)seen[i]);
                }
            }
        }

        protected override Node<Target> ConvertCore<Target>(IInstructionConverter<T, Target> conv)
        {
            var copy = new FunctionBlock<Target>(Name, null);

            //copy data
            copy.Locals = new List<string>(Locals);

            //bonus propegation
            copy.FunctionsCalled = this.FunctionsCalled;
            copy.MaxOutArgs = this.MaxOutArgs;

            var topBlock = new BasicBlock<Target>();
            topBlock.Add(conv.FunctionStart(copy));
            copy.Body = Body.Convert(conv) as SeqBlock<Target>;
            copy.Body.AddAtTop(topBlock);
            copy.Body.SetNext(new BasicBlock<Target>());

            return copy;
        }

        public int GetLocalIndex(string name)
        {
            int ndx = Locals.IndexOf(name);
            if (ndx == -1)
            {
                Locals.Add(name);
                ndx = Locals.Count - 1;
            }
            return ndx;
        }

        public int AllocateLocal()
        {
            string name = "<Spill>" + Guid.NewGuid();
            Locals.Add(name);
            return Locals.Count - 1;
        }

        //~~BONUS INFO~~ (not here by default, need to use an analysis step to populate, not copied)
        //Should be fine to propegate through converts.
        public List<string> FunctionsCalled { get; set; }
        public int MaxOutArgs { get; set; }
    }
}
