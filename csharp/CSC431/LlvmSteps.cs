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

        public static InStep<ProgramBlock<LlvmInstruction>> BitcodeToSparc(TextWriter outfile)
        {
            return new InStep<ProgramBlock<LlvmInstruction>>(c =>
            {
                var tmp = Path.GetTempFileName();
                string sparc;

                try
                {
                    optimizeBitcode(c, tmp);
                    sparc = compileBitcode(tmp);
                }
                finally
                {
                    File.Delete(tmp);
                }

                outfile.Write(sparc);
            });
        }

        private static void optimizeBitcode(ProgramBlock<LlvmInstruction> c, string tmp)
        {
            ProcessStartInfo si = new ProcessStartInfo("opt.exe", "-std-compile-opts -o \"" + tmp + "\"");
            si.UseShellExecute = false;
            si.RedirectStandardInput = true;
            si.RedirectStandardError = true;
            si.RedirectStandardOutput = true;

            Process p = Process.Start(si);

            c.Print(p.StandardInput, new LlvmPrinter());
            p.StandardInput.Flush();
            p.StandardInput.Close();

            var text = p.StandardOutput.ReadToEnd();
            var err = p.StandardError.ReadToEnd();

            p.WaitForExit();

            text += p.StandardOutput.ReadToEnd();
            err += p.StandardError.ReadToEnd();

            if (p.ExitCode != 0)
                throw new EvilException(err);
        }

        private static string compileBitcode(string tmp)
        {
            ProcessStartInfo si = new ProcessStartInfo("llc.exe", "\"" + tmp + "\" -march=sparc -mcpu=v9 -o -");
            si.UseShellExecute = false;
            si.RedirectStandardInput = true;
            si.RedirectStandardError = true;
            si.RedirectStandardOutput = true;

            Process p = Process.Start(si);
            p.StandardInput.Close();

            var text = p.StandardOutput.ReadToEnd();
            var err = p.StandardError.ReadToEnd();

            p.WaitForExit();

            text += p.StandardOutput.ReadToEnd();
            err += p.StandardError.ReadToEnd();

            if (p.ExitCode != 0)
                throw new EvilException(err);

            return text;
        }
    }
}
