tree grammar IlGenWalker;

options
{
   language=CSharp2;
   tokenVocab=Evil;
   ASTLabelType=CommonTree;
}

@namespace {CSC431}

program
	: ^(PROGRAM (types declarations functions)) 
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

functions
	: ^(FUNCS function*)
	;

function
	: ^(FUN ID parameters ^(RETTYPE return_type) declarations statement_list)
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

statement
	: block
	| assignment
	| print
	| read
	| conditional
	| loop
	| delete
	| ret
	| invocation
	;

block
	: ^(BLOCK statement_list)
	;

statement_list
	: ^(STMTS (statement
	)*)
	;

assignment
	: ^(ASSIGN expression lvalue)
	;

print
	: ^(PRINT expression (ENDL)?)
	;

read
	: ^(READ lvalue)
	;

conditional
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
	: ^(INVOKE ID arguments)
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