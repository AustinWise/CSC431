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
                if (cur is LoadiInstruction)
                {
                    var load = cur as LoadiInstruction;
                    values[load.RegDest0.IntVal] = load.Immed0;
                    yield return load;
                }
                else if (cur is MovInstruction)
                {
                    var mov = cur as MovInstruction;
                    var val = values.GetMaybeNull(mov.RegSource0.IntVal);
                    if (val.HasValue)
                    {
                        values[mov.RegDest0.IntVal] = val.Value;
                        yield return new LoadiInstruction(val.Value, mov.RegDest0);
                    }
                    else
                    {
                        values.Remove(mov.RegDest0.IntVal);
                        yield return cur;
                    }
                }
                else if (cur is IArithmeticInstruction)
                {
                    var art = cur as IArithmeticInstruction;
                    var val = art.ConstantValue(values.GetMaybeNull(art.RegSource0.IntVal), values.GetMaybeNull(art.RegSource1.IntVal));
                    if (val.HasValue)
                    {
                        yield return new LoadiInstruction(val.Value, art.RegDest0);
                        values[art.RegDest0.IntVal] = val.Value;
                    }
                    else
                    {
                        values.Remove(art.RegDest0.IntVal);
                        yield return cur;
                    }
                }
                else
                {
                    var instr = cur;
                    foreach (var t in instr.DestRegs)
                    {
                        values.Remove(t.IntVal);
                    }
                    yield return instr;
                }
            }
        }
    }
}
