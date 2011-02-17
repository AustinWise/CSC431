using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class InstructionStream<T> where T : Instruction
    {
        private List<T> code;
        private int index = 0;

        public InstructionStream(List<T> code)
        {
            this.code = code;
        }

        /// <summary>
        /// Looks ahead in the token stream.
        /// </summary>
        /// <param name="n">The number of tokens beyond the current to look at.  Must be more than 0.</param>
        /// <returns>Null if there are no tokens that far out, an instruction otherwise.</returns>
        public T LA(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException();

            if (index + n >= code.Count)
            {
                return null;
            }
            return code[index + n];
        }

        public T Current
        {
            get
            {
                return code[index];
            }
        }

        public T Consume()
        {
            return code[this.index++];
        }

        public bool More
        {
            get { return index < code.Count; }
        }
        
    }
}
