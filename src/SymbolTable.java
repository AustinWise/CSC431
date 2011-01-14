import java.util.*;

class SymbolTable
{
	private SymbolTable parent = null;
	private Hashtable<String, Type> declares = new Hashtable<String, Type>();
	private ArrayList<String> formals = new ArrayList<String>();

	public boolean isVoidFun = false;

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
}
