using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.IL
{
    public interface ITyped
    {
        FrontEnd.Type TargetType { get; }
        FrontEnd.Type Source0Type { get; }
        FrontEnd.Type Source1Type { get; }
    }
}
