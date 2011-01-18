using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Steps
{
    public class InOutStep<In, Out> : Step, IInStep<In>, IOutStep<Out>
    {
        public InOutStep(Func<In, Out> fun)
        {
            this.fun = fun;
        }

        private Func<In, Out> fun;

        public In Input { get; set; }
        public Out Output { get; set; }

        protected override void Process()
        {
            this.Output = fun(Input);
        }

        public F FollowWith<F>(F next) where F : Step, IInStep<Out>
        {
            this.AddNext(next);
            return next;
        }
    }
}
