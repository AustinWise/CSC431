using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public interface IInstructionConverter<Source, Target>
        where Source : Instruction
        where Target : Instruction
    {
        /// <summary>
        /// Returns instructions that should be inserted at the top of new function.
        /// </summary>
        /// <param name="copy">A copy of the old block with all the old data copied, except for Body.</param>
        /// <returns></returns>
        IEnumerable<Target> FunctionStart(FunctionBlock<Target> copy);
        IEnumerable<Target> Convert(InstructionStream<Source> s);
    }
}
