using System;

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
