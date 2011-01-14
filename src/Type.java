import java.util.*;

class Type
{
	private static final int TYPE_NULL = -1;
	private static final int TYPE_VOID = 0;
	private static final int TYPE_INT = 1;
	private static final int TYPE_BOOL = 2;
	private static final int TYPE_STRUCT = 3;
	private static final int TYPE_FUN = 4;

	private int typeCode;
	private String structType;

	private Type(int typeCode)
	{
		if (typeCode >= 3 || typeCode < -1)
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

	public Type getReturnType()
	{
		return this.retType;
	}

	public List<Type> getArgs()
	{
		return this.arguments;
	}

	public boolean isVoid()
	{
		return this.typeCode == TYPE_VOID;
	}

	public boolean isFun()
	{
		return this.typeCode == TYPE_FUN;
	}

	public boolean isNull()
	{
		return this.typeCode == TYPE_NULL;
	}

	public boolean isInt()
	{
		return this.typeCode == TYPE_INT;
	}

	public boolean isBool()
	{
		return this.typeCode == TYPE_BOOL;
	}

	public boolean isStruct()
	{
		return this.typeCode == TYPE_STRUCT;
	}

	public String getStructType()
	{
		return this.structType;
	}

	public int getTypeCode()
	{
		return typeCode;
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

	public static Type nullType()
	{
		return new Type(TYPE_NULL);
	}

	/**
	 * Can other be assigned to a var of this type.
	 */
	public boolean canAssign(Type other)
	{
		if (this.isStruct() && other.isNull())
			return true;		

		if (this.typeCode != other.typeCode)
			return false;

		if (this.typeCode == TYPE_STRUCT)
			return this.structType.equals(other.structType);
		if (this.typeCode == TYPE_FUN)
			throw new Error("why would you compare function types, that is prettyyyyyysty sillllylyly (you're a goose)");


		return true;

	}
}

