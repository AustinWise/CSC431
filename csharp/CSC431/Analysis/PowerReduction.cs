using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;
using CSC431.IL;

namespace CSC431.Analysis
{
    public class PowerReduction
    {
        private static readonly Dictionary<int, int> powersOfTwoToExponent = new Dictionary<int, int>(64);

        static PowerReduction()
        {
            for (int i = 1; i < 32; i++)
            {
                powersOfTwoToExponent[(int)Math.Pow(2, i)] = i;
            }
        }


        public static ProgramBlock<MilocInstruction> DoOpt(ProgramBlock<MilocInstruction> prog)
        {
            var defs = new ReachingDef<MilocInstruction>(prog);
            var conv = prog.Convert(new MilocConverter<MilocInstruction>(new PowerReductionTranslator(defs)));
            return (ProgramBlock<MilocInstruction>)conv;
        }

        private class PowerReductionTranslator : MilocIdentityTranslator
        {
            private ReachingDef<MilocInstruction> defs;

            public PowerReductionTranslator(ReachingDef<MilocInstruction> defs)
                : base(false)
            {
                this.defs = defs;
            }

            private int? constantValue(MilocInstruction s, Register r)
            {
                var d = defs.GetDef(s, r.IntVal);
                if (d.Count != 1)
                    return null;
                var load = d[0] as LoadiInstruction;
                if (load == null)
                    return null;
                if (!powersOfTwoToExponent.ContainsKey(load.Immed0))
                    return null;
                return powersOfTwoToExponent[load.Immed0];
            }

            public override IEnumerable<MilocInstruction> Mult(MultInstruction s, InstructionStream<MilocInstruction> stream)
            {
                var d0 = constantValue(s, s.RegSource0);
                var d1 = constantValue(s, s.RegSource1);
                if (d0.HasValue == d1.HasValue)
                {
                    yield return s;
                    yield break;
                }
                if (d0.HasValue)
                {
                    yield return new SllInstruction(s.RegSource1, d0.Value, s.RegDest0);
                }
                else
                {
                    yield return new SllInstruction(s.RegSource0, d1.Value, s.RegDest0);
                }
            }

            public override IEnumerable<MilocInstruction> Div(DivInstruction s, InstructionStream<MilocInstruction> stream)
            {
                var d = constantValue(s, s.RegSource1);
                if (d.HasValue)
                {
                    yield return new SraInstruction(s.RegSource0, d.Value, s.RegDest0);
                }
                else
                {
                    yield return s;
                }
            }
        }
    }
}
