using System;
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
        static string benchDir;

        static void Main(string[] args)
        {
            //FindGlobalVariables();

            benchDir = @"..{0}..{0}..{0}..{0}benchmarks{0}";
            benchDir = string.Format(benchDir, Path.DirectorySeparatorChar);

            List<Task<string>> tasks = new List<Task<string>>();
            tasks.AddRange(compileBenchmarks("code.s", () => { }));
            tasks.AddRange(compileBenchmarks("noopt.s", () => { Options.DisableOpt.Value = true; }));
            //tasks.AddRange(compileBenchmarks("clr.txt", dir => { Options.ClrExec.Value = Path.Combine(dir, "EvilProg.exe"); }));
            //tasks.AddRange(compileBenchmarks("llvm.s", () => { Options.Llvm.Value = true; }));

            var taskArr = tasks.ToArray();
            while (!Task.WaitAll(taskArr, 100))
            {
                Console.Clear();
                for (int i = 0; i < taskArr.Length; i++)
                {
                    var t = taskArr[i];
                    if (t.Status == TaskStatus.RanToCompletion)
                        Console.Write('#');
                    else
                        Console.Write('.');
                }
                Console.WriteLine();
            }
            Console.Clear();

            foreach (var t in tasks)
            {
                Console.Write(t.Result);
            }

            Console.WriteLine("Done compiling.");
        }



        private static List<Task<string>> compileBenchmarks(string outputFileName, Action setOptions)
        {
            return compileBenchmarks(outputFileName, _ => setOptions());
        }

        private static List<Task<string>> compileBenchmarks(string outputFileName, Action<string> setOptions)
        {
            List<Task<string>> tasks = new List<Task<string>>();
            foreach (var dontUseDir in Directory.GetDirectories(benchDir))
            {
                var myDir = dontUseDir;
                var t = new Task<string>(() =>
                {
                    var evFile = Directory.GetFiles(myDir, "*.ev").First();

                    var input = new FileStream(evFile, FileMode.Open, FileAccess.Read);
                    Options.InputSource.Value = input;
                    setOptions(myDir);

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

                    //clean up stuff
                    input.Close();
                    Options.InputSource.Value = null;
                    CSC431.Program.Stable.Value = null;
                    CSC431.Program.Stypes.Value = null;

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
                    //if (f.FieldType.Name == "TaskLocal`1")
                    //    Console.WriteLine("TL " + f);
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
