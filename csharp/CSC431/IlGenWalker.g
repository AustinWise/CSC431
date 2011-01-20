tree grammar IlGenWalker;

options
{
   language=CSharp2;
   tokenVocab=Evil;
   ASTLabelType=CommonTree;
}

@header
{
   /* <auto-generated> */
   using CSC431.CFG;
}

@namespace {CSC431.IL}

program returns [ProgramBlock<MilocInstruction> prog]
	: ^(PROGRAM (types declarations[globalMap,globalStructMap] funs=functions)) {$prog = new ProgramBlock<MilocInstruction>(funs);}
	;

types
   :  ^(TYPES types_sub)
   |  TYPES
   ;

type_declaration
@init {List<StructMember> members = new List<StructMember>();}
   :  ^(STRUCT (id=ID)
         nested_decl[members]) { structMap[$id.text] = members; }
   ;

nested_decl[List<StructMember> members]
   :  (field_decl[$members])+
   ;

types_sub
   :  (type_declaration types_sub)
   | 
   ;

field_decl[List<StructMember> members]
   :  ^(DECL ^(TYPE t=type) id=ID) 
   	{
   		if (t != null)
   			members.Add(new StructMember($id.text, t));
   		else
   			members.Add(new StructMember($id.text));
   	}
   ;

type returns [String type = null;]
	: INT
	| BOOL
	| ^(STRUCT id=ID) {$type = $id.text;}
;

declarations[Dictionary<string, int> map, Dictionary<string, string> typeMap]
	: ^(DECLS declaration[$map,$typeMap])
	| 
;

declaration[Dictionary<string, int> map, Dictionary<string, string> typeMap]
	: (decl_list[$map,$typeMap])*
;

decl_list[Dictionary<string, int> map, Dictionary<string, string> typeMap]
@init { var ids = new List<string>(); }
	: ^(DECLLIST ^(TYPE t=type) id_list[ids])
		{
			foreach (var id in ids)
			{
				$map[id] = Instruction.VirtualRegister();
				if (t != null)
					$typeMap[id] = t;
			}
		}
;

id_list[List<string> ids]
	: (id=ID {$ids.Add($id.text);} )+ 
;

functions returns [List<FunctionBlock<MilocInstruction>> funs = new List<FunctionBlock<MilocInstruction>>()]
	: ^(FUNCS (f=function{$funs.Add(f);})*)
	;

function returns [FunctionBlock<MilocInstruction> f]
@init
	{
		localMap.Clear();
		localStructMap.Clear();
		
		SeqBlock<MilocInstruction> body = new SeqBlock<MilocInstruction>();
		BasicBlock<MilocInstruction> argLoadBlock = new BasicBlock<MilocInstruction>();
		body.Add(argLoadBlock);
	}
	: ^(FUN id=ID parameters[argLoadBlock] ^(RETTYPE return_type) declarations[localMap,localStructMap] statement_list[body])
		{
			BasicBlock<MilocInstruction> returnBlock = new BasicBlock<MilocInstruction>();
			returnBlock.Add(new RetInstruction());
			body.Add(returnBlock);
			body.SetNext(new BasicBlock<MilocInstruction>());
			$f = new FunctionBlock<MilocInstruction>($id.text, body);
		}
	;

parameters[BasicBlock<MilocInstruction> b]
@init {int ndx = 0;}
	: ^(PARAMS (param_decl[$b,ndx] {ndx++;})*)
	;
	
param_decl[BasicBlock<MilocInstruction> b, int ndx]
   :  ^(DECL ^(TYPE type) id=ID) {int reg; argMap[$id.text] = reg = Instruction.VirtualRegister(); $b.Add(new LoadinargumentInstruction($id.text, ndx, reg));}
   ;

return_type
	: type
	| VOID
	;

statement returns [Node<MilocInstruction> node]
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

block returns [SeqBlock<MilocInstruction> b = new SeqBlock<MilocInstruction>()]
	: ^(BLOCK statement_list[$b])
	;

statement_list[SeqBlock<MilocInstruction> b]
	: ^(STMTS (s=statement
		{
			$b.Add(s);
		}
	)*)
	;

assignment returns [BasicBlock<MilocInstruction> b = new BasicBlock<MilocInstruction>()]
	: ^(ASSIGN dest=lvalue e=expression) {$b.Add(e); $b.Add(new MovInstruction(e.Reg, dest)); }
	;

print returns [BasicBlock<MilocInstruction> b = new BasicBlock<MilocInstruction>()]
	: ^(PRINT e=expression (el=ENDL)?) 
		{
			$b.Add(e);
			if (el == null)
				$b.Add(new PrintInstruction(e.Reg));
			else
				$b.Add(new PrintlnInstruction(e.Reg));
		}
	;

read returns [BasicBlock<MilocInstruction> b = new BasicBlock<MilocInstruction>()]
	: ^(READ dest=lvalue) { $b.Add(new ReadInstruction(dest)); }
	;

