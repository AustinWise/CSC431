using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.IL;
using CSC431.CFG;

namespace CSC431.Analysis
{
    public class NullPointerConverter : IInstructionConverter<MilocInstruction, MilocInstruction>
    {
        private ReachingDef<MilocInstruction> defs;
        private ProgramBlock<MilocInstruction> prog;

        public NullPointerConverter(ProgramBlock<MilocInstruction> prog)
        {
            defs = new ReachingDef<MilocInstruction>(prog);
            this.prog = prog;
            findLoadis();
        }

        private void findLoadis()
        {
            var allLoadis = new List<LoadiInstruction>();
            var uses = new Dictionary<MilocInstruction, List<MilocInstruction>>();

            foreach (var f in prog.Functions)
            {
                f.VisitBlocks(b =>
                {
                    foreach (var i in b.Code)
                    {
                        var li = i as LoadiInstruction;
                        if (li != null && li.IsNull)
                            allLoadis.Add(i as LoadiInstruction);
                        foreach (var s in i.SourceRegs)
                        {
                            foreach (var d in defs.GetDef(i, s.IntVal))
                            {
                                if (!uses.ContainsKey(d))
                                    uses[d] = new List<MilocInstruction>();
                                uses[d].Add(i);
                            }
                        }
                    }
                });
            }

            foreach (var li in allLoadis)
            {
                foreach (var use in uses[li])
                {
                    if (use is ITyped)
                    {
                        var typed = use as ITyped;
                        var s1 = typed.Source0Type;
                        var s2 = typed.Source1Type;
                        string type = null;
                        if (s1 != null && s1.isStruct())
                        {
                            type = s1.getStructType();
                        }
                        else if (s2 != null && s2.isStruct())
                        {
                            type = s2.getStructType();
                        }

                        if (type != null)
                            li.Type = type;
                    }
                }
            }
        }

        public IEnumerable<MilocInstruction> FunctionStart(FunctionBlock<MilocInstruction> copy)
        {
            return Enumerable.Empty<MilocInstruction>();
        }

        public IEnumerable<MilocInstruction> Convert(InstructionStream<MilocInstruction> s)
        {
            while (s.More)
            {
                var cur = s.Consume();
                if (cur is StoreaiVarInstruction)
                {
                    var store = cur as StoreaiVarInstruction;
                    var d = defs.GetDef(store, store.RegSource0.IntVal);
                    if (d.Count == 1 && d[0] is LoadiInstruction && (d[0] as LoadiInstruction).IsNull)
                    {
                        store.IsNull = true;
                    }
                }
                else if (cur is StoreaiFieldInstruction)
                {
                    var store = cur as StoreaiFieldInstruction;
                    var d = defs.GetDef(store, store.RegSource0.IntVal);
                    if (d.Count == 1 && d[0] is LoadiInstruction && (d[0] as LoadiInstruction).IsNull)
                    {
                        store.IsNull = true;
                    }
                }
                else if (cur is StoreglobalInstruction)
                {
                    var store = cur as StoreglobalInstruction;
                    var d = defs.GetDef(store, store.RegSource0.IntVal);
                    if (d.Count == 1 && d[0] is LoadiInstruction && (d[0] as LoadiInstruction).IsNull)
                    {
                        store.IsNull = true;
                    }
                }
                yield return cur;
            }
        }
    }
}
