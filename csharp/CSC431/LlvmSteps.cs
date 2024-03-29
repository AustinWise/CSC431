﻿using System;
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
    public enum LlvmArch
    {
        x86,
        x64,
        SparcV9,
    }

    static class LlvmSteps
    {
        public static TransformStep<ProgramBlock<MilocInstruction>> PropegateNullPointers()
        {
            return new TransformStep<ProgramBlock<MilocInstruction>>(prog =>
            {
                return (ProgramBlock<MilocInstruction>)prog.Convert(new Analysis.NullPointerConverter(prog));
            });
        }

        public static InOutStep<ProgramBlock<MilocInstruction>, ProgramBlock<LlvmInstruction>> ConvertToLlvm()
        {
            return new InOutStep<ProgramBlock<MilocInstruction>, ProgramBlock<LlvmInstruction>>(c =>
            {
                return c.Convert(new MilocConverter<LlvmInstruction>(new LlvmTranslator())) as ProgramBlock<LlvmInstruction>;
            });
        }

        public static InStep<ProgramBlock<LlvmInstruction>> PrintCFG()
        {
            return new InStep<ProgramBlock<LlvmInstruction>>(c =>
            {
                TextWriter sw = new StreamWriter("dump.ll");
                c.Print(sw, new LlvmPrinter());
                sw.Close();
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
            ProcessStartInfo si = new ProcessStartInfo("opt.exe", "-std-compile-opts -std-link-opts -o \"" + tmp + "\"");
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
                throw new EvilException(EvilSystem.Llvm, err);
        }

        private static string compileBitcode(string tmp)
        {
            string archString;
            switch (Options.LlvmArch.Value)
            {
                case LlvmArch.x86:
                    archString = "-march=x86";
                    break;
                case LlvmArch.x64:
                    archString = "-march=x86-64";
                    break;
                case LlvmArch.SparcV9:
                    archString = "-march=sparc -mcpu=v9";
                    break;
                default:
                    throw new NotSupportedException("Unsupported LlvmArch");
            }

            ProcessStartInfo si = new ProcessStartInfo("llc.exe", "\"" + tmp + "\" " + archString + " -o -");
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
                throw new EvilException(EvilSystem.Llvm, err);

            return text;
        }
    }
}