conditional returns [IfBlock<MilocInstruction> b]
@init { var lab = new Label<MilocInstruction>(); }
	: ^(IF e=expression t=block (f=block)?)
		{
			int reg = Instruction.VirtualRegister();
			f = f ?? new SeqBlock<MilocInstruction>();
			
			e.Add(new LoadiInstruction(1, reg));
			e.Add(new CompInstruction(e.Reg, reg));
			e.Add(new CbreqInstruction(t.Label, f.Label));
			
			t.Add(new JumpiInstruction(lab));
			f.Add(new JumpiInstruction(lab));
			
			$b = new IfBlock<MilocInstruction>(e, t, f ?? new SeqBlock<MilocInstruction>(), lab);
		}
	;

loop returns [LoopBlock<MilocInstruction> b]
@init { var lab = new Label<MilocInstruction>(); }
	: ^(WHILE e=expression body=block expression)
		{
			body.Add(new JumpiInstruction(e.Label));
			
			int reg = Instruction.VirtualRegister();
			e.Add(new LoadiInstruction(1, reg));
			e.Add(new CompInstruction(e.Reg, reg));
			e.Add(new CbreqInstruction(body.Label, lab));			
			
			$b = new LoopBlock<MilocInstruction>(e, body, lab);
		}
	;

delete returns [BasicBlock<MilocInstruction> b = new BasicBlock<MilocInstruction>()]
	: ^(DELETE e=expression) {$b.Add(e); $b.Add(new DelInstruction(e.Reg));}
	;

ret returns [BasicBlock<MilocInstruction> b = new BasicBlock<MilocInstruction>()]
	: ^(RETURN (e=expression)?) 
		{
			if (e != null)
			{
				$b.Add(e);
				$b.Add(new StoreretInstruction(e.Reg));
			}
			$b.Add(new RetInstruction());
		}
	;

invocation returns [BasicBlock<MilocInstruction> b = new BasicBlock<MilocInstruction>()]
	: ^(INVOKE id=ID regLocs=arguments[$b]) {doInvoke($id.text, $b, regLocs); }
	;

//TODO: make lvalue also support structs
lvalue returns [int dest]
	: ^(DOT lvalue ID)
	| id=ID {$dest = getVarReg($id.text); }
	;

expression returns [BasicBlock<MilocInstruction> b = new BasicBlock<MilocInstruction>()]
@init { int reg = Instruction.VirtualRegister(); $b.Reg = reg; }
	: ^(AND e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new AndInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(OR e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new OrInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(EQ e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(0, reg)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MoveqInstruction(1, reg)); }
	| ^(LT e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(0, reg)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MovltInstruction(1, reg)); }
	| ^(GT e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(0, reg)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MovgtInstruction(1, reg)); }
	| ^(NE e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(0, reg)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MovneInstruction(1, reg)); }
	| ^(LE e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(0, reg)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MovleInstruction(1, reg)); }
	| ^(GE e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new LoadiInstruction(0, reg)); $b.Add(new CompInstruction(e1.Reg, e2.Reg)); $b.Add(new MovgeInstruction(1, reg)); }
	| ^(PLUS e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new AddInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(MINUS e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new SubInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(TIMES e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new MultInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(DIVIDE e1=expression e2=expression) { $b.Add(e1); $b.Add(e2); $b.Add(new DivInstruction(e1.Reg, e2.Reg, reg)); }
	| ^(NOT e=expression) { $b.Add(e); $b.Add(new XoriInstruction(e.Reg, 1, reg)); }
	| ^(NEG e=expression)
	| s=selector { $b = s; }
	;

selector returns [BasicBlock<MilocInstruction> b]
	: ^(DOT s=selector id=ID)
		{
			$b = new BasicBlock<MilocInstruction>();
			int reg = Instruction.VirtualRegister();
			$b.Reg = reg;
			$b.Add(s);
			$b.Add(new LoadaiInstruction(s.Reg, $id.text, reg));
			$b.StructType = getMemberType(s.StructType, $id.text);
		}
	| f=factor {$b = f;}
	;

factor returns [BasicBlock<MilocInstruction> b = new BasicBlock<MilocInstruction>()]
@init { int reg = Instruction.VirtualRegister(); $b.Reg = reg; }
	: ^(INVOKE id=ID regLocs=arguments[b]) {doInvoke($id.text, $b, regLocs); $b.Add(new LoadretInstruction(reg)); }
	| id=ID
		{
			$b.Add(new MovInstruction(getVarReg($id.text), reg));
			$b.StructType = getVarType($id.text);
		}
	| i=INTEGER {$b.Add(new LoadiInstruction(int.Parse($i.text), reg)); }
	| TRUE {$b.Add(new LoadiInstruction(1, reg)); }
	| FALSE {$b.Add(new LoadiInstruction(0, reg)); }
	| ^(NEW id=ID) {$b.Add(new NewInstruction($id.text, getFields($id.text), reg)); $b.StructType = $id.text; }
	| NULL {$b.Add(new LoadiInstruction(0, reg)); }
	;

arguments[BasicBlock<MilocInstruction> b] returns [List<int> regLocs = new List<int>()]
	: arg_list[$b, $regLocs]
	;

arg_list [BasicBlock<MilocInstruction> b, List<int> regLocs]
	: ^(ARGS (e=expression {$b.Add(e); $regLocs.Add(e.Reg);} )+ )
	| ARGS
	;