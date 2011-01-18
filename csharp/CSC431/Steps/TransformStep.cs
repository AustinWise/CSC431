using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Steps
{
    public class TransformStep<T> : InOutStep<T, T>
    {
        public TransformStep(Func<T, T> fun)
            : base(fun)
        {
        }
    }
}
