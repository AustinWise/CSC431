using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Sparc
{
    public class SparcTranslator : CSC431.IL.IMilocTranslator<SparcInstruction>
    {
        int spOffset;
        CFG.FunctionBlock<SparcInstruction> curFunc;

        private int getLocalOffset(string name)
        {
            return spOffset + curFunc.GetLocalIndex(name) * 4;
        }

        public IEnumerable<SparcInstruction> FunctionStart(CFG.FunctionBlock<SparcInstruction> copy)
        {
            this.curFunc = copy;

            spOffset = 92;
            if (copy.MaxOutArgs > 6)
            {
                spOffset += (copy.MaxOutArgs - 6) * 4;
            }

            yield return new SaveInstruction();
        }

        public IEnumerable<SparcInstruction> Add(IL.AddInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new AddInstruction(s.RegSource0, s.RegSource1, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Addi(IL.AddiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new AddiInstruction(s.RegSource0, s.Immed0, s.RegDest0);
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
            yield return new XorInstruction(s.RegSource0, s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Loadi(IL.LoadiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SethiInstruction(s.Immed0, s.RegDest0);
            yield return new OrlInstruction(s.RegDest0, s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Print(IL.PrintInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SethistrInstruction(".ConstantString0", new SparcRegister(SparcReg.o0));
            yield return new OrlstrInstruction(new SparcRegister(SparcReg.o0), ".ConstantString0", new SparcRegister(SparcReg.o0));
            yield return new MovInstruction(s.RegSource0, new SparcRegister(SparcReg.o1));
            yield return new CallInstruction("printf");
            yield return new NopInstruction();
        }

        public IEnumerable<SparcInstruction> Println(IL.PrintlnInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SethistrInstruction(".ConstantString1", new SparcRegister(SparcReg.o0));
            yield return new OrlstrInstruction(new SparcRegister(SparcReg.o0), ".ConstantString1", new SparcRegister(SparcReg.o0));
            yield return new MovInstruction(s.RegSource0, new SparcRegister(SparcReg.o1));
            yield return new CallInstruction("printf");
            yield return new NopInstruction();
        }

        public IEnumerable<SparcInstruction> Read(IL.ReadInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotSupportedException("read starts with a computeglobaladdress");
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
                yield return new StwInstruction(s.RegSource0, SparcRegister.SP, 92 + (s.Immed0 - 6) * 4);
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
                    yield return new StwInstruction(s.RegSource0, SparcRegister.FP, 92 + (s.ArgIndex - 6) * 4);
                yield break;
            }
            yield return new StwInstruction(s.RegSource0, SparcRegister.SP, getLocalOffset(s.Str0));
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
                    yield return new LdswInstruction(SparcRegister.FP, 92 + (s.ArgIndex - 6) * 4, s.RegDest0);
                yield break;
            }
            yield return new LdswInstruction(SparcRegister.SP, getLocalOffset(s.Str0), s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Loadglobal(IL.LoadglobalInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var addrReg = new CSC431.CFG.VirtualRegister(CFG.Instruction.VirtualRegister());
            yield return new SethistrInstruction(s.Str0, addrReg);
            yield return new OrlstrInstruction(addrReg, s.Str0, addrReg);
            yield return new LdswInstruction(addrReg, 0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Storeglobal(IL.StoreglobalInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var addrReg = new CSC431.CFG.VirtualRegister(CFG.Instruction.VirtualRegister());
            yield return new SethistrInstruction(s.Str0, addrReg);
            yield return new OrlstrInstruction(addrReg, s.Str0, addrReg);
            yield return new StwInstruction(s.RegSource0, addrReg, 0);
        }

        public IEnumerable<SparcInstruction> Computeglobaladdress(IL.ComputeglobaladdressInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            var read = stream.Current as IL.ReadInstruction;
            var ld = stream.LA(1) as IL.LoadglobalInstruction;

            if (read == null || ld == null || s.RegDest0 != read.RegSource0 || s.Str0 != ld.Str0)
            {
                throw new NotSupportedException("Computeglobaladdress should be followed by a read.");
            }

            stream.Consume();
            stream.Consume();

            yield return new SethistrInstruction(".ConstantString2", new SparcRegister(SparcReg.o0));
            yield return new OrlstrInstruction(new SparcRegister(SparcReg.o0), ".ConstantString2", new SparcRegister(SparcReg.o0));
            yield return new AddiInstruction(SparcRegister.SP, getLocalOffset("~~~scanf~~~"), new SparcRegister(SparcReg.o1));
            yield return new CallInstruction("scanf");
            yield return new NopInstruction();
            yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("~~~scanf~~~"), ld.RegDest0);

        }

        public IEnumerable<SparcInstruction> New(IL.NewInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new OriInstruction(new SparcRegister(SparcReg.g0), 1, new SparcRegister(SparcReg.o0));
            yield return new OriInstruction(new SparcRegister(SparcReg.g0), s.Arr0.Length * 4, new SparcRegister(SparcReg.o1));
            yield return new CallInstruction("calloc");
            yield return new NopInstruction();
            yield return new MovInstruction(new SparcRegister(SparcReg.o0), s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Del(IL.DelInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MovInstruction(s.RegSource0, new SparcRegister(SparcReg.o0));
            yield return new CallInstruction("free");
            yield return new NopInstruction();
        }

        public IEnumerable<SparcInstruction> Sll(IL.SllInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SllInstruction(s.RegSource0, s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Sra(IL.SraInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SraInstruction(s.RegSource0, s.Immed0, s.RegDest0);
        }
    }
}
