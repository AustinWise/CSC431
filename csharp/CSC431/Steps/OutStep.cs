using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Steps
{
    class OutStep<T> : Step, IOutStep<T>
    {
        public OutStep(Func<T> fun)
        {
            this.fun = fun;
        }

        private Func<T> fun;

        public T Output { get; set; }

        protected override void Process()
        {
            this.Output = fun();
        }

        public F FollowWith<F>(F next) where F : class, IInStep<T>
        {
            AddNext(next as Step);
            return next;
        }
    }
}
