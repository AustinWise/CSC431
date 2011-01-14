
class Type
{
	private static final int TYPE_INT = 1;
	private static final int TYPE_BOOL = 2;
	private static final int TYPE_STRUCT = 3;

	private int typeCode;
	private String structType;

	private Type(int typeCode)
	{
		if (typeCode >= 3 || typeCode < 1)
			throw new Error("invalid type code");
		this.typeCode = typeCode;
	}

	private Type(String sName)
	{
		this.structType = sName;
		this.typeCode = TYPE_STRUCT;
	}

	public static Type structType(String sym)
	{
		return new Type(sym);
	}

	public static Type intType()
	{
		return new Type(TYPE_INT);
	}

	public static Type boolType()
	{
		return new Type(TYPE_BOOL);
	}
}

