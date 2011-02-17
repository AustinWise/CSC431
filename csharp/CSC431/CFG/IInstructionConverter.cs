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
        IEnumerable<Target> FunctionStart(FunctionBlock<Source> block);
        IEnumerable<Target> Convert(InstructionStream<Source> s);
    }
}
