using System;
using System.Collections.Generic;
using System.Text;

namespace CSC431.FrontEnd
{
    public class SymbolTable
    {
        private string name = null;
        private SymbolTable parent = null;
        private Dictionary<String, Type> declares = new Dictionary<String, Type>();
        private List<String> formals = new List<String>();
        private List<SymbolTable> children = new List<SymbolTable>();

        public Type returnType = null;

        public SymbolTable()
        {
            name = "~global~";
        }

        public SymbolTable(SymbolTable parent)
        {
            this.parent = parent;
            this.parent.children.Add(this);
        }

        public string Name
        {
            get
            {
                if (name == null)
                    throw new Exception("name not set");
                return name;
            }
            set
            {
                if (name != null)
                    throw new Exception("name set twice");
                name = value;
            }
        }

        public List<SymbolTable> Children
        {
            get
            {
                return this.children;
            }
        }

        public List<string> Formals
        {
            get
            {
                return this.formals;
            }
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