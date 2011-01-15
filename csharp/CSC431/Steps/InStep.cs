using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Steps
{
    class InStep<T> : Step, IInStep<T>
    {
        public InStep(Action<T> fun)
        {
            this.fun = fun;
        }

        private Action<T> fun;

        public T Input { get; set; }

        protected override void Process()
        {
            fun(Input);
        }
    }
}
