using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.IL;
using CSC431.CFG;

namespace CSC431.Analysis
{
    public class ConstantFoldingConverter : IInstructionConverter<MilocInstruction, MilocInstruction>
    {
        private ConstantFinder finder;

        public ConstantFoldingConverter(ProgramBlock<MilocInstruction> prog)
        {
            finder = new ConstantFinder(prog);
        }

        public IEnumerable<MilocInstruction> FunctionStart(FunctionBlock<MilocInstruction> copy)
        {
            return Enumerable.Empty<MilocInstruction>();
        }

        public IEnumerable<MilocInstruction> Convert(InstructionStream<MilocInstruction> s)
        {
            var values = new Dictionary<int, int>();
            while (s.More)
            {
                var cur = s.Consume();
                var val = finder.GetValue(cur);
                if (val == null)
                    yield return cur;
                else
                    yield return new LoadiInstruction(val.Item2, val.Item1);
            }
        }

        public static ProgramBlock<MilocInstruction> DoOpt(ProgramBlock<MilocInstruction> prog)
        {
            return (ProgramBlock<MilocInstruction>)prog.Convert(new ConstantFoldingConverter(prog));
        }
    }
}
