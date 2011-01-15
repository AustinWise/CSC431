using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime.Tree;

public partial class EvilParser
{
    public EvilParser.program_return Program()
    {
        return this.program();
    }
}

public partial class GenericEvilTreeParser
{
    public void Program(StructTypes stypes, SymbolTable stable)
    {
        this.program(stypes, stable);
    }

    private static void error(int lineNum, String errorMsg)
    {
        Console.WriteLine(lineNum + ": " + errorMsg);
        Environment.Exit(1);
    }

    private static void wl(String msg)
    {
        Console.WriteLine(msg);
    }

    private static Type getVar(SymbolTable stable, CommonTree sym)
    {
        if (stable.exists(sym.Text))
        {
            Type t = stable.getType(sym.Text);
            if (t.isFun())
                error(sym.Line, "sym '" + sym.Text + "' is a fun and that does not fly");
            return t;
        }
        error(sym.Line, "could not find symbol '" + sym.Text + "'");
        return null;
    }

    private static Type getStruct(StructTypes stypes, CommonTree sym)
    {
        if (stypes.isDefined(sym.Text))
            return Type.structType(sym.Text);
        error(sym.Line, "could not find type '" + sym.Text + "'");
        return null;
    }

    private static Type getFieldType(StructTypes stypes, Type maybeStruct, CommonTree fieldId)
    {
        String sym = fieldId.Text;
        if (!maybeStruct.isStruct())
        {
            error(fieldId.Line, "invalid selector '" + sym + "'");
            return null;
        }

        StructTypes.StructDef def = stypes.get(maybeStruct.getStructType());

        if (!def.hasField(sym))
        {
            error(fieldId.Line, "struct type '" + def.getName() + "' does not have a field '" + sym + "'");
            return null;
        }

        return def.getFieldType(sym);
    }

    private static void ensureStructOrInt(int line, Type e1, Type e2)
    {
        if (e1.getTypeCode() != e2.getTypeCode())
            error(line, "types in expression don't match");
        if (e1.isStruct())
            return;
        ensureInt(line, e1, e2);
    }

    private static void ensureInt(int line, Type e1, Type e2)
    {
        ensureType(line, e1, e2, true);
    }

    private static void ensureBool(int line, Type e1, Type e2)
    {
        ensureType(line, e1, e2, false);
    }

    private static void ensureType(int line, Type e1, Type e2, bool isInt)
    {
        bool isGood = (isInt && e1.isInt() && e2.isInt()) || (!isInt && e1.isBool() && e2.isBool());
        if (!isGood)
            error(line, "expression not " + (isInt ? "int" : "bool"));
    }

    private static Type getFun(SymbolTable stable, CommonTree funId, List<Type> argTypes)
    {
        String sym = funId.Text;
        int line = funId.Line;
        if (!stable.exists(sym))
        {
            error(line, "function '" + sym + "' does not exist");
            return null;
        }

        Type fType = stable.getType(sym);
        if (!fType.isFun())
        {
            error(line, "'" + sym + "' is not a function");
            return null;
        }

        List<Type> formals = fType.getArgs();
        if (formals.Count != argTypes.Count)
        {
            error(line, "argument number mis-match when calling '" + sym + "' (need " + formals.Count + ", have " + argTypes.Count + ")");
            return null;
        }

        for (int i = 0; i < formals.Count; i++)
        {
            Type t1, t2;
            t1 = formals[i];
            t2 = argTypes[i];

            if (!t1.canAssign(t2))
            {
                error(line, "arg " + i + " to function '" + sym + "' is not right");
                return null;
            }
        }

        return fType.getReturnType();
    }
}