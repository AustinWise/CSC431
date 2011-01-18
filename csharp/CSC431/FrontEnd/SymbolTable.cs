using System;
using System.Collections.Generic;
using System.Text;

namespace CSC431.FrontEnd
{
    public class SymbolTable
    {
        private SymbolTable parent = null;
        private Dictionary<String, Type> declares = new Dictionary<String, Type>();
        private List<String> formals = new List<String>();

        public Type returnType = null;

        public SymbolTable()
        {
        }

        public SymbolTable(SymbolTable parent)
        {
            this.parent = parent;
        }

        public void put(String sym, Type t)
        {
            this.declares.Add(sym, t);
        }

        public void putFormal(String sym, Type t)
        {
            this.put(sym, t);
            this.formals.Add(sym);
        }

        public bool isFormal(String sym)
        {
            return formals.Contains(sym);
        }

        public bool redef(String sym)
        {
            return declares.ContainsKey(sym);
        }

        public Type getType(String sym)
        {
            if (declares.ContainsKey(sym))
                return declares[sym];
            if (parent == null)
                throw new Exception("dear god and heaven, what are you doing, '" + sym + "' is not defined in the symbol table, you should have caught this already!");
            return parent.getType(sym);
        }

        public bool exists(String sym)
        {
            if (declares.ContainsKey(sym))
                return true;
            if (parent == null)
                return false;
            return parent.exists(sym);
        }
    }
}