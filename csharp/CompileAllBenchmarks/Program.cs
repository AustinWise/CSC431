﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using CSC431.Steps;
using CSC431.CFG;
using CSC431.Sparc;
using CSC431;

namespace CompileAllBenchmarks
{
    class Program
    {
        const string benchDir = @"..\..\..\..\benchmarks\";

        static void Main(string[] args)
        {
            //FindGlobalVariables();

            List<Task<string>> tasks = new List<Task<string>>();
            tasks.AddRange(compileBenchmarks("code.s", () => { }));
            //tasks.AddRange(compileBenchmarks("llvm.s", () => { Options.Llvm.Value = true; Options.DisableOpt.Value = true; }));

            Task.WaitAll(tasks.ToArray());

            foreach (var t in tasks)
            {
                Console.Write(t.Result);
            }
        }

        private static List<Task<string>> compileBenchmarks(string outputFileName, Action setOptions)
        {
            List<Task<string>> tasks = new List<Task<string>>();
            foreach (var dontUseDir in Directory.GetDirectories(benchDir))
            {
                var myDir = dontUseDir;
                var t = new Task<string>(() =>
                {
                    var evFile = Directory.GetFiles(myDir, "*.ev").First();

                    Options.InputSource.Value = new FileStream(evFile, FileMode.Open, FileAccess.Read);
                    setOptions();

                    var outpath = Path.Combine(myDir, outputFileName);
                    var output = new StreamWriter(outpath, false, Encoding.ASCII);

                    string ret;
                    var pipe = CSC431.Options.CreatePipe(output);
                    try
                    {
                        CSC431.Steps.Step.DoAll(pipe);
                        ret = "";
                    }
                    catch (Exception ex)
                    {
                        ret = string.Format("{0}\n\t{1}\n", evFile.Substring(evFile.LastIndexOf('\\') + 1), ex.Message);
                    }
                    finally
                    {
                        output.Close();
                    }

                    if (!string.IsNullOrEmpty(ret))
                        File.Delete(outpath);

                    return ret;
                });
                t.Start();
                tasks.Add(t);
            }
            return tasks;
        }

        private static void FindGlobalVariables()
        {
            var ass = typeof(CSC431.Steps.Step).Assembly;

            foreach (var t in ass.GetTypes())
            {
                if (t.IsEnum)
                    continue;
                if (t.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), false).Length != 0)
                    continue;
                foreach (var f in t.GetFields())
                {
                    if (f.IsStatic && !f.IsInitOnly && !f.IsLiteral)
                    {
                        Console.WriteLine(t.Name + "." + f.Name);
                    }
                }
                foreach (var f in t.GetProperties())
                {
                    if (f.GetGetMethod().IsStatic)
                        Console.WriteLine(t.Name + "." + f.Name);
                }
            }
            Environment.Exit(0);
        }
    }
}
