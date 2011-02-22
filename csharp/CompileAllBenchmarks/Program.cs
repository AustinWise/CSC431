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
        static void Main(string[] args)
        {
            //var ass = typeof(CSC431.Steps.Step).Assembly;

            //foreach (var t in ass.GetTypes())
            //{
            //    if (t.IsEnum)
            //        continue;
            //    foreach (var f in t.GetFields())
            //    {
            //        if (f.IsStatic && !f.IsInitOnly && !f.IsLiteral && f.FieldType.Name != "TaskLocal`1")
            //            Console.WriteLine(t.Name + "." + f.Name);
            //    }
            //    foreach (var f in t.GetProperties())
            //    {
            //        if (f.GetGetMethod().IsStatic && f.PropertyType.Name != "TaskLocal`1")
            //            Console.WriteLine(t.Name + "." + f.Name);
            //    }
            //}
            //return;


            string benchDir = @"..\..\..\..\benchmarks\";


            List<Task<string>> tasks = new List<Task<string>>();

            foreach (var dontUseDir in Directory.GetDirectories(benchDir))
            {
                var myDir = dontUseDir;
                var t = new Task<string>(() =>
                {
                    var evFile = Directory.GetFiles(myDir, "*.ev").First();

                    Options.InputSource.Value = new FileStream(evFile, FileMode.Open, FileAccess.Read);

                    var output = new StreamWriter(Path.Combine(myDir, "code.s"), false, Encoding.ASCII);

                    var pipe = CSC431.Options.CreatePipe(output);
                    try
                    {
                        CSC431.Steps.Step.DoAll(pipe);
                    }
                    catch (Exception ex)
                    {
                        return string.Format("{0}\n\t{1}\n", evFile.Substring(evFile.LastIndexOf('\\') + 1), ex.Message);
                    }
                    finally
                    {
                        output.Close();
                    }

                    return "";
                });
                t.Start();
                tasks.Add(t);
            }

            Task.WaitAll(tasks.ToArray());

            foreach (var t in tasks)
            {
                Console.Write(t.Result);
            }
        }
    }
}
