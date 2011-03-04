using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.IL;
using CSC431.CFG;

namespace CSC431.Analysis
{
    public class ReachingDef<T> : IterativeDataflow<T> where T:Instruction
    {
        private Dictionary<BasicBlock<T>, Dictionary<int, T>> genSets;
        private Dictionary<BasicBlock<T>, List<int>> killSets;
        private Dictionary<BasicBlock<T>, List<BasicBlock<T>>> preds;
        private Dictionary<BasicBlock<T>, Dictionary<int, List<T>>> reachingDefs;

        public ReachingDef(ProgramBlock<T> prog)
        {
            genSets = new Dictionary<BasicBlock<T>, Dictionary<int, T>>();
            killSets = new Dictionary<BasicBlock<T>, List<int>>();
            preds = new Dictionary<BasicBlock<T>, List<BasicBlock<T>>>();
            reachingDefs = new Dictionary<BasicBlock<T>, Dictionary<int, List<T>>>();

            DoDataflow(prog);
        }

        private void addPred(BasicBlock<T> cur, BasicBlock<T> next)
        {
            if (!preds.ContainsKey(next))
                preds.Add(next, new List<BasicBlock<T>>());
            var list = preds[next];
            list.Add(cur);
        }

        protected override void CalculateLocal(FunctionBlock<T> fun, BasicBlock<T> block)
        {
            foreach (var n in block.Nexts)
            {
                addPred(block, (BasicBlock<T>)n);
            }
            if (!preds.ContainsKey(block))
                preds.Add(block, new List<BasicBlock<T>>());

            var gen = new Dictionary<int, T>();
            var kill = new List<int>();
            foreach (var i in block.Code.Reverse())
            {
                foreach (var t in i.DestRegs)
                {
                    if (!gen.ContainsKey(t.IntVal))
                        gen.Add(t.IntVal, i);
                    kill.Add(t.IntVal);
                }
            }
            genSets[block] = gen;
            killSets[block] = kill;
            reachingDefs[block] = new Dictionary<int, List<T>>();
        }

        protected override bool Propagate(FunctionBlock<T> fun, BasicBlock<T> block)
        {
            var newdefs = new Dictionary<int, List<T>>();

            foreach (var p in preds[block])
            {
                var gen = genSets[p];
                var kill = killSets[p];
                var rdef = reachingDefs[p];

                foreach (var d in rdef.Where(r => !kill.Contains(r.Key))
                                      .SelectMany(r => r.Value.Select(rr => new KeyValuePair<int, T>(r.Key, rr)))
                                      .Concat(gen))
                {
                    if (!newdefs.ContainsKey(d.Key))
                        newdefs.Add(d.Key, new List<T>());
                    var list = newdefs[d.Key];
                    if (!list.Contains(d.Value))
                        list.Add(d.Value);
                }
            }

            bool changed = false;

            var olddefs = reachingDefs[block];

            //make sure the blocks are defining the same times
            changed = olddefs.Keys.Where(d => !newdefs.ContainsKey(d)).Concat(newdefs.Keys.Where(d => !olddefs.ContainsKey(d))).Any();

            if (!changed)
            {
                foreach (var key in newdefs.Keys)
                {
                    foreach (var old in olddefs[key])
                    {
                        if (!newdefs[key].Contains(old))
                            changed = true;
                    }
                    foreach (var newd in newdefs[key])
                    {
                        if (!olddefs[key].Contains(newd))
                            changed = true;
                    }
                }
            }

            if (changed)
            {
                reachingDefs[block] = newdefs;
            }

            return changed;
        }

        /// <summary>
        /// Gets the definitions that reach to the given instruction.
        /// </summary>
        /// <param name="block"></param>
        /// <param name="instr"></param>
        /// <param name="reg"></param>
        /// <returns></returns>
        public List<T> GetDef(BasicBlock<T> block, T instr, int reg)
        {
            throw new NotImplementedException();
        }
    }
}
