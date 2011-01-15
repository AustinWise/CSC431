tree grammar GenericEvilTreeParser;

options
{
   language=CSharp2;
   tokenVocab=Evil;
   ASTLabelType=CommonTree;
}

@header
{

}


program [StructTypes stypes, SymbolTable stable]
	: ^(PROGRAM (types[stypes] declarations[stypes, stable] functions[stypes, stable])) 
	{
		if (!$stable.exists("main"))
			error(-1, "main is missing");
		Type mainT = $stable.getType("main");
		if (!mainT.isFun())
			error(-1, "main is not a function");
		if (!mainT.getReturnType().isInt())
			error(-1, "main needs to return int");
		if (mainT.getArgs().Count != 0)
			error(-1, "main needs to not have any args");
		wl("everything checks out");
	}
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
	| { Console.WriteLine("There are no declarations"); }
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
@init {SymbolTable myStable = new SymbolTable($globalStable); List<Type> sparams = new List<Type>(); }
	: ^(FUN id=ID p=parameters[stypes, myStable, sparams] ^(RETTYPE r=return_type[stypes]) d=declarations[stypes, myStable]
	{
		if ($globalStable.redef($id.text))
		{
			error($id.line, "redef function '" + $id + "'");
		}
		$globalStable.put($id.text, Type.funType(sparams, r));
		myStable.returnType = r;
	} s=statement_list[stypes,myStable])
	{
		if (!s && !r.isVoid())
			error($id.line, "function '" + $id.text + "' does not return");
	}
	;

parameters [StructTypes stypes,SymbolTable stable, List<Type> sparams]
	: ^(PARAMS param_decl[stypes, stable, sparams]*)
	;
	
param_decl[StructTypes stypes, SymbolTable stable, List<Type> sparams]
   :  ^(DECL ^(TYPE tt=type[stypes]) id=ID)
  {
  	if ($stable.redef($id.text))
  	{
  		error($id.line, "redefinition of parameter '" + $id + "'");
  	}
  	$stable.putFormal($id.text, tt);
  	$sparams.Add(tt);
  }
   ;

return_type[StructTypes stypes] returns [Type retT = null]
	: t=type[stypes]{$retT = t;} 
	| VOID {$retT = Type.voidType(); }
	;

statement[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false]
	: s=block[stypes,stable] { $doesRet = s; }
	| s=assignment[stypes,stable] { $doesRet = s; }
	| s=print[stypes,stable] { $doesRet = s; }
	| s=read[stypes,stable] { $doesRet = s; }
	| s=conditional[stypes,stable] { $doesRet = s; }
	| s=loop[stypes,stable] { $doesRet = s; }
	| s=delete[stypes,stable] { $doesRet = s; }
	| s=ret[stypes,stable] { $doesRet = s; }
	| s=invocation[stypes,stable] { $doesRet = s; }
	;

block[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false]
	: ^(BLOCK s=statement_list[stypes,stable]) { $doesRet = s; }
	;

statement_list[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false]
	: ^(STMTS (s=statement[stypes,stable]
		{
			if (s)
				$doesRet = true;
		}
	)*)
	;

assignment[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false]
	: ^(ASSIGN expression[stypes,stable] lvalue[stypes,stable])
	;

print[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false]
	: ^(PRINT expression[stypes,stable] (ENDL)?)
	;

read[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false]
	: ^(READ lvalue[stypes,stable])
	;

conditional[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false]
	: ^(w=IF e=expression[stypes,stable] b1=block[stypes,stable] (b2=block[stypes,stable])?)
		{
			if (!e.isBool())
			{
				error($w.line, "if needs a bool guard");
			}
			$doesRet = b1 && b2;	
		}
	;

loop[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false]
	: ^(w=WHILE guard=expression[stypes,stable] b=block[stypes,stable] expression[stypes,stable])
		{
			if (!guard.isBool())
			{
				error($w.line, "while needs a bool guard");
			}
		}
	;

