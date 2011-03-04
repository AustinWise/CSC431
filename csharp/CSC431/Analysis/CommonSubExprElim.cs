using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;
using CSC431.IL;
using Ninject.Infrastructure;

namespace CSC431.Analysis
{
    public class CommonSubExprElim : IInstructionConverter<MilocInstruction, MilocInstruction>
    {
        public static ProgramBlock<MilocInstruction> DoOpt(ProgramBlock<MilocInstruction> prog)
        {
            return (ProgramBlock<MilocInstruction>)prog.Convert(new CommonSubExprElim());
        }

        public IEnumerable<MilocInstruction> FunctionStart(FunctionBlock<MilocInstruction> copy)
        {
            return Enumerable.Empty<MilocInstruction>();
        }

        public IEnumerable<MilocInstruction> Convert(InstructionStream<MilocInstruction> s)
        {
            var map = new Dictionary<string, VirtualRegister>();
            var otherMap = new Dictionary<int, string>();
            var localUseMap = new Multimap<string, string>();

            while (s.More)
            {
                var instr = s.Consume();
                var newInstr = instr;

                var addInstr = instr as AddInstruction;
                if (addInstr != null)
                {
                    string key = otherMap[addInstr.RegSource0.IntVal] + "+" + otherMap[addInstr.RegSource1.IntVal];
                    if (!map.ContainsKey(key))
                    {
                        map[key] = addInstr.RegDest0;
                        foreach (var k in localUseMap[otherMap[addInstr.RegSource0.IntVal]])
                        {
                            localUseMap.Add(key, k);
                        }
                        foreach (var k in localUseMap[otherMap[addInstr.RegSource1.IntVal]])
                        {
                            localUseMap.Add(key, k);
                        }
                    }
                    otherMap[addInstr.RegDest0.IntVal] = key;

                    var firstOperand = map[otherMap[addInstr.RegSource0.IntVal]];
                    var secondOperand = map[otherMap[addInstr.RegSource1.IntVal]];

                    newInstr = new AddInstruction(firstOperand, secondOperand, addInstr.RegDest0);
                }


                var constInstr = instr as LoadiInstruction;
                if (constInstr != null)
                {
                    string key = constInstr.Immed0.ToString();
                    if (!map.ContainsKey(key))
                        map[key] = constInstr.RegDest0;
                    otherMap[constInstr.RegDest0.IntVal] = key;
                }

                var loadInstr = instr as LoadaiVarInstruction;
                if (loadInstr != null)
                {
                    string key = loadInstr.Str0;
                    if (!map.ContainsKey(key))
                    {
                        map[key] = loadInstr.RegDest0;
                        localUseMap.Add(key, key);
                    }
                    otherMap[loadInstr.RegDest0.IntVal] = key;
                }

                var storeInstr = instr as StoreaiVarInstruction;
                if (storeInstr != null)
                {
                    foreach (KeyValuePair<string, ICollection<string>> deps in localUseMap)
                    {
                        if (deps.Value.Contains(storeInstr.Str0))
                        {
                            map.Remove(deps.Key);
                            var newOtherMap = new Dictionary<int, string>();
                            foreach (var kvp in otherMap.Where(r => r.Value != deps.Key))
                            {
                                newOtherMap.Add(kvp.Key, kvp.Value);
                            }
                            otherMap = newOtherMap;
                        }
                    }


                    if (otherMap.ContainsKey(storeInstr.RegSource0.IntVal))
                    {
                        newInstr = new StoreaiVarInstruction(map[otherMap[storeInstr.RegSource0.IntVal]], storeInstr.Str0);
                    }


                    string key = storeInstr.Str0;
                    map[key] = storeInstr.RegSource0;
                    if (!otherMap.ContainsKey(storeInstr.RegSource0.IntVal))
                        otherMap[storeInstr.RegSource0.IntVal] = key;
                    if (!localUseMap[key].Contains(key))
                        localUseMap.Add(key, key);
                }

                instr.CopyExtraData(newInstr);
                yield return newInstr;
            }

            yield break;
        }

        public IEnumerable<MilocInstruction> OldConvert(InstructionStream<MilocInstruction> s)
        {
            var map = new Dictionary<string, VirtualRegister>();
            var otherMap = new Dictionary<int, string>();
            var localUseMap = new Multimap<string, string>();

            while (s.More)
            {
                var instr = s.Consume();
                var newInstr = instr;

                var addInstr = instr as AddInstruction;
                if (addInstr != null)
                {
                    string key = otherMap[addInstr.RegSource0.IntVal] + "+" + otherMap[addInstr.RegSource1.IntVal];
                    if (!map.ContainsKey(key))
                    {
                        map[key] = addInstr.RegDest0;
                        foreach (var k in localUseMap[otherMap[addInstr.RegSource0.IntVal]])
                        {
                            localUseMap.Add(key, k);
                        }
                        foreach (var k in localUseMap[otherMap[addInstr.RegSource1.IntVal]])
                        {
                            localUseMap.Add(key, k);
                        }
                    }
                    otherMap[addInstr.RegDest0.IntVal] = key;

                    var firstOperand = map[otherMap[addInstr.RegSource0.IntVal]];
                    var secondOperand = map[otherMap[addInstr.RegSource1.IntVal]];

                    newInstr = new AddInstruction(firstOperand, secondOperand, addInstr.RegDest0);
                }


                var constInstr = instr as LoadiInstruction;
                if (constInstr != null)
                {
                    string key = constInstr.Immed0.ToString();
                    if (!map.ContainsKey(key))
                        map[key] = constInstr.RegDest0;
                    otherMap[constInstr.RegDest0.IntVal] = key;
                }

                var loadInstr = instr as LoadaiVarInstruction;
                if (loadInstr != null)
                {
                    string key = loadInstr.Str0;
                    if (!map.ContainsKey(key))
                    {
                        map[key] = loadInstr.RegDest0;
                        localUseMap.Add(key, key);
                    }
                    otherMap[loadInstr.RegDest0.IntVal] = key;
                }

                var storeInstr = instr as StoreaiVarInstruction;
                if (storeInstr != null)
                {
                    foreach (KeyValuePair<string, ICollection<string>> deps in localUseMap)
                    {
                        if (deps.Value.Contains(storeInstr.Str0))
                        {
                            map.Remove(deps.Key);
                            var newOtherMap = new Dictionary<int, string>();
                            foreach (var kvp in otherMap.Where(r => r.Value != deps.Key))
                            {
                                newOtherMap.Add(kvp.Key, kvp.Value);
                            }
                            otherMap = newOtherMap;
                        }
                    }


                    if (otherMap.ContainsKey(storeInstr.RegSource0.IntVal))
                    {
                        newInstr = new StoreaiVarInstruction(map[otherMap[storeInstr.RegSource0.IntVal]], storeInstr.Str0);
                    }


                    string key = storeInstr.Str0;
                    map[key] = storeInstr.RegSource0;
                    if (!otherMap.ContainsKey(storeInstr.RegSource0.IntVal))
                        otherMap[storeInstr.RegSource0.IntVal] = key;
                    if (!localUseMap[key].Contains(key))
                        localUseMap.Add(key, key);
                }

                instr.CopyExtraData(newInstr);
                yield return newInstr;
            }

            yield break;
        }
    }
}
