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
using CSC431.ILOC;
}

@namespace {CSC431}

program returns [ProgramBlock prog]
	: ^(PROGRAM (types declarations[globalMap] funs=functions)) {$prog = new ProgramBlock(funs);}
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

declarations[Dictionary<string, int> map]
	: ^(DECLS declaration[$map])
	| 
;

declaration[Dictionary<string, int> map]
	: (decl_list[$map])*
;

decl_list[Dictionary<string, int> map]
@init { var ids = new List<string>(); }
	: ^(DECLLIST ^(TYPE type) id_list[ids])
		{
			foreach (var id in ids)
			{
				$map[id] = Instruction.VirtualRegister();
			}
		}
;

id_list[List<string> ids]
	: (id=ID)+ {$ids.Add($id.text);}
;

functions returns [List<FunctionBlock> funs = new List<FunctionBlock>()]
	: ^(FUNCS (f=function{$funs.Add(f);})*)
	;

function returns [FunctionBlock f]
@init
	{
		SeqBlock body = new SeqBlock();
		localMap.Clear();
	}
	: ^(FUN id=ID parameters ^(RETTYPE return_type) declarations[localMap] statement_list[body]) { body.SetNext(new BasicBlock()); $f = new FunctionBlock($id.text, body); }
	;

parameters
	: ^(PARAMS param_decl*)
	;
	
param_decl
   :  ^(DECL ^(TYPE type) id=ID) {argMap[$id.text] = Instruction.VirtualRegister();}
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
	: ^(ASSIGN e=expression dest=lvalue) {$b.Add(e); $b.Add(new MovInstruction(e.Reg, dest)); }
	;

print returns [BasicBlock b = new BasicBlock()]
	: ^(PRINT e=expression (ENDL)?) {$b.Add(e); $b.Add(new PrintInstruction(e.Reg));}
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

//TODO: make lvalue also support structs
lvalue returns [int dest]
	: ^(DOT lvalue ID)
	| id=ID {$dest = getVarReg($id.text); }
	;

expression returns [BasicBlock b = new BasicBlock()]
@init { int reg = Instruction.VirtualRegister(); $b.Reg = reg; }
	: ^(AND e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new AndInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(OR e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new OrInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(EQ e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(reg, 0)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MoveqInstruction(reg, 1)); }
	| ^(LT e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(reg, 0)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MovltInstruction(reg, 1)); }
	| ^(GT e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(reg, 0)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MovgtInstruction(reg, 1)); }
	| ^(NE e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(reg, 0)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MovneInstruction(reg, 1)); }
	| ^(LE e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(reg, 0)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MovleInstruction(reg, 1)); }
	| ^(GE e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(reg, 0)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MovgeInstruction(reg, 1)); }
	| ^(PLUS e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new AddInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(MINUS e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new SubInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(TIMES e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new MultInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(DIVIDE e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new DivInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(NOT e=expression) { $b.Add(e); $b.Add(new XoriInstruction(e.Reg, 1, reg)); }
	| ^(NEG e=expression)
	| s=selector { $b = s; }
	;

selector returns [BasicBlock b]
	: ^(DOT selector ID)
	| f=factor {$b = f;}
	;

factor returns [BasicBlock b = new BasicBlock()]
@init { int reg = Instruction.VirtualRegister(); $b.Reg = reg; }
	: ^(INVOKE ID arguments)
	| id=ID {$b.Add(new MovInstruction(getVarReg($id.text), reg)); }
	| i=INTEGER {$b.Add(new LoadiInstruction(reg, int.Parse($i.text))); }
	| TRUE {$b.Add(new LoadiInstruction(reg, 1)); }
	| FALSE {$b.Add(new LoadiInstruction(reg, 0)); }
	| ^(NEW ID)
	| NULL {$b.Add(new LoadiInstruction(reg, 0)); }
	;

arguments
	: arg_list
	;

arg_list
	: ^(ARGS (expression)+ )
	| ARGS
	;