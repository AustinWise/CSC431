using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Steps
{
    public interface IOutStep<T> : IStep
    {
        T Output { get; set; }
        void FollowWith(InStep<T> next);
        IOutStep<Out> FollowWith<Out>(InOutStep<T, Out> next);
    }
}
