import java.util.*;

class SymbolTable
{
	private SymbolTable parent = null;
	private Hashtable<String, Type> declares = new Hashtable<String, Type>();
	private ArrayList<String> formals = new ArrayList<String>();

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
		this.declares.put(sym, t);
	}

	public void putFormal(String sym, Type t)
	{
		this.put(sym, t);
		this.formals.add(sym);
	}

	public boolean isFormal(String sym)
	{
		return formals.contains(sym);
	}

	public boolean redef(String sym)
	{
		return declares.containsKey(sym);
	}

	public Type getType(String sym)
	{
		if (declares.containsKey(sym))
			return declares.get(sym);
		if (parent == null)
			throw new Error("dear god and heaven, what are you doing, '" + sym + "' is not defined in the symbol table, you should have caught this already!");
		return parent.getType(sym);
	}

	public boolean exists(String sym)
	{
		if (declares.containsKey(sym))
			return true;
		if (parent == null)
			return false;
		return parent.exists(sym);
	}
}
