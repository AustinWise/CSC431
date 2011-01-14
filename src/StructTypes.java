import java.util.*;

class StructTypes
{
	private Hashtable<String, StructDef> definedTypes = new Hashtable<String, StructDef>();

	public static class StructDef
	{
		private String name;
		private Hashtable<String, Type> types = new Hashtable<String, Type>();

		private StructDef(String name)
		{
			this.name = name;
		}

		public String getName()
		{
			return name;
		}

		public boolean hasField(String f)
		{
			return types.containsKey(f);
		}

		public void addField(String f, Type t)
		{
			types.put(f, t);
		}
	}

	public boolean isDefined(String sym)
	{
		return definedTypes.containsKey(sym);
	}

	public StructDef define(String name)
	{
		StructDef sdef = new StructDef(name);
		this.definedTypes.put(name, sdef);
		return sdef;
	}
}

