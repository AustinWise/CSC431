using System;
using System.Collections.Generic;
using System.Text;


namespace CSC431
{
    public class Type
    {
        private const int TYPE_NULL = -1;
        private const int TYPE_VOID = 0;
        private const int TYPE_INT = 1;
        private const int TYPE_BOOL = 2;
        private const int TYPE_STRUCT = 3;
        private const int TYPE_FUN = 4;

        private int typeCode;
        private String mStructType;

        private Type(int typeCode)
        {
            if (typeCode >= 3 || typeCode < -1)
                throw new Exception("invalid type code");
            this.typeCode = typeCode;
        }

        private Type(String sName)
        {
            this.mStructType = sName;
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
                throw new Exception("lolololol, gtb to ML for closures");
        }

        public Type getReturnType()
        {
            return this.retType;
        }

        public List<Type> getArgs()
        {
            return this.arguments;
        }

        public bool isVoid()
        {
            return this.typeCode == TYPE_VOID;
        }

        public bool isFun()
        {
            return this.typeCode == TYPE_FUN;
        }

        public bool isNull()
        {
            return this.typeCode == TYPE_NULL;
        }

        public bool isInt()
        {
            return this.typeCode == TYPE_INT;
        }

        public bool isBool()
        {
            return this.typeCode == TYPE_BOOL;
        }

        public bool isStruct()
        {
            return this.typeCode == TYPE_STRUCT;
        }

        public String getStructType()
        {
            return this.mStructType;
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
        public bool canAssign(Type other)
        {
            if (this.isStruct() && other.isNull())
                return true;

            if (this.typeCode != other.typeCode)
                return false;

            if (this.typeCode == TYPE_STRUCT)
                return this.mStructType.Equals(other.mStructType);
            if (this.typeCode == TYPE_FUN)
                throw new Exception("why would you compare function types, that is prettyyyyyysty sillllylyly (you're a goose)");


            return true;

        }
    }
}