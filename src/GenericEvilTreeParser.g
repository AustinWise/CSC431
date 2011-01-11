tree grammar GenericEvilTreeParser;

options
{
   tokenVocab=Evil;
   ASTLabelType=CommonTree;
}

@header
{
   import java.util.Map;
   import java.util.HashMap;
   import java.util.Vector;
   import java.util.Iterator;
}

@members
{
	private static void error(int lineNum, String errorMsg)
	{
		System.out.println(lineNum + ": " + errorMsg);
		System.exit(1);
	}
}

program [StructTypes stypes, SymbolTable stable]
	: ^(PROGRAM (t=types[stypes] d=declarations [stypes, stable] f=FUNCS))
	;

types [StructTypes stypes]
   :  ^(TYPES types_sub[stypes])
   |  TYPES
   ;

type_declaration [StructTypes stypes]
   :  STRUCT ID nested_decl[stypes]
   ;

nested_decl [StructTypes stypes]
   :  (decl[stypes] )+
   ;

types_sub [StructTypes stypes]
   :  type_declaration[stypes] types_sub[stypes]
   | {}
   ;

decl [StructTypes stypes]
   :  ^(DECL ^(TYPE type[stypes]) ID)
   ;

type [StructTypes stypes] returns [Type t = null]
	: INT { $t = Type.intType(); }
	| BOOL { $t = Type.boolType(); }
	| ^(STRUCT id=ID)
	{
		if (!$stypes.isDefined($id.text))
		{
			error($id.line, "undefined struct type '" + $id + "'");
		}
		$t = Type.structType($id.text);
	}
;

declarations [StructTypes stypes, SymbolTable stable]
	: ^(DECLS declaration[stypes,stable])
	| { System.out.println("There are no declarations"); }
;

declaration [StructTypes stypes,SymbolTable stable]
	: (decl_list[stypes,stable])*
;

decl_list [StructTypes stypes,SymbolTable stable]
	: ^(DECLLIST ^(TYPE t=type[stypes]) id_list[t,stable])
;

id_list [Type t, SymbolTable stable]
	: (
		id=ID
		{
			if ($stable.redef($id.text))
			{
				error($id.line, "redefinition of variable '" + $id + "'");
			}
			else if ($stable.isFormal($id.text))
			{
				error($id.line, "redefinition of parameter '" + $id + "'");
			}
			$stable.put($id.text, $t);
		}
	)+
;