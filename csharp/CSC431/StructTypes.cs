using System;
using System.Collections.Generic;
using System.Text;


public class StructTypes
{
    private Dictionary<String, StructDef> definedTypes = new Dictionary<String, StructDef>();

	public class StructDef
	{
		private String name;
        private Dictionary<String, Type> types = new Dictionary<String, Type>();

		internal StructDef(String name)
		{
			this.name = name;
		}

		public String getName()
		{
			return name;
		}

		public bool hasField(String f)
		{
			return types.ContainsKey(f);
		}

		public void addField(String f, Type t)
		{
			types.Add(f, t);
		}

		public Type getFieldType(String f)
		{
			return this.types[f];
		}
	}

	public bool isDefined(String sym)
	{
		return definedTypes.ContainsKey(sym);
	}

	public StructDef define(String name)
	{
		StructDef sdef = new StructDef(name);
		this.definedTypes.Add(name, sdef);
		return sdef;
	}

	public StructDef get(String name)
	{
		return this.definedTypes[name];
	}
}

