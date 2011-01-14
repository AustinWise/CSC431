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

	private static void wl(String msg)
	{
		System.out.println(msg);
	}
}

program [StructTypes stypes, SymbolTable stable]
	: ^(PROGRAM (types[stypes] declarations[stypes, stable] FUNCS)) {wl("program");}
	;

types [StructTypes stypes]
   :  ^(TYPES types_sub[stypes])
   |  TYPES
   ;

type_declaration [StructTypes stypes]
@init {StructTypes.StructDef sdef = null;}
   :  ^(STRUCT (id=ID) 
   	{
   		if ($stypes.isDefined($id.text))
   		{
   			error($id.line, "struct type already defined: '" + $id.text + "'");
   		}
   		sdef = $stypes.define($id.text);
   	}
         nested_decl[stypes, sdef]) 
         	{
         	}
   ;

nested_decl [StructTypes stypes, StructTypes.StructDef sdef]
   :  (decl[stypes, sdef])+
   ;

types_sub [StructTypes stypes]
   :  (type_declaration[stypes] types_sub[stypes])
   | {}
   ;

decl [StructTypes stypes, StructTypes.StructDef sdef]
   :  ^(DECL ^(TYPE tt=type[stypes]) id=ID) 
	{
		if($sdef.hasField($id.text))
		{
			error($id.line, "double field danger!: " + $id + " in struct: " + $sdef.getName());
		}
		$sdef.addField($id.text, tt);
	}
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
