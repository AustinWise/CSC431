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

        private Dictionary<string, int> globalMap = new Dictionary<string, int>();
        private Dictionary<string, int> localMap = new Dictionary<string, int>();
        private Dictionary<string, int> argMap = new Dictionary<string, int>();
        private Dictionary<string, List<StructMember>> structMap = new Dictionary<string, List<StructMember>>();

        public ProgramBlock<MilocInstruction> Program()
        {
            return this.program();
        }

        private int getVarReg(string name)
        {
            if (localMap.ContainsKey(name))
                return localMap[name];
            if (argMap.ContainsKey(name))
                return argMap[name];
            return globalMap[name];
        }

        private void doInvoke(string id, BasicBlock<MilocInstruction> b, List<int> regLocs)
        {
            for (int i = 0; i < regLocs.Count; i++)
            {
                b.Add(new StoreoutargumentInstruction(regLocs[i], i));
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
            if (localStructMap.ContainsKey(id))
                return localStructMap[id];
            if (globalStructMap.ContainsKey(id))
                return globalStructMap[id];
            return null;
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
