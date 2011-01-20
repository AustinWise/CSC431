using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;
using System.Reflection;
using System.IO;

namespace CSC431.Stack
{
    public partial class StackGen
    {
        private const string ReadInIntName = "__readInt__";

        private static readonly MethodInfo mWriteLine = typeof(Console).GetMethod("WriteLine", new Type[] { typeof(int) });
        private static readonly MethodInfo mWrite = typeof(Console).GetMethod("Write", new Type[] { typeof(int) });
        private static readonly MethodInfo mWriteChar = typeof(Console).GetMethod("Write", new Type[] { typeof(char) });

        Dictionary<string, MethodBuilder> functionMap = new Dictionary<string, MethodBuilder>();
        Dictionary<string, TypeBuilder> typeMap = new Dictionary<string, TypeBuilder>();

        Dictionary<string, VarBase> globals = new Dictionary<string, VarBase>();
        Dictionary<string, VarBase> locals = new Dictionary<string, VarBase>();

        ModuleBuilder programModule;
        TypeBuilder programType;

        MethodAttributes mAts = MethodAttributes.Static | MethodAttributes.Private | MethodAttributes.HideBySig;

        public void Program()
        {
            AssemblyName aName = new AssemblyName("EvilProgram");
            AssemblyBuilder ab = AppDomain.CurrentDomain.DefineDynamicAssembly(aName, AssemblyBuilderAccess.RunAndSave);
            programModule = ab.DefineDynamicModule(aName.Name, aName.Name + ".exe", true);
            programType = programModule.DefineType("Program", TypeAttributes.Public);

            createReadInInt();

            this.program();

            var main = functionMap["main"];

            programModule.SetUserEntryPoint(main);
            ab.SetEntryPoint(main);

            programType.CreateType();
            ab.Save(aName.Name + ".exe");
        }

        private VarBase getVar(string id)
        {
            if (globals.ContainsKey(id))
                return globals[id];
            return locals[id];
        }

        private MethodBuilder defineFunction(string id, Type retType, List<Tuple<string, Type>> ps)
        {
            var mb = programType.DefineMethod(id, mAts, retType, ps.Select(p => p.Item2).ToArray());

            int i = 0;
            foreach (var p in ps)
            {
                mb.DefineParameter(i + 1, ParameterAttributes.None, p.Item1);
                i++;
            }

            var il = mb.GetILGenerator();

            i = 0;
            foreach (var p in ps)
            {
                var loc = il.DeclareLocal(p.Item2);
                il.Emit(OpCodes.Ldarg, i);
                il.Emit(OpCodes.Stloc, loc);
                locals[p.Item1] = new VarLocal(loc);
                i++;
            }

            functionMap[id] = mb;

            return mb;
        }

        private void createReadInInt()
        {
            var mb = programType.DefineMethod(ReadInIntName, mAts, typeof(int), Type.EmptyTypes);
            var il = mb.GetILGenerator();
            functionMap[ReadInIntName] = mb;

            var topOfWhile = il.DefineLabel();
            var afterWhile = il.DefineLabel();

            var cin = il.DeclareLocal(typeof(TextReader));
            cin.SetLocalSymInfo("cin");
            var sb = il.DeclareLocal(typeof(StringBuilder));
            sb.SetLocalSymInfo("sb");
            var c = il.DeclareLocal(typeof(int));
            c.SetLocalSymInfo("c");
            var ch = il.DeclareLocal(typeof(char));
            ch.SetLocalSymInfo("ch");

            il.Emit(OpCodes.Call, typeof(Console).GetProperty("In").GetGetMethod());
            il.Emit(OpCodes.Stloc, cin);
            il.Emit(OpCodes.Newobj, typeof(StringBuilder).GetConstructor(Type.EmptyTypes));
            il.Emit(OpCodes.Stloc, sb);

            il.MarkLabel(topOfWhile);


            il.Emit(OpCodes.Ldloc, cin);
            il.Emit(OpCodes.Callvirt, typeof(TextReader).GetMethod("Read", Type.EmptyTypes));
            il.Emit(OpCodes.Dup);
            il.Emit(OpCodes.Stloc, c);
            il.Emit(OpCodes.Ldc_I4_M1);
            il.Emit(OpCodes.Ceq);
            il.Emit(OpCodes.Brtrue, afterWhile);

            il.Emit(OpCodes.Ldloc, c);
            il.Emit(OpCodes.Conv_U2);
            il.Emit(OpCodes.Stloc, ch);

            var afterInnerIf = il.DefineLabel();
            var afterNegIf = il.DefineLabel();

            il.Emit(OpCodes.Ldloc, ch);
            il.Emit(OpCodes.Ldc_I4_S, 0x2d); // '-'
            il.Emit(OpCodes.Ceq);
            il.Emit(OpCodes.Brfalse, afterNegIf);
            il.Emit(OpCodes.Br, afterInnerIf);

            il.MarkLabel(afterNegIf);

            il.Emit(OpCodes.Ldloc, ch);
            il.Emit(OpCodes.Call, typeof(Char).GetMethod("IsDigit", new[] { typeof(char) }));
            il.Emit(OpCodes.Brtrue, afterInnerIf);

            il.Emit(OpCodes.Ldloc, sb);
            il.Emit(OpCodes.Callvirt, typeof(StringBuilder).GetProperty("Length").GetGetMethod());
            il.Emit(OpCodes.Ldc_I4_0);
            il.Emit(OpCodes.Ceq);
            il.Emit(OpCodes.Brtrue, topOfWhile);
            il.Emit(OpCodes.Br, afterWhile);

            il.MarkLabel(afterInnerIf);

            il.Emit(OpCodes.Ldloc, sb);
            il.Emit(OpCodes.Ldloc, ch);
            il.Emit(OpCodes.Callvirt, typeof(StringBuilder).GetMethod("Append", new[] { typeof(char) }));
            il.Emit(OpCodes.Br, topOfWhile);

            il.MarkLabel(afterWhile);

            il.Emit(OpCodes.Ldloc, sb);
            il.Emit(OpCodes.Callvirt, typeof(StringBuilder).GetMethod("ToString", Type.EmptyTypes));
            il.Emit(OpCodes.Call, typeof(Int32).GetMethod("Parse", new[] { typeof(string) }));
            il.Emit(OpCodes.Ret);
        }

        public static int fun()
        {
            var cin = Console.In;
            StringBuilder sb = new StringBuilder();
            int c;
            while ((c = cin.Read()) != -1)
            {
                char ch = (char)c;
                if (ch == '-')
                {
                    sb.Append(ch);
                    continue;
                }
                if (!char.IsDigit(ch))
                {
                    if (sb.Length == 0)
                        continue;
                    else
                        break;
                }
                sb.Append(ch);
            }

            return int.Parse(sb.ToString());
        }

        private void setGlobals(Dictionary<string, Type> vars)
        {
            foreach (var kvp in vars)
            {
                var field = programType.DefineField(kvp.Key, kvp.Value, FieldAttributes.Private | FieldAttributes.Static);
                globals[kvp.Key] = new VarField(field);
            }
        }

        private void setLocals(Dictionary<string, Type> vars, ILGenerator gen)
        {
            foreach (var kvp in vars)
            {
                var loc = gen.DeclareLocal(kvp.Value);
                loc.SetLocalSymInfo(kvp.Key);
                locals[kvp.Key] = new VarLocal(loc);
            }
        }
    }
}