delete[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false]
	: ^(d=DELETE e=expression[stypes,stable]) 
		{
			if (!e.isStruct())
			{
				error($d.line, "delete needs a struct");
			}
		}
	;

ret[StructTypes stypes,SymbolTable stable] returns [bool doesRet = true]
	: ^(r=RETURN (e=expression[stypes,stable])?)
		{
			if (e==null)
			{
				if (!$stable.returnType.isVoid())
					error($r.line, "missing return value");
			}
			else
			{
				if (!$stable.returnType.canAssign(e))
					error($r.line, "return type mis-match");
			}
		}
	;

invocation[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false]
	: ^(INVOKE id=ID args=arguments[stypes,stable]) { getFun($stable, $id,args); }
	;

lvalue[StructTypes stypes,SymbolTable stable] returns [Type t = null]
	: ^(DOT s=lvalue[stypes,stable] id=ID) { $t = getFieldType(stypes, s, $id); }
	| id=ID { $t = getVar(stable, id); }
	;

expression[StructTypes stypes,SymbolTable stable] returns [Type t = null]
	: ^(a=AND e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureBool($a.line, e1, e2); $t = Type.boolType();}
	| ^(a=OR e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureBool($a.line, e1, e2); $t = Type.boolType();}
	| ^(a=EQ e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureStructOrInt($a.line, e1, e2); $t = Type.boolType();}
	| ^(a=LT e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureInt($a.line, e1, e2); $t = Type.boolType();}
	| ^(a=GT e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureInt($a.line, e1, e2); $t = Type.boolType();}
	| ^(a=NE e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureStructOrInt($a.line, e1, e2); $t = Type.boolType();}
	| ^(a=LE e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureInt($a.line, e1, e2); $t = Type.boolType();}
	| ^(a=GE e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureInt($a.line, e1, e2); $t = Type.boolType();}
	| ^(a=PLUS e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureInt($a.line, e1, e2); $t = Type.intType();}
	| ^(a=MINUS e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureInt($a.line, e1, e2); $t = Type.intType();}
	| ^(a=TIMES e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureInt($a.line, e1, e2); $t = Type.intType();}
	| ^(a=DIVIDE e1=expression[stypes,stable] e2=expression[stypes,stable]) {ensureInt($a.line, e1, e2); $t = Type.intType();}
	| ^(a=NOT e=expression[stypes,stable]) {ensureBool($a.line, e, Type.boolType()); $t = Type.boolType();}
	| ^(a=NEG e=expression[stypes,stable]) {ensureInt($a.line, e, Type.intType()); $t = Type.intType();}
	| s=selector[stypes,stable] { $t = s; }
	;

selector[StructTypes stypes,SymbolTable stable] returns [Type t = null]
	: ^(DOT s=selector[stypes,stable] id=ID) { $t = getFieldType(stypes, s, $id); }
	| f=factor[stypes,stable] {$t = f;}
	;

factor[StructTypes stypes,SymbolTable stable] returns [Type t = null]
	: ^(INVOKE id=ID args=arguments[stypes,stable]) {$t = getFun($stable, $id,args); }
	| id=ID {$t = getVar($stable, $id);}
	| INTEGER {$t = Type.intType();}
	| TRUE {$t = Type.boolType();}
	| FALSE{$t = Type.boolType();}
	| ^(NEW id=ID) {$t = getStruct($stypes, $id);}
	| NULL {$t = Type.nullType();}
	;

arguments[StructTypes stypes,SymbolTable stable] returns [List<Type> ret = null]
	: args=arg_list[stypes,stable] {$ret = args; }
	;

arg_list[StructTypes stypes,SymbolTable stable] returns [List<Type> args = new List<Type>()]
	: ^(ARGS (e=expression[stypes,stable]{$args.Add(e);})+ )
	| ARGS
	;