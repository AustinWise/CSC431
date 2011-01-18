using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431
{
    [Serializable]
    public class EvilException : Exception
    {
        public EvilException() { }
        public EvilException(string message) : base(message) { }
        public EvilException(string message, Exception inner) : base(message, inner) { }
        protected EvilException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
