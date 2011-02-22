using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.Steps;
using CSC431.CFG;
using CSC431.IL;
using CSC431.LLVM;
using System.Diagnostics;
using System.IO;

namespace CSC431
{
    static class LlvmSteps
    {
        public static InOutStep<ProgramBlock<MilocInstruction>, ProgramBlock<LlvmInstruction>> ConvertToLlvm()
        {
            return new InOutStep<ProgramBlock<MilocInstruction>, ProgramBlock<LlvmInstruction>>(c =>
            {
                return c.Convert(new MilocConverter<LlvmInstruction>(new LlvmTranslator())) as ProgramBlock<LlvmInstruction>;
            });
        }

        public static InStep<ProgramBlock<LlvmInstruction>> PrintCFG(TextWriter outfile)
        {
            return new InStep<ProgramBlock<LlvmInstruction>>(c =>
            {
                c.Print(outfile, new LlvmPrinter());
            });
        }

        public static InStep<ProgramBlock<LlvmInstruction>> BitcodeToSparc()
        {
            return new InStep<ProgramBlock<LlvmInstruction>>(c =>
            {
                ProcessStartInfo si = new ProcessStartInfo("llc.exe", "-march=sparcv9");
                si.UseShellExecute = false;
                si.RedirectStandardInput = true;
                si.RedirectStandardError = true;
                si.RedirectStandardOutput = true;

                Process p = Process.Start(si);

                c.Print(p.StandardInput, new LlvmPrinter());
                p.StandardInput.Flush();
                p.StandardInput.Close();

                p.WaitForExit();

                var text = p.StandardOutput.ReadToEnd();

                StreamWriter f = new StreamWriter("llvm.s");
                f.Write(text);
                f.Close();
            });
        }
    }
}
