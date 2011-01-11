tree grammar GenericEvilTreeParser;

options
{
   tokenVocab=Evil;
   ASTLabelType=CommonTree;
}

@header
{
   package evil.antlr; /* if you are using packages */
 
   import java.util.Map;
   import java.util.HashMap;
   import java.util.Vector;
   import java.util.Iterator;
}

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