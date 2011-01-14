import java.util.*;

class Type
{
	private static final int TYPE_VOID = 0;
	private static final int TYPE_INT = 1;
	private static final int TYPE_BOOL = 2;
	private static final int TYPE_STRUCT = 3;
	private static final int TYPE_FUN = 4;

	private int typeCode;
	private String structType;

	private Type(int typeCode)
	{
		if (typeCode >= 3 || typeCode < 0)
			throw new Error("invalid type code");
		this.typeCode = typeCode;
	}

	private Type(String sName)
	{
		this.structType = sName;
		this.typeCode = TYPE_STRUCT;
	}

	private List<Type> arguments;
	private Type retType;
	private Type(List<Type> arguments, Type retType)
	{
		this.typeCode = TYPE_FUN;
		this.arguments = arguments;
		this.retType = retType;

		if (retType.typeCode == TYPE_FUN)
			throw new Error("lolololol, gtb to ML for closures");
	}

	public boolean isVoid()
	{
		return this.typeCode == TYPE_VOID;
	}

	public boolean isFun()
	{
		return this.typeCode == TYPE_FUN;
	}

	public static Type funType(List<Type> arguments, Type retType)
	{
		return new Type(arguments, retType);
	}

	public static Type structType(String sym)
	{
		return new Type(sym);
	}

	public static Type voidType()
	{
		return new Type(TYPE_VOID);
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

