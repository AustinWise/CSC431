using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431
{
    public enum EvilSystem
    {
        Parsing,
        Typecheck,
        Clr,
        Il,
        Options,
        Llvm,
    }

    [Serializable]
    public class EvilException : Exception
    {
        public EvilException(EvilSystem system, string message)
            : base(message)
        {
            System = system;
        }

        public EvilException(EvilSystem system, string message, Exception innerException)
            : base(message, innerException)
        {
            System = system;
        }

        protected EvilException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        public EvilSystem System { get; private set; }
    }
}
