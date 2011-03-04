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

        protected void DoDataflow(ProgramBlock<T> prog)
        {
            foreach (var f in prog.Functions)
            {
                f.VisitBlocks(b =>
                {
                    CalculateLocal(f, b);
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
