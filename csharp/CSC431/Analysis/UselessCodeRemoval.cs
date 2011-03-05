using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;
using CSC431.IL;

namespace CSC431.Analysis
{
    public class UselessCodeRemoval
    {
        ReachingDef<MilocInstruction> defs;
        ProgramBlock<MilocInstruction> prog;

        public ProgramBlock<MilocInstruction> DoOpt(ProgramBlock<MilocInstruction> prog)
        {
            this.prog = prog;
            defs = new ReachingDef<MilocInstruction>(prog);

            Mark();
            return Sweep();
        }

        private void Mark()
        {
            var wl = new Stack<MilocInstruction>();
            foreach (var f in prog.Functions)
            {
                f.VisitBlocks(b =>
                {
                    foreach (var i in b.Code)
                    {
                        i.Mark = false;
                        if (i.IsCritical)
                        {
                            i.Mark = true;
                            wl.Push(i);
                        }
                    }
                });
            }
            while (wl.Count != 0)
            {
                var instr = wl.Pop();
                foreach (var s in instr.SourceRegs)
                {
                    foreach (var d in defs.GetDef(instr, s.IntVal))
                    {
                        if (!d.Mark)
                        {
                            d.Mark = true;
                            wl.Push(d);
                        }
                    }
                }
            }
        }

        private ProgramBlock<MilocInstruction> Sweep()
        {
            return (ProgramBlock<MilocInstruction>)prog.Convert(new MilocConverter<MilocInstruction>(new MilocIdentityTranslator(true)));
        }
    }
}
