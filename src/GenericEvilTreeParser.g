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
	: ^(PROGRAM (types[stypes] declarations[stypes, stable] functions[stypes, stable])) {wl("program");}
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
   :  (field_decl[stypes, sdef])+
   ;

types_sub [StructTypes stypes]
   :  (type_declaration[stypes] types_sub[stypes])
   | {}
   ;

field_decl [StructTypes stypes, StructTypes.StructDef sdef]
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

functions [StructTypes stypes,SymbolTable stable]
	: ^(FUNCS function[stypes, stable]*)
	;

function [StructTypes stypes,SymbolTable globalStable]
@init {SymbolTable myStable = new SymbolTable($globalStable); ArrayList<Type> sparams = new ArrayList<Type>(); }
	: ^(FUN id=ID p=parameters[stypes, myStable, sparams] ^(RETTYPE r=return_type[stypes]) d=declarations[stypes, myStable]
	{
		if ($globalStable.redef($id.text))
		{
			error($id.line, "redef function '" + $id + "'");
		}
		$globalStable.put($id.text, Type.funType(sparams, r));
		myStable.isVoidFun = r.isVoid();
	} s=statement_list)
	{
	}
	;

parameters [StructTypes stypes,SymbolTable stable, ArrayList<Type> sparams]
	: ^(PARAMS param_decl[stypes, stable, sparams]*)
	;
	
param_decl[StructTypes stypes, SymbolTable stable, ArrayList<Type> sparams]
   :  ^(DECL ^(TYPE tt=type[stypes]) id=ID)
  {
  	if ($stable.redef($id.text))
  	{
  		error($id.line, "redefinition of parameter '" + $id + "'");
  	}
  	$stable.putFormal($id.text, tt);
  	$sparams.add(tt);
  }
   ;

return_type[StructTypes stypes] returns [Type retT = null]
	: t=type[stypes]{$retT = t;} 
	| VOID {$retT = Type.voidType(); }
	;

statement[StructTypes stypes,SymbolTable stable]
	: block[stypes,stable]
	| assignment[stypes,stable]
	| print[stypes,stable]
	| read[stypes,stable]
	| conditional[stypes,stable]
	| loop[stypes,stable]
	| delete[stypes,stable]
	| ret[stypes,stable]
	| invocation[stypes,stable]
	;

block[StructTypes stypes,SymbolTable stable]
	: ^(BLOCK statement_list)
	;

statement_list[StructTypes stypes,SymbolTable stable]
	: ^(STMTS statement*)
	;

assignment[StructTypes stypes,SymbolTable stable]
	: ^(ASSIGN expression lvalue)
	;

print[StructTypes stypes,SymbolTable stable]
	: ^(PRINT expression (ENDL)?)
	;

read[StructTypes stypes,SymbolTable stable]
	: ^(READ lvalue)
	;

conditional[StructTypes stypes,SymbolTable stable]
	: ^(IF expression block (block)?)
	;

loop
	: ^(WHILE expression block expression)
	;

delete
	: ^(DELETE expression)
	;

ret
	: ^(RETURN (expression)?)
	;

invocation
	: ^(INVOKE id=ID arguments)
	;

lvalue
	: ^(DOT lvalue ID)
	| ID
	;

expression
	: ^(AND expression expression)
	| ^(OR expression expression)
	| ^(EQ expression expression)
	| ^(LT expression expression)
	| ^(GT expression expression)
	| ^(NE expression expression)
	| ^(LE expression expression)
	| ^(GE expression expression)
	| ^(PLUS expression expression)
	| ^(MINUS expression expression)
	| ^(TIMES expression expression)
	| ^(DIVIDE expression expression)
	| ^(NOT expression)
	| ^(NEG expression)
	| selector
	;

selector
	: ^(DOT selector ID)
	| factor
	;

factor
	: ^(INVOKE ID arguments)
	| ID
	| INTEGER
	| TRUE
	| FALSE
	| ^(NEW ID)
	| NULL
	;

arguments
	: arg_list
	;

arg_list
	: ^(ARGS expression+)
	| ARGS
	;