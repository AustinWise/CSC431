using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Sparc
{
    public class SparcTranslator : CSC431.IL.IMilocTranslator<SparcInstruction>
    {
        int spOffset;

        public IEnumerable<SparcInstruction> FunctionStart(CFG.FunctionBlock<CSC431.IL.MilocInstruction> block)
        {
            spOffset = 92;
            var argCounts = block.FunctionsCalled.Select(funName => Program.Stable.Children.Where(n => n.Name == funName).First().Formals.Count).ToList();
            if (argCounts.Count != 0 && argCounts.Max() > 6)
            {
                spOffset += (argCounts.Max() - 6) * 4;
            }
            //TODO: actully calculate frame size
            yield return new SaveInstruction(new SparcRegister(SparcReg.sp), -1024, new SparcRegister(SparcReg.sp));
        }

        public IEnumerable<SparcInstruction> Add(IL.AddInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new AddInstruction(s.RegSource0, s.RegSource1, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Addi(IL.AddiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Div(IL.DivInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SdivxInstruction(s.RegSource0, s.RegSource1, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Mult(IL.MultInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MulxInstruction(s.RegSource0, s.RegSource1, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Sub(IL.SubInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SubInstruction(s.RegSource0, s.RegSource1, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Rsubi(IL.RsubiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> And(IL.AndInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new AndInstruction(s.RegSource0, s.RegSource1, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Or(IL.OrInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new OrInstruction(s.RegSource0, s.RegSource1, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Xori(IL.XoriInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new XoriInstruction(s.RegSource0, s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Loadi(IL.LoadiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SethiInstruction(s.Immed0, s.RegDest0);
            yield return new OrlInstruction(s.RegDest0, s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Print(IL.PrintInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Println(IL.PrintlnInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SethiInstruction(1, new SparcRegister(SparcReg.o0)) { IsConstantData = true };
            yield return new OrlInstruction(new SparcRegister(SparcReg.o0), 1, new SparcRegister(SparcReg.o0)) { IsConstantData = true };
            yield return new MovInstruction(s.RegSource0, new SparcRegister(SparcReg.o1));
            yield return new CallInstruction("printf");
            yield return new NopInstruction();
        }

        public IEnumerable<SparcInstruction> Read(IL.ReadInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Comp(IL.CompInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new CmpInstruction(s.RegSource0, s.RegSource1);
        }

        public IEnumerable<SparcInstruction> Mov(IL.MovInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new OriInstruction(s.RegSource0, 0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Moveq(IL.MoveqInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MoveqInstruction(s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Movge(IL.MovgeInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MovgeInstruction(s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Movgt(IL.MovgtInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MovgInstruction(s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Movle(IL.MovleInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MovleInstruction(s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Movlt(IL.MovltInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MovlInstruction(s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Movne(IL.MovneInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MovneInstruction(s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Jumpi(IL.JumpiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new BaInstruction(s.Label0);
            yield return new NopInstruction();
        }

        public IEnumerable<SparcInstruction> Cbreq(IL.CbreqInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new BeInstruction(s.Label0);
            yield return new NopInstruction();
            yield return new BaInstruction(s.Label1);
            yield return new NopInstruction();
        }

        public IEnumerable<SparcInstruction> Loadinargument(IL.LoadinargumentInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var store = stream.Current as CSC431.IL.StoreaiVarInstruction;
            if (store != null && s.RegDest0 == store.RegSource0 && store.ArgIndex == s.Immed0)
            {
                //This is loading arg into a local at a start of a function.
                //This is not needed as refernces to the local will be replaced with load the right i register.
                stream.Consume();
                yield break;
            }
            else
            {
                throw new NotSupportedException("Loadinarguement is not actully used for that in IL.");
            }
        }

        public IEnumerable<SparcInstruction> Call(IL.CallInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new CallInstruction(s.Str0);
            yield return new NopInstruction();
        }

        public IEnumerable<SparcInstruction> Ret(IL.RetInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new RetInstruction();
            yield return new RestoreInstruction();
        }

        public IEnumerable<SparcInstruction> Storeret(IL.StoreretInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new OriInstruction(s.RegSource0, 0, new SparcRegister(SparcReg.i0));
            yield return new RetInstruction();
            yield return new RestoreInstruction();
        }

        public IEnumerable<SparcInstruction> Storeoutargument(IL.StoreoutargumentInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            if (s.Immed0 > 5)
                yield return new StwInstruction(s.RegSource0, new SparcRegister(SparcReg.sp), 92 + (s.Immed0 - 6) * 4);
            else
                yield return new MovInstruction(s.RegSource0, new SparcRegister(SparcReg.o0 + s.Immed0));
        }

        public IEnumerable<SparcInstruction> Loadret(IL.LoadretInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MovInstruction(new SparcRegister(SparcReg.o0), s.RegDest0);
        }

        public IEnumerable<SparcInstruction> StoreaiField(IL.StoreaiFieldInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new StwInstruction(s.RegSource0, s.RegSource1, s.FieldIndex * 4);
        }

        public IEnumerable<SparcInstruction> StoreaiVar(IL.StoreaiVarInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            if (s.ArgIndex >= 0)
            {
                if (s.ArgIndex <= 5)
                    yield return new MovInstruction(s.RegSource0, new SparcRegister(SparcReg.i0 + s.ArgIndex));
                else
                    yield return new StwInstruction(s.RegSource0, new SparcRegister(SparcReg.fp), 92 + (s.ArgIndex - 6) * 4);
                yield break;
            }
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> LoadaiField(IL.LoadaiFieldInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new LdswInstruction(s.RegSource0, s.FieldIndex * 4, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> LoadaiVar(IL.LoadaiVarInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            if (s.ArgIndex >= 0)
            {
                if (s.ArgIndex <= 5)
                    yield return new MovInstruction(new SparcRegister(SparcReg.i0 + s.ArgIndex), s.RegDest0);
                else
                    yield return new LdswInstruction(new SparcRegister(SparcReg.fp), 92 + (s.ArgIndex - 6) * 4, s.RegDest0);
                yield break;
            }
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Loadglobal(IL.LoadglobalInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Storeglobal(IL.StoreglobalInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Computeglobaladdress(IL.ComputeglobaladdressInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> New(IL.NewInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Del(IL.DelInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }
    }
}
