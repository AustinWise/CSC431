using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.LLVM
{
    class LlvmTranslator : CSC431.IL.IMilocTranslator<LlvmInstruction>
    {
        private static Dictionary<Type, ConditionType> condMap;
        static LlvmTranslator()
        {
            condMap = new Dictionary<Type, ConditionType>();
            condMap.Add(typeof(IL.MoveqInstruction), ConditionType.eq);
            condMap.Add(typeof(IL.MovgeInstruction), ConditionType.sge);
            condMap.Add(typeof(IL.MovgtInstruction), ConditionType.sgt);
            condMap.Add(typeof(IL.MovleInstruction), ConditionType.sle);
            condMap.Add(typeof(IL.MovltInstruction), ConditionType.slt);
            condMap.Add(typeof(IL.MovneInstruction), ConditionType.ne);
        }

        private int castNum = 0;
        private FrontEnd.SymbolTable stable;


        public IEnumerable<LlvmInstruction> FunctionStart(CFG.FunctionBlock<LlvmInstruction> copy)
        {
            stable = Program.Stable.Value.Children.Where(c => c.Name == copy.Name).First();
            foreach (var l in copy.Locals)
            {
                var t = stable.getType(l);
                if (t.isStruct())
                {
                    yield return new StringInstruction("%stack_{0} = alloca %{1}*", l, t.getStructType());
                }
                else
                {
                    yield return new AllocaInstruction(new LlvmRegister("stack_" + l));
                }
            }
            yield return new AllocaInstruction(new LlvmRegister("evil_scanf"));
        }


        public IEnumerable<LlvmInstruction> Add(IL.AddInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new AddInstruction(s.RegDest0, s.RegSource0, s.RegSource1);
        }

        public IEnumerable<LlvmInstruction> Addi(IL.AddiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Div(IL.DivInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SdivInstruction(s.RegDest0, s.RegSource0, s.RegSource1);
        }

        public IEnumerable<LlvmInstruction> Mult(IL.MultInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MulInstruction(s.RegDest0, s.RegSource0, s.RegSource1);
        }

        public IEnumerable<LlvmInstruction> Sub(IL.SubInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SubInstruction(s.RegDest0, s.RegSource0, s.RegSource1);
        }

        public IEnumerable<LlvmInstruction> Rsubi(IL.RsubiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> And(IL.AndInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new AndInstruction(s.RegDest0, s.RegSource0, s.RegSource1);
        }

        public IEnumerable<LlvmInstruction> Or(IL.OrInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new OrInstruction(s.RegDest0, s.RegSource0, s.RegSource1);
        }

        public IEnumerable<LlvmInstruction> Xori(IL.XoriInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new XoriInstruction(s.RegDest0, s.RegSource0, s.Immed0);
        }

        public IEnumerable<LlvmInstruction> Loadi(IL.LoadiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            if (!(stream.Current is IL.CompInstruction))
            {
                if (s.IsNull)
                    yield return new StringInstruction("%{0} = inttoptr i32 0 to {1}*", s.RegDest0, s.Type != null ? "%" + s.Type : "i8");
                else
                    yield return new LoadiInstruction(s.RegDest0, s.Immed0);
                yield break;
            }

            //expression in while/if
            if (stream.LA(1) is IL.CbreqInstruction)
            {
                var theCmp = stream.Consume() as IL.CompInstruction;
                var theCbeq = stream.Consume() as IL.CbreqInstruction;
                var theCmpReg = new CFG.VirtualRegister(CSC431.CFG.Instruction.VirtualRegister());
                if (theCmp.RegSource1 != s.RegDest0 || s.Immed0 != 1)
                    throw new Exception("cmp using unexpected reg in branch");
                yield return new IcmpConstInstruction(ConditionType.eq, theCmpReg, theCmp.RegSource0, s.Immed0);
                yield return new BrcondInstruction(theCmpReg, theCbeq.Label0, theCbeq.Label1);
                yield break;
            }

            //remaining is conditional loads in expression for comparisions

            int falseValue = s.Immed0;
            var condMovs = new List<LlvmInstruction>();

            int cmpreg = CSC431.CFG.Instruction.VirtualRegister();
            var cmp = stream.Consume() as IL.CompInstruction;
            var next = stream.Consume();


            doCondMov<IL.MoveqInstruction>(s, falseValue, condMovs, cmpreg, cmp, next);
            doCondMov<IL.MovgeInstruction>(s, falseValue, condMovs, cmpreg, cmp, next);
            doCondMov<IL.MovgtInstruction>(s, falseValue, condMovs, cmpreg, cmp, next);
            doCondMov<IL.MovleInstruction>(s, falseValue, condMovs, cmpreg, cmp, next);
            doCondMov<IL.MovltInstruction>(s, falseValue, condMovs, cmpreg, cmp, next);
            doCondMov<IL.MovneInstruction>(s, falseValue, condMovs, cmpreg, cmp, next);

            if (condMovs.Count != 2)
            {
                throw new NotSupportedException("unknown instuction '" + next.Name + "' following 'comp'");
            }

            yield return condMovs[0];
            yield return condMovs[1];
        }

        private static void doCondMov<T>(IL.LoadiInstruction s, int falseValue, List<LlvmInstruction> condMovs, int cmpreg, IL.CompInstruction cmp, IL.MilocInstruction next)
        {
            if (next is T)
            {
                var type = cmp.StructType1 ?? cmp.StructType2;

                condMovs.Add(new IcmpInstruction(condMap[typeof(T)], cmpreg, cmp.RegSource0, cmp.RegSource1, type));

                var conv = next as dynamic;
                if (conv.RegDest0 != s.RegDest0)
                    throw new Exception("Invalid instruction stream.");
                int trueValue = conv.Immed0;
                var ret = new SelectInstruction(cmpreg, s.RegDest0, trueValue, falseValue);
                condMovs.Add(ret);
            }
        }

        public IEnumerable<LlvmInstruction> Print(IL.PrintInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            castNum++;
            yield return new StringInstruction("%cast" + castNum + " = getelementptr [4 x i8]* @.LC0, i64 0, i64 0");
            yield return new StringInstruction("call i32 (i8*, ...)* @printf(i8* %cast" + castNum + ", i32 %" + s.RegSource0 + ")");
        }

        public IEnumerable<LlvmInstruction> Println(IL.PrintlnInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            castNum++;
            yield return new StringInstruction("%cast" + castNum + " = getelementptr [4 x i8]* @.LC1, i64 0, i64 0");
            yield return new StringInstruction("call i32 (i8*, ...)* @printf(i8* %cast" + castNum + ", i32 %" + s.RegSource0 + ")");
        }

        public IEnumerable<LlvmInstruction> Read(IL.ReadInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotSupportedException("read starts with a compute global address");
        }

        public IEnumerable<LlvmInstruction> Comp(IL.CompInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Mov(IL.MovInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Moveq(IL.MoveqInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Movge(IL.MovgeInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Movgt(IL.MovgtInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Movle(IL.MovleInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Movlt(IL.MovltInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Movne(IL.MovneInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Jumpi(IL.JumpiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new BrInstruction(s.Label0);
        }

        public IEnumerable<LlvmInstruction> Cbreq(IL.CbreqInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Loadinargument(IL.LoadinargumentInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var store = stream.Consume() as IL.StoreaiVarInstruction;
            if (store.Str0 != s.Str0)
                throw new Exception("werid storaivar following loadinarg");

            yield return new StoreInstruction(new LlvmRegister(s.Str0), new LlvmRegister("stack_" + s.Str0)) { Type = stable.getType(s.Str0) };
        }

        public IEnumerable<LlvmInstruction> Call(IL.CallInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            bool isVoid = Program.Stable.Value.getType(s.Str0).getReturnType().isVoid();

            string callString = string.Format("call {0} @{1}()", isVoid ? "void" : "i32", s.Str0);

            if (stream.Current is IL.LoadretInstruction)
            {
                var loadret = stream.Consume() as IL.LoadretInstruction;
                yield return new StringInstruction(string.Format("%{0} = {1}", loadret.RegDest0, callString));
            }
            else
            {
                yield return new StringInstruction(callString);
            }
        }

        public IEnumerable<LlvmInstruction> Ret(IL.RetInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new RetvoidInstruction();
            while (stream.More)
                stream.Consume();
        }

        public IEnumerable<LlvmInstruction> Storeret(IL.StoreretInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new RetvalueInstruction(s.RegSource0);
            while (stream.More)
                stream.Consume();
        }

        public IEnumerable<LlvmInstruction> Storeoutargument(IL.StoreoutargumentInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var argList = new List<IL.StoreoutargumentInstruction>();
            argList.Add(s);

            while ((s = stream.Current as IL.StoreoutargumentInstruction) != null)
            {
                argList.Add(s);
                stream.Consume();
            }

            var call = stream.Consume() as IL.CallInstruction;

            var funDef = Program.Stable.Value.getType(call.Str0);

            var arg = string.Join(", ", argList.Select(r => funDef.getArgs()[argList.IndexOf(r)].GetLlvmType() + " %" + r.RegSource0.ToString()).ToArray());

            string callString = string.Format("call {0} @{1}({2})", funDef.getReturnType().GetLlvmType(), call.Str0, arg);

            if (stream.Current is IL.LoadretInstruction)
            {
                var loadret = stream.Consume() as IL.LoadretInstruction;
                yield return new StringInstruction(string.Format("%{0} = {1}", loadret.RegDest0, callString));
            }
            else
            {
                yield return new StringInstruction(callString);
            }
        }

        public IEnumerable<LlvmInstruction> Loadret(IL.LoadretInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> StoreaiField(IL.StoreaiFieldInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var addrReg = new CFG.VirtualRegister(CFG.Instruction.VirtualRegister());
            yield return new StringInstruction("%{0} = getelementptr %{1}* %{2}, i32 0, i32 {3}", addrReg, s.ContainingType, s.RegSource1, s.FieldIndex);
            yield return new StoreInstruction(s.RegSource0, addrReg) { IsNull = s.IsNull, Type = s.FieldType == null ? FrontEnd.Type.intType() : FrontEnd.Type.structType(s.FieldType) };
        }

        public IEnumerable<LlvmInstruction> StoreaiVar(IL.StoreaiVarInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var t = stable.getType(s.Str0);
            yield return new StoreInstruction(s.RegSource0, new LlvmRegister("stack_" + s.Str0)) { IsNull = s.IsNull, Type = t };
        }

        public IEnumerable<LlvmInstruction> LoadaiField(IL.LoadaiFieldInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var addrReg = new CFG.VirtualRegister(CFG.Instruction.VirtualRegister());
            yield return new StringInstruction("%{0} = getelementptr %{1}* %{2}, i32 0, i32 {3}", addrReg, s.ContainingType, s.RegSource0, s.FieldIndex);
            yield return new LoadInstruction(s.RegDest0, addrReg) { Type = Program.Stypes.Value.get(s.ContainingType).getFieldType(s.Str0) };
        }

        public IEnumerable<LlvmInstruction> LoadaiVar(IL.LoadaiVarInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var t = stable.getType(s.Str0);
            yield return new LoadInstruction(s.RegDest0, new LlvmRegister("stack_" + s.Str0)) { Type = t };
        }

        public IEnumerable<LlvmInstruction> Loadglobal(IL.LoadglobalInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new LoadInstruction(s.RegDest0, new LlvmRegister(s.Str0)) { Type = Program.Stable.Value.getType(s.Str0), IsGlobal = true };
        }

        public IEnumerable<LlvmInstruction> Storeglobal(IL.StoreglobalInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new StoreInstruction(s.RegSource0, new LlvmRegister(s.Str0)) { IsNull = s.IsNull, Type = Program.Stable.Value.getType(s.Str0), IsGlobal = true };
        }

        public IEnumerable<LlvmInstruction> Computeglobaladdress(IL.ComputeglobaladdressInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var read = stream.Current as IL.ReadInstruction;
            var ld = stream.LA(1) as IL.LoadglobalInstruction;

            if (read == null || ld == null || s.RegDest0 != read.RegSource0 || s.Str0 != ld.Str0)
            {
                throw new NotSupportedException("Computeglobaladdress should be followed by a read.");
            }

            stream.Consume();
            stream.Consume();

            castNum++;

            yield return new StringInstruction("%cast" + castNum + " = getelementptr [3 x i8]* @.LC2, i64 0, i64 0");
            yield return new StringInstruction("call i32 (i8*, ...)* @scanf(i8* %cast" + castNum + ", i32* %evil_scanf)");
            yield return new LoadInstruction(ld.RegDest0, new LlvmRegister("evil_scanf")) { Type = FrontEnd.Type.intType() };
        }

        public IEnumerable<LlvmInstruction> New(IL.NewInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var addrReg = new CFG.VirtualRegister(CFG.Instruction.VirtualRegister());
            yield return new StringInstruction("%{0} = call i8* @calloc(i32 {1}, i32 4)", addrReg, s.Arr0.Length);
            yield return new StringInstruction("%{0} = bitcast i8* %{2} to %{1}*", s.RegDest0, s.Str0, addrReg);
        }

        public IEnumerable<LlvmInstruction> Del(IL.DelInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var addrReg = new CFG.VirtualRegister(CFG.Instruction.VirtualRegister());
            yield return new StringInstruction("%{0} = bitcast %{1}* %{2} to i8*", addrReg, s.StructType, s.RegSource0);
            yield return new StringInstruction("call void @free(i8* %{0})", addrReg);
        }

        public IEnumerable<LlvmInstruction> Sll(IL.SllInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LlvmInstruction> Sra(IL.SraInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }
    }
}
