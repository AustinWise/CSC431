using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.Analysis
{
    public abstract class IterativeDataflow<T> where T : Instruction
    {
        protected abstract void CalculateLocal(FunctionBlock<T> fun, BasicBlock<T> block);
        protected abstract bool Propagate(FunctionBlock<T> fun, BasicBlock<T> block);
        protected virtual bool CanSkip(FunctionBlock<T> fun)
        {
            return false;
        }


        private Dictionary<BasicBlock<T>, List<BasicBlock<T>>> preds = new Dictionary<BasicBlock<T>, List<BasicBlock<T>>>();
        private void addPred(BasicBlock<T> cur, BasicBlock<T> next)
        {
            if (!preds.ContainsKey(next))
                preds.Add(next, new List<BasicBlock<T>>());
            var list = preds[next];
            list.Add(cur);
        }
        protected List<BasicBlock<T>> GetPredecessors(BasicBlock<T> b)
        {
            return preds[b];
        }

        protected void DoDataflow(ProgramBlock<T> prog)
        {
            foreach (var f in prog.Functions)
            {
                if (CanSkip(f))
                    continue;

                f.VisitBlocks(b =>
                {
                    CalculateLocal(f, b);
                    foreach (var n in b.Nexts)
                    {
                        addPred(b, (BasicBlock<T>)n);
                    }
                    if (!preds.ContainsKey(b))
                        preds.Add(b, new List<BasicBlock<T>>());
                });
                bool moreWorkNeeded;
                do
                {
                    moreWorkNeeded = false;
                    f.VisitBlocks(b =>
                    {
                        moreWorkNeeded |= Propagate(f, b);
                    });
                } while (moreWorkNeeded);
            }
        }
    }
}
