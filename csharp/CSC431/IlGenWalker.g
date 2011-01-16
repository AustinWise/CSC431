tree grammar IlGenWalker;

options
{
   language=CSharp2;
   tokenVocab=Evil;
   ASTLabelType=CommonTree;
}

@header
{
using CSC431.CFG;
}

@namespace {CSC431}

program returns [ProgramBlock prog]
	: ^(PROGRAM (types declarations funs=functions)) {$prog = new ProgramBlock(funs);}
	;

types
   :  ^(TYPES types_sub)
   |  TYPES
   ;

type_declaration
   :  ^(STRUCT (ID)
         nested_decl)
   ;

nested_decl
   :  (field_decl)+
   ;

types_sub
   :  (type_declaration types_sub)
   | 
   ;

field_decl
   :  ^(DECL ^(TYPE type) ID) 
   ;

type
	: INT
	| BOOL
	| ^(STRUCT ID)
;

declarations
	: ^(DECLS declaration)
	| 
;

declaration
	: (decl_list)*
;

decl_list
	: ^(DECLLIST ^(TYPE type) id_list)
;

id_list
	: (ID)+
;

functions returns [List<FunctionBlock> funs = new List<FunctionBlock>()]
	: ^(FUNCS (f=function{$funs.Add(f);})*)
	;

function returns [FunctionBlock f]
@init {SeqBlock body = new SeqBlock();}
	: ^(FUN id=ID parameters ^(RETTYPE return_type) declarations statement_list[body]) { $f = new FunctionBlock($id.text, body); }
	;

parameters
	: ^(PARAMS param_decl*)
	;
	
param_decl
   :  ^(DECL ^(TYPE type) ID)
   ;

return_type
	: type
	| VOID
	;

statement returns [Node node]
	: s=block {$node = s;}
	| b=assignment {$node = b;}
	| b=print {$node = b;}
	| b=read {$node = b;}
	| c=conditional {$node = c;}
	| l=loop {$node = l;}
	| b=delete {$node = b;}
	| b=ret {$node = b;}
	| b=invocation {$node = b;}
	;

block returns [SeqBlock b = new SeqBlock()]
	: ^(BLOCK statement_list[$b])
	;

statement_list[SeqBlock b]
	: ^(STMTS (s=statement
		{
			$b.Add(s);
		}
	)*)
	;

assignment returns [BasicBlock b = new BasicBlock()]
	: ^(ASSIGN expression lvalue)
	;

print returns [BasicBlock b = new BasicBlock()]
	: ^(PRINT expression (ENDL)?)
	;

read returns [BasicBlock b = new BasicBlock()]
	: ^(READ lvalue)
	;

conditional returns [IfBlock b]
	: ^(IF e=expression t=block (f=block)?) {$b = new IfBlock(e, t, f ?? new SeqBlock()); }
	;

loop returns [LoopBlock b]
	: ^(WHILE e=expression body=block expression) {$b = new LoopBlock(e, body); }
	;

delete returns [BasicBlock b = new BasicBlock()]
	: ^(DELETE expression)
	;

ret returns [BasicBlock b = new BasicBlock()]
	: ^(RETURN (expression)?)
	;

invocation returns [BasicBlock b = new BasicBlock()]
	: ^(INVOKE ID arguments)
	;

lvalue
	: ^(DOT lvalue ID)
	| ID
	;

expression returns [BasicBlock b = new BasicBlock()]
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
	| ^(NOT e=expression)
	| ^(NEG e=expression)
	| s=selector
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
	: ^(ARGS (expression)+ )
	| ARGS
	;