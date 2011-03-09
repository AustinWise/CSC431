using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.CFG;

namespace CSC431.IL
{
    public partial class IlGenWalker
    {
        //for getting the types of vars
        private Dictionary<string, string> globalStructMap = new Dictionary<string, string>();
        private Dictionary<string, string> localStructMap = new Dictionary<string, string>();
        private Dictionary<string, string> functionStructMap = new Dictionary<string, string>();

        private Dictionary<string, VarBase> globalMap = new Dictionary<string, VarBase>();
        private Dictionary<string, VarBase> localMap = new Dictionary<string, VarBase>();
        private Dictionary<string, List<StructMember>> structMap = new Dictionary<string, List<StructMember>>();

        private VirtRegAlloc regAlloc = VirtRegAlloc.Instance;

        private string currentFunction;

        public ProgramBlock<MilocInstruction> Program()
        {
            return this.program();
        }

        private VarBase getVarReg(string name)
        {
            if (localMap.ContainsKey(name))
                return localMap[name];
            return globalMap[name];
        }

        private void doInvoke(string id, BasicBlock<MilocInstruction> b, List<int> regLocs)
        {
            var fun = CSC431.Program.Stable.Value.getType(id);
            for (int i = 0; i < regLocs.Count; i++)
            {
                var t = fun.getArgs()[i];
                b.Add(new StoreoutargumentInstruction(regLocs[i], i) { Type = t });
            }
            b.Add(new CallInstruction(id));
        }

        private string getMemberType(string structType, string fieldName)
        {
            var s = structMap[structType];
            foreach (var m in s)
            {
                if (m.Name == fieldName)
                    return m.StructType;
            }
            throw new KeyNotFoundException();
        }

        private string[] getFields(string structType)
        {
            return structMap[structType].Select(s => s.Name).ToArray();
        }

        private string getVarType(string id)
        {
            if (localMap.ContainsKey(id))
            {
                if (localStructMap.ContainsKey(id))
                    return localStructMap[id];
                else
                    return null;
            }
            if (globalMap.ContainsKey(id))
                if (globalStructMap.ContainsKey(id))
                    return globalStructMap[id];
            return null;
        }

        private int getFieldIndex(string structType, string fieldName)
        {
            var s = structMap[structType];
            for (int i = 0; i < s.Count; i++)
            {
                if (s[i].Name == fieldName)
                    return i;
            }
            throw new KeyNotFoundException();
        }

        private class StructMember
        {
            public StructMember(string name)
            {
                this.Name = name;
                this.IsStruct = false;
            }

            public StructMember(string name, string structName)
            {
                this.Name = name;
                this.IsStruct = true;
                this.StructType = structName;
            }

            public string Name { get; private set; }
            public bool IsStruct { get; private set; }
            public string StructType { get; private set; }
        }
    }
}
