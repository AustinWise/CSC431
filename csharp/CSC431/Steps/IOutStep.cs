using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Steps
{
    public interface IOutStep<T>
    {
        T Output { get; set; }
        F FollowWith<F>(F next) where F : Step, IInStep<T>;
    }
}
