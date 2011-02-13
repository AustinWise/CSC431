using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.Sparc
{
    public class SparcTranslator : CSC431.IL.IMilocTranslator<SparcInstruction>
    {
        public IEnumerable<SparcInstruction> FunctionStart(CFG.FunctionBlock<SparcInstruction> block)
        {
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
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Mult(IL.MultInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Sub(IL.SubInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Rsubi(IL.RsubiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> And(IL.AndInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Or(IL.OrInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Xori(IL.XoriInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Loadi(IL.LoadiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new SethiInstruction(s.Immed0, s.RegDest0);
            yield return new OrlInstruction(s.Immed0, s.RegDest0);
        }

        public IEnumerable<SparcInstruction> Print(IL.PrintInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Println(IL.PrintlnInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Read(IL.ReadInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Comp(IL.CompInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Mov(IL.MovInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Moveq(IL.MoveqInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Movge(IL.MovgeInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Movgt(IL.MovgtInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Movle(IL.MovleInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Movlt(IL.MovltInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Movne(IL.MovneInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Jumpi(IL.JumpiInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Cbreq(IL.CbreqInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Loadinargument(IL.LoadinargumentInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Call(IL.CallInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Ret(IL.RetInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new RestoreInstruction();
            yield return new RetInstruction();
            yield return new NopInstruction();
        }

        public IEnumerable<SparcInstruction> Storeret(IL.StoreretInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            yield return new MovaInstruction(s.RegSource0, new SparcRegister(SparcReg.i0));
            yield return new RestoreInstruction();
            yield return new RetInstruction();
            yield return new NopInstruction();
        }

        public IEnumerable<SparcInstruction> Storeoutargument(IL.StoreoutargumentInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> Loadret(IL.LoadretInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> StoreaiField(IL.StoreaiFieldInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> StoreaiVar(IL.StoreaiVarInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> LoadaiField(IL.LoadaiFieldInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SparcInstruction> LoadaiVar(IL.LoadaiVarInstruction s, CFG.InstructionStream<IL.MilocInstruction> stream)
        {
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
