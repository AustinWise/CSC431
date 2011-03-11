using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.IL;
using CSC431.CFG;

namespace CSC431.Analysis
{
    public class ConstantFinder : IterativeDataflow<MilocInstruction>
    {
        private Dictionary<MilocInstruction, Tuple<VirtualRegister, int>> instrValues;
        private ReachingDef<MilocInstruction> defs;

        public ConstantFinder(ProgramBlock<MilocInstruction> prog)
        {
            instrValues = new Dictionary<MilocInstruction, Tuple<VirtualRegister, int>>();
            defs = new ReachingDef<MilocInstruction>(prog);
            this.DoDataflow(prog);
        }

        protected override void CalculateLocal(CFG.FunctionBlock<MilocInstruction> fun, CFG.BasicBlock<MilocInstruction> block)
        {
            var values = new Dictionary<int, int>();
            foreach (var cur in block.Code)
            {
                if (cur is LoadiInstruction)
                {
                    var load = cur as LoadiInstruction;
                    values[load.RegDest0.IntVal] = load.Immed0;
                    instrValues[load] = new Tuple<VirtualRegister, int>(load.RegDest0, load.Immed0);
                }
                else if (cur is MovInstruction)
                {
                    var mov = cur as MovInstruction;
                    var val = values.GetMaybeNull(mov.RegSource0.IntVal);
                    if (val.HasValue)
                    {
                        values[mov.RegDest0.IntVal] = val.Value;
                        instrValues[mov] = new Tuple<VirtualRegister, int>(mov.RegDest0, val.Value);
                    }
                    else
                    {
                        values.Remove(mov.RegDest0.IntVal);
                    }
                }
                else if (cur is IArithmeticInstruction)
                {
                    var art = cur as IArithmeticInstruction;
                    var val = art.ConstantValue(values.GetMaybeNull(art.RegSource0.IntVal), values.GetMaybeNull(art.RegSource1.IntVal));
                    if (val.HasValue)
                    {
                        values[art.RegDest0.IntVal] = val.Value;
                        instrValues[cur] = new Tuple<VirtualRegister, int>(art.RegDest0, val.Value);
                    }
                    else
                    {
                        values.Remove(art.RegDest0.IntVal);
                    }
                }
                else
                {
                    foreach (var t in cur.DestRegs)
                    {
                        values.Remove(t.IntVal);
                    }

                }
            }
        }

        private int? getValue(MilocInstruction instr, int reg)
        {
            var d = defs.GetDef(instr, reg);
            if (d.Count != 1)
                return null;
            if (!instrValues.ContainsKey(d[0]))
                return null;
            var val = instrValues[d[0]];
            if (val.Item1.IntVal != reg)
                throw new Exception("this makes no sense, how could an instr that is the reaching def for a reg put it's result in a different reg");
            return val.Item2;
        }

        protected override bool Propagate(CFG.FunctionBlock<MilocInstruction> fun, CFG.BasicBlock<MilocInstruction> block)
        {
            bool changed = false;
            foreach (var instr in block.Code)
            {
                if (!instrValues.ContainsKey(instr))
                {
                    if (instr is IArithmeticInstruction)
                    {
                        var art = instr as IArithmeticInstruction;
                        var val = art.ConstantValue(getValue(instr, art.RegSource0.IntVal), getValue(instr, art.RegSource1.IntVal));
                        if (val.HasValue)
                        {
                            instrValues[instr] = new Tuple<VirtualRegister, int>(art.RegDest0, val.Value);
                            changed = true;
                        }
                    }
                    else if (instr is MovInstruction)
                    {
                        var mov = instr as MovInstruction;
                        var val = getValue(mov, mov.RegSource0.IntVal);
                        if (val.HasValue)
                        {
                            instrValues[instr] = new Tuple<VirtualRegister, int>(mov.RegDest0, val.Value);
                            changed = true;
                        }
                    }
                }
            }
            return changed;
        }

        public Tuple<VirtualRegister, int> GetValue(MilocInstruction instr)
        {
            Tuple<VirtualRegister, int> ret = null;
            instrValues.TryGetValue(instr, out ret);
            return ret;
        }
    }
}
