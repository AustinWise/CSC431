using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Steps
{
    public interface IInStep<T>
    {
        T Input { get; set; }
    }
}
