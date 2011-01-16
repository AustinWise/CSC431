// $ANTLR 3.3 Nov 30, 2010 12:50:56 GenericEvilTreeParser.g 2011-01-16 01:54:29

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162





using System;
using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace CSC431
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class GenericEvilTreeParser : Antlr.Runtime.Tree.TreeParser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "STRUCT", "INT", "BOOL", "FUN", "VOID", "PRINT", "ENDL", "READ", "IF", "ELSE", "WHILE", "DELETE", "RETURN", "TRUE", "FALSE", "NEW", "NULL", "PROGRAM", "TYPES", "TYPE", "DECLS", "FUNCS", "DECL", "DECLLIST", "PARAMS", "RETTYPE", "BLOCK", "STMTS", "INVOKE", "ARGS", "NEG", "LBRACE", "RBRACE", "SEMI", "COMMA", "LPAREN", "RPAREN", "ASSIGN", "DOT", "AND", "OR", "EQ", "LT", "GT", "NE", "LE", "GE", "PLUS", "MINUS", "TIMES", "DIVIDE", "NOT", "ID", "INTEGER", "WS", "COMMENT"
	};
	public const int EOF=-1;
	public const int STRUCT=4;
	public const int INT=5;
	public const int BOOL=6;
	public const int FUN=7;
	public const int VOID=8;
	public const int PRINT=9;
	public const int ENDL=10;
	public const int READ=11;
	public const int IF=12;
	public const int ELSE=13;
	public const int WHILE=14;
	public const int DELETE=15;
	public const int RETURN=16;
	public const int TRUE=17;
	public const int FALSE=18;
	public const int NEW=19;
	public const int NULL=20;
	public const int PROGRAM=21;
	public const int TYPES=22;
	public const int TYPE=23;
	public const int DECLS=24;
	public const int FUNCS=25;
	public const int DECL=26;
	public const int DECLLIST=27;
	public const int PARAMS=28;
	public const int RETTYPE=29;
	public const int BLOCK=30;
	public const int STMTS=31;
	public const int INVOKE=32;
	public const int ARGS=33;
	public const int NEG=34;
	public const int LBRACE=35;
	public const int RBRACE=36;
	public const int SEMI=37;
	public const int COMMA=38;
	public const int LPAREN=39;
	public const int RPAREN=40;
	public const int ASSIGN=41;
	public const int DOT=42;
	public const int AND=43;
	public const int OR=44;
	public const int EQ=45;
	public const int LT=46;
	public const int GT=47;
	public const int NE=48;
	public const int LE=49;
	public const int GE=50;
	public const int PLUS=51;
	public const int MINUS=52;
	public const int TIMES=53;
	public const int DIVIDE=54;
	public const int NOT=55;
	public const int ID=56;
	public const int INTEGER=57;
	public const int WS=58;
	public const int COMMENT=59;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public GenericEvilTreeParser( ITreeNodeStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public GenericEvilTreeParser(ITreeNodeStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
		

	public override string[] TokenNames { get { return GenericEvilTreeParser.tokenNames; } }
	public override string GrammarFileName { get { return "GenericEvilTreeParser.g"; } }



 	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}


    protected virtual void Enter_program() {}
    protected virtual void Leave_program() {}

    // $ANTLR start "program"
    // GenericEvilTreeParser.g:18:1: program[StructTypes stypes, SymbolTable stable] : ^( PROGRAM ( types[stypes] declarations[stypes, stable] functions[stypes, stable] ) ) ;
    [GrammarRule("program")]
    private void program(StructTypes stypes, SymbolTable stable)
    {

    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(18, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:19:2: ( ^( PROGRAM ( types[stypes] declarations[stypes, stable] functions[stypes, stable] ) ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:19:4: ^( PROGRAM ( types[stypes] declarations[stypes, stable] functions[stypes, stable] ) )
    		{
    		DebugLocation(19, 4);
    		DebugLocation(19, 6);
    		Match(input,PROGRAM,Follow._PROGRAM_in_program58); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(19, 14);
    		// GenericEvilTreeParser.g:19:14: ( types[stypes] declarations[stypes, stable] functions[stypes, stable] )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:19:15: types[stypes] declarations[stypes, stable] functions[stypes, stable]
    		{
    		DebugLocation(19, 15);
    		PushFollow(Follow._types_in_program61);
    		types(stypes);
    		PopFollow();

    		DebugLocation(19, 29);
    		PushFollow(Follow._declarations_in_program64);
    		declarations(stypes, stable);
    		PopFollow();

    		DebugLocation(19, 58);
    		PushFollow(Follow._functions_in_program67);
    		functions(stypes, stable);
    		PopFollow();


    		}


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(20, 2);

    				if (!stable.exists("main"))
    					error(-1, "main is missing");
    				Type mainT = stable.getType("main");
    				if (!mainT.isFun())
    					error(-1, "main is not a function");
    				if (!mainT.getReturnType().isInt())
    					error(-1, "main needs to return int");
    				if (mainT.getArgs().Count != 0)
    					error(-1, "main needs to not have any args");
    			

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(31, 1);
    	} finally { DebugExitRule(GrammarFileName, "program"); }
    	return;

    }
    // $ANTLR end "program"


    protected virtual void Enter_types() {}
    protected virtual void Leave_types() {}

    // $ANTLR start "types"
    // GenericEvilTreeParser.g:33:1: types[StructTypes stypes] : ( ^( TYPES types_sub[stypes] ) | TYPES );
    [GrammarRule("types")]
    private void types(StructTypes stypes)
    {

    	try { DebugEnterRule(GrammarFileName, "types");
    	DebugLocation(33, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:34:4: ( ^( TYPES types_sub[stypes] ) | TYPES )
    		int alt1=2;
    		try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    		int LA1_0 = input.LA(1);

    		if ((LA1_0==TYPES))
    		{
    			int LA1_1 = input.LA(2);

    			if ((LA1_1==DOWN))
    			{
    				alt1=1;
    			}
    			else if (((LA1_1>=DECLS && LA1_1<=FUNCS)))
    			{
    				alt1=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 1, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(1); }
    		switch (alt1)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:34:7: ^( TYPES types_sub[stypes] )
    			{
    			DebugLocation(34, 7);
    			DebugLocation(34, 9);
    			Match(input,TYPES,Follow._TYPES_in_types91); 

    			if (input.LA(1) == TokenTypes.Down)
    			{
    				Match(input, TokenTypes.Down, null); 
    				DebugLocation(34, 15);
    				PushFollow(Follow._types_sub_in_types93);
    				types_sub(stypes);
    				PopFollow();


    				Match(input, TokenTypes.Up, null); 
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:35:7: TYPES
    			{
    			DebugLocation(35, 7);
    			Match(input,TYPES,Follow._TYPES_in_types103); 

    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(36, 3);
    	} finally { DebugExitRule(GrammarFileName, "types"); }
    	return;

    }
    // $ANTLR end "types"


    protected virtual void Enter_type_declaration() {}
    protected virtual void Leave_type_declaration() {}

    // $ANTLR start "type_declaration"
    // GenericEvilTreeParser.g:38:1: type_declaration[StructTypes stypes] : ^( STRUCT (id= ID ) nested_decl[stypes, sdef] ) ;
    [GrammarRule("type_declaration")]
    private void type_declaration(StructTypes stypes)
    {

        CommonTree id=null;

        StructTypes.StructDef sdef = null;
    	try { DebugEnterRule(GrammarFileName, "type_declaration");
    	DebugLocation(38, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:40:4: ( ^( STRUCT (id= ID ) nested_decl[stypes, sdef] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:40:7: ^( STRUCT (id= ID ) nested_decl[stypes, sdef] )
    		{
    		DebugLocation(40, 7);
    		DebugLocation(40, 9);
    		Match(input,STRUCT,Follow._STRUCT_in_type_declaration127); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(40, 16);
    		// GenericEvilTreeParser.g:40:16: (id= ID )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:40:17: id= ID
    		{
    		DebugLocation(40, 19);
    		id=(CommonTree)Match(input,ID,Follow._ID_in_type_declaration132); 

    		}

    		DebugLocation(41, 5);

    		   		if (stypes.isDefined((id!=null?id.Text:null)))
    		   		{
    		   			error((id!=null?id.Line:0), "struct type already defined: '" + (id!=null?id.Text:null) + "'");
    		   		}
    		   		sdef = stypes.define((id!=null?id.Text:null));
    		   	
    		DebugLocation(48, 10);
    		PushFollow(Follow._nested_decl_in_type_declaration151);
    		nested_decl(stypes, sdef);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(49, 11);

    		         	

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(51, 3);
    	} finally { DebugExitRule(GrammarFileName, "type_declaration"); }
    	return;

    }
    // $ANTLR end "type_declaration"


    protected virtual void Enter_nested_decl() {}
    protected virtual void Leave_nested_decl() {}

    // $ANTLR start "nested_decl"
    // GenericEvilTreeParser.g:53:1: nested_decl[StructTypes stypes, StructTypes.StructDef sdef] : ( field_decl[stypes, sdef] )+ ;
    [GrammarRule("nested_decl")]
    private void nested_decl(StructTypes stypes, StructTypes.StructDef sdef)
    {

    	try { DebugEnterRule(GrammarFileName, "nested_decl");
    	DebugLocation(53, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:54:4: ( ( field_decl[stypes, sdef] )+ )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:54:7: ( field_decl[stypes, sdef] )+
    		{
    		DebugLocation(54, 7);
    		// GenericEvilTreeParser.g:54:7: ( field_decl[stypes, sdef] )+
    		int cnt2=0;
    		try { DebugEnterSubRule(2);
    		while (true)
    		{
    			int alt2=2;
    			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    			int LA2_0 = input.LA(1);

    			if ((LA2_0==DECL))
    			{
    				alt2=1;
    			}


    			} finally { DebugExitDecision(2); }
    			switch (alt2)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// GenericEvilTreeParser.g:54:8: field_decl[stypes, sdef]
    				{
    				DebugLocation(54, 8);
    				PushFollow(Follow._field_decl_in_nested_decl185);
    				field_decl(stypes, sdef);
    				PopFollow();


    				}
    				break;

    			default:
    				if (cnt2 >= 1)
    					goto loop2;

    				EarlyExitException eee2 = new EarlyExitException( 2, input );
    				DebugRecognitionException(eee2);
    				throw eee2;
    			}
    			cnt2++;
    		}
    		loop2:
    			;

    		} finally { DebugExitSubRule(2); }


    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(55, 3);
    	} finally { DebugExitRule(GrammarFileName, "nested_decl"); }
    	return;

    }
    // $ANTLR end "nested_decl"


    protected virtual void Enter_types_sub() {}
    protected virtual void Leave_types_sub() {}

    // $ANTLR start "types_sub"
    // GenericEvilTreeParser.g:57:1: types_sub[StructTypes stypes] : ( ( type_declaration[stypes] types_sub[stypes] ) | );
    [GrammarRule("types_sub")]
    private void types_sub(StructTypes stypes)
    {

    	try { DebugEnterRule(GrammarFileName, "types_sub");
    	DebugLocation(57, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:58:4: ( ( type_declaration[stypes] types_sub[stypes] ) | )
    		int alt3=2;
    		try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    		int LA3_0 = input.LA(1);

    		if ((LA3_0==STRUCT))
    		{
    			alt3=1;
    		}
    		else if ((LA3_0==UP))
    		{
    			alt3=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 3, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(3); }
    		switch (alt3)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:58:7: ( type_declaration[stypes] types_sub[stypes] )
    			{
    			DebugLocation(58, 7);
    			// GenericEvilTreeParser.g:58:7: ( type_declaration[stypes] types_sub[stypes] )
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:58:8: type_declaration[stypes] types_sub[stypes]
    			{
    			DebugLocation(58, 8);
    			PushFollow(Follow._type_declaration_in_types_sub207);
    			type_declaration(stypes);
    			PopFollow();

    			DebugLocation(58, 33);
    			PushFollow(Follow._types_sub_in_types_sub210);
    			types_sub(stypes);
    			PopFollow();


    			}


    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:59:6: 
    			{
    			DebugLocation(59, 6);


    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(60, 3);
    	} finally { DebugExitRule(GrammarFileName, "types_sub"); }
    	return;

    }
    // $ANTLR end "types_sub"


    protected virtual void Enter_field_decl() {}
    protected virtual void Leave_field_decl() {}

    // $ANTLR start "field_decl"
    // GenericEvilTreeParser.g:62:1: field_decl[StructTypes stypes, StructTypes.StructDef sdef] : ^( DECL ^( TYPE tt= type[stypes] ) id= ID ) ;
    [GrammarRule("field_decl")]
    private void field_decl(StructTypes stypes, StructTypes.StructDef sdef)
    {

        CommonTree id=null;
        Type tt = default(Type);

    	try { DebugEnterRule(GrammarFileName, "field_decl");
    	DebugLocation(62, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:63:4: ( ^( DECL ^( TYPE tt= type[stypes] ) id= ID ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:63:7: ^( DECL ^( TYPE tt= type[stypes] ) id= ID )
    		{
    		DebugLocation(63, 7);
    		DebugLocation(63, 9);
    		Match(input,DECL,Follow._DECL_in_field_decl238); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(63, 14);
    		DebugLocation(63, 16);
    		Match(input,TYPE,Follow._TYPE_in_field_decl241); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(63, 23);
    		PushFollow(Follow._type_in_field_decl245);
    		tt=type(stypes);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(63, 40);
    		id=(CommonTree)Match(input,ID,Follow._ID_in_field_decl251); 

    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(64, 2);

    				if(sdef.hasField((id!=null?id.Text:null)))
    				{
    					error((id!=null?id.Line:0), "double field danger!: " + id + " in struct: " + sdef.getName());
    				}
    				sdef.addField((id!=null?id.Text:null), tt);
    			

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(71, 3);
    	} finally { DebugExitRule(GrammarFileName, "field_decl"); }
    	return;

    }
    // $ANTLR end "field_decl"


    protected virtual void Enter_type() {}
    protected virtual void Leave_type() {}

    // $ANTLR start "type"
    // GenericEvilTreeParser.g:73:1: type[StructTypes stypes] returns [Type t = null] : ( INT | BOOL | ^( STRUCT id= ID ) );
    [GrammarRule("type")]
    private Type type(StructTypes stypes)
    {

        Type t =  null;

        CommonTree id=null;

    	try { DebugEnterRule(GrammarFileName, "type");
    	DebugLocation(73, 0);
    	try
    	{
    		// GenericEvilTreeParser.g:74:2: ( INT | BOOL | ^( STRUCT id= ID ) )
    		int alt4=3;
    		try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    		switch (input.LA(1))
    		{
    		case INT:
    			{
    			alt4=1;
    			}
    			break;
    		case BOOL:
    			{
    			alt4=2;
    			}
    			break;
    		case STRUCT:
    			{
    			alt4=3;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 4, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(4); }
    		switch (alt4)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:74:4: INT
    			{
    			DebugLocation(74, 4);
    			Match(input,INT,Follow._INT_in_type275); 
    			DebugLocation(74, 8);
    			 t = Type.intType(); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:75:4: BOOL
    			{
    			DebugLocation(75, 4);
    			Match(input,BOOL,Follow._BOOL_in_type282); 
    			DebugLocation(75, 9);
    			 t = Type.boolType(); 

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// GenericEvilTreeParser.g:76:4: ^( STRUCT id= ID )
    			{
    			DebugLocation(76, 4);
    			DebugLocation(76, 6);
    			Match(input,STRUCT,Follow._STRUCT_in_type290); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(76, 15);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_type294); 

    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(77, 2);

    					if (!stypes.isDefined((id!=null?id.Text:null)))
    					{
    						error((id!=null?id.Line:0), "undefined struct type '" + id + "'");
    					}
    					t = Type.structType((id!=null?id.Text:null));
    				

    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(84, 0);
    	} finally { DebugExitRule(GrammarFileName, "type"); }
    	return t;

    }
    // $ANTLR end "type"


    protected virtual void Enter_declarations() {}
    protected virtual void Leave_declarations() {}

    // $ANTLR start "declarations"
    // GenericEvilTreeParser.g:86:1: declarations[StructTypes stypes, SymbolTable stable] : ( ^( DECLS declaration[stypes,stable] ) | );
    [GrammarRule("declarations")]
    private void declarations(StructTypes stypes, SymbolTable stable)
    {

    	try { DebugEnterRule(GrammarFileName, "declarations");
    	DebugLocation(86, 0);
    	try
    	{
    		// GenericEvilTreeParser.g:87:2: ( ^( DECLS declaration[stypes,stable] ) | )
    		int alt5=2;
    		try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    		int LA5_0 = input.LA(1);

    		if ((LA5_0==DECLS))
    		{
    			alt5=1;
    		}
    		else if ((LA5_0==FUNCS||LA5_0==STMTS))
    		{
    			alt5=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(5); }
    		switch (alt5)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:87:4: ^( DECLS declaration[stypes,stable] )
    			{
    			DebugLocation(87, 4);
    			DebugLocation(87, 6);
    			Match(input,DECLS,Follow._DECLS_in_declarations311); 

    			if (input.LA(1) == TokenTypes.Down)
    			{
    				Match(input, TokenTypes.Down, null); 
    				DebugLocation(87, 12);
    				PushFollow(Follow._declaration_in_declarations313);
    				declaration(stypes, stable);
    				PopFollow();


    				Match(input, TokenTypes.Up, null); 
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:88:4: 
    			{
    			DebugLocation(88, 4);


    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(89, 0);
    	} finally { DebugExitRule(GrammarFileName, "declarations"); }
    	return;

    }
    // $ANTLR end "declarations"


    protected virtual void Enter_declaration() {}
    protected virtual void Leave_declaration() {}

    // $ANTLR start "declaration"
    // GenericEvilTreeParser.g:91:1: declaration[StructTypes stypes,SymbolTable stable] : ( decl_list[stypes,stable] )* ;
    [GrammarRule("declaration")]
    private void declaration(StructTypes stypes, SymbolTable stable)
    {

    	try { DebugEnterRule(GrammarFileName, "declaration");
    	DebugLocation(91, 0);
    	try
    	{
    		// GenericEvilTreeParser.g:92:2: ( ( decl_list[stypes,stable] )* )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:92:4: ( decl_list[stypes,stable] )*
    		{
    		DebugLocation(92, 4);
    		// GenericEvilTreeParser.g:92:4: ( decl_list[stypes,stable] )*
    		try { DebugEnterSubRule(6);
    		while (true)
    		{
    			int alt6=2;
    			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    			int LA6_0 = input.LA(1);

    			if ((LA6_0==DECLLIST))
    			{
    				alt6=1;
    			}


    			} finally { DebugExitDecision(6); }
    			switch ( alt6 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// GenericEvilTreeParser.g:92:5: decl_list[stypes,stable]
    				{
    				DebugLocation(92, 5);
    				PushFollow(Follow._decl_list_in_declaration333);
    				decl_list(stypes, stable);
    				PopFollow();


    				}
    				break;

    			default:
    				goto loop6;
    			}
    		}

    		loop6:
    			;

    		} finally { DebugExitSubRule(6); }


    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(93, 0);
    	} finally { DebugExitRule(GrammarFileName, "declaration"); }
    	return;

    }
    // $ANTLR end "declaration"


    protected virtual void Enter_decl_list() {}
    protected virtual void Leave_decl_list() {}

    // $ANTLR start "decl_list"
    // GenericEvilTreeParser.g:95:1: decl_list[StructTypes stypes,SymbolTable stable] : ^( DECLLIST ^( TYPE t= type[stypes] ) id_list[t,stable] ) ;
    [GrammarRule("decl_list")]
    private void decl_list(StructTypes stypes, SymbolTable stable)
    {

        Type t = default(Type);

    	try { DebugEnterRule(GrammarFileName, "decl_list");
    	DebugLocation(95, 0);
    	try
    	{
    		// GenericEvilTreeParser.g:96:2: ( ^( DECLLIST ^( TYPE t= type[stypes] ) id_list[t,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:96:4: ^( DECLLIST ^( TYPE t= type[stypes] ) id_list[t,stable] )
    		{
    		DebugLocation(96, 4);
    		DebugLocation(96, 6);
    		Match(input,DECLLIST,Follow._DECLLIST_in_decl_list349); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(96, 15);
    		DebugLocation(96, 17);
    		Match(input,TYPE,Follow._TYPE_in_decl_list352); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(96, 23);
    		PushFollow(Follow._type_in_decl_list356);
    		t=type(stypes);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(96, 38);
    		PushFollow(Follow._id_list_in_decl_list360);
    		id_list(t, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(97, 0);
    	} finally { DebugExitRule(GrammarFileName, "decl_list"); }
    	return;

    }
    // $ANTLR end "decl_list"


    protected virtual void Enter_id_list() {}
    protected virtual void Leave_id_list() {}

    // $ANTLR start "id_list"
    // GenericEvilTreeParser.g:99:1: id_list[Type t, SymbolTable stable] : (id= ID )+ ;
    [GrammarRule("id_list")]
    private void id_list(Type t, SymbolTable stable)
    {

        CommonTree id=null;

    	try { DebugEnterRule(GrammarFileName, "id_list");
    	DebugLocation(99, 0);
    	try
    	{
    		// GenericEvilTreeParser.g:100:2: ( (id= ID )+ )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:100:4: (id= ID )+
    		{
    		DebugLocation(100, 4);
    		// GenericEvilTreeParser.g:100:4: (id= ID )+
    		int cnt7=0;
    		try { DebugEnterSubRule(7);
    		while (true)
    		{
    			int alt7=2;
    			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
    			int LA7_0 = input.LA(1);

    			if ((LA7_0==ID))
    			{
    				alt7=1;
    			}


    			} finally { DebugExitDecision(7); }
    			switch (alt7)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// GenericEvilTreeParser.g:101:3: id= ID
    				{
    				DebugLocation(101, 5);
    				id=(CommonTree)Match(input,ID,Follow._ID_in_id_list380); 
    				DebugLocation(102, 3);

    							if (stable.redef((id!=null?id.Text:null)))
    							{
    								error((id!=null?id.Line:0), "redefinition of variable '" + id + "'");
    							}
    							else if (stable.isFormal((id!=null?id.Text:null)))
    							{
    								error((id!=null?id.Line:0), "redefinition of parameter '" + id + "'");
    							}
    							stable.put((id!=null?id.Text:null), t);
    						

    				}
    				break;

    			default:
    				if (cnt7 >= 1)
    					goto loop7;

    				EarlyExitException eee7 = new EarlyExitException( 7, input );
    				DebugRecognitionException(eee7);
    				throw eee7;
    			}
    			cnt7++;
    		}
    		loop7:
    			;

    		} finally { DebugExitSubRule(7); }


    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(114, 0);
    	} finally { DebugExitRule(GrammarFileName, "id_list"); }
    	return;

    }
    // $ANTLR end "id_list"


    protected virtual void Enter_functions() {}
    protected virtual void Leave_functions() {}

    // $ANTLR start "functions"
    // GenericEvilTreeParser.g:116:1: functions[StructTypes stypes,SymbolTable stable] : ^( FUNCS ( function[stypes, stable] )* ) ;
    [GrammarRule("functions")]
    private void functions(StructTypes stypes, SymbolTable stable)
    {

    	try { DebugEnterRule(GrammarFileName, "functions");
    	DebugLocation(116, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:117:2: ( ^( FUNCS ( function[stypes, stable] )* ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:117:4: ^( FUNCS ( function[stypes, stable] )* )
    		{
    		DebugLocation(117, 4);
    		DebugLocation(117, 6);
    		Match(input,FUNCS,Follow._FUNCS_in_functions401); 

    		if (input.LA(1) == TokenTypes.Down)
    		{
    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(117, 12);
    			// GenericEvilTreeParser.g:117:12: ( function[stypes, stable] )*
    			try { DebugEnterSubRule(8);
    			while (true)
    			{
    				int alt8=2;
    				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
    				int LA8_0 = input.LA(1);

    				if ((LA8_0==FUN))
    				{
    					alt8=1;
    				}


    				} finally { DebugExitDecision(8); }
    				switch ( alt8 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// GenericEvilTreeParser.g:117:12: function[stypes, stable]
    					{
    					DebugLocation(117, 12);
    					PushFollow(Follow._function_in_functions403);
    					function(stypes, stable);
    					PopFollow();


    					}
    					break;

    				default:
    					goto loop8;
    				}
    			}

    			loop8:
    				;

    			} finally { DebugExitSubRule(8); }


    			Match(input, TokenTypes.Up, null); 
    		}

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(118, 1);
    	} finally { DebugExitRule(GrammarFileName, "functions"); }
    	return;

    }
    // $ANTLR end "functions"


    protected virtual void Enter_function() {}
    protected virtual void Leave_function() {}

    // $ANTLR start "function"
    // GenericEvilTreeParser.g:120:1: function[StructTypes stypes,SymbolTable globalStable] : ^( FUN id= ID p= parameters[stypes, myStable, sparams] ^( RETTYPE r= return_type[stypes] ) d= declarations[stypes, myStable] s= statement_list[stypes,myStable] ) ;
    [GrammarRule("function")]
    private void function(StructTypes stypes, SymbolTable globalStable)
    {

        CommonTree id=null;
        Type r = default(Type);
        bool s = default(bool);

        SymbolTable myStable = new SymbolTable(globalStable); List<Type> sparams = new List<Type>(); 
    	try { DebugEnterRule(GrammarFileName, "function");
    	DebugLocation(120, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:122:2: ( ^( FUN id= ID p= parameters[stypes, myStable, sparams] ^( RETTYPE r= return_type[stypes] ) d= declarations[stypes, myStable] s= statement_list[stypes,myStable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:122:4: ^( FUN id= ID p= parameters[stypes, myStable, sparams] ^( RETTYPE r= return_type[stypes] ) d= declarations[stypes, myStable] s= statement_list[stypes,myStable] )
    		{
    		DebugLocation(122, 4);
    		DebugLocation(122, 6);
    		Match(input,FUN,Follow._FUN_in_function425); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(122, 12);
    		id=(CommonTree)Match(input,ID,Follow._ID_in_function429); 
    		DebugLocation(122, 17);
    		PushFollow(Follow._parameters_in_function433);
    		parameters(stypes, myStable, sparams);
    		PopFollow();

    		DebugLocation(122, 56);
    		DebugLocation(122, 58);
    		Match(input,RETTYPE,Follow._RETTYPE_in_function437); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(122, 67);
    		PushFollow(Follow._return_type_in_function441);
    		r=return_type(stypes);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(122, 90);
    		PushFollow(Follow._declarations_in_function447);
    		declarations(stypes, myStable);
    		PopFollow();

    		DebugLocation(123, 2);

    				if (globalStable.redef((id!=null?id.Text:null)))
    				{
    					error((id!=null?id.Line:0), "redef function '" + id + "'");
    				}
    				globalStable.put((id!=null?id.Text:null), Type.funType(sparams, r));
    				myStable.returnType = r;
    			
    		DebugLocation(130, 5);
    		PushFollow(Follow._statement_list_in_function455);
    		s=statement_list(stypes, myStable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(131, 2);

    				if (!s && !r.isVoid())
    					error((id!=null?id.Line:0), "function '" + (id!=null?id.Text:null) + "' does not return");
    			

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(135, 1);
    	} finally { DebugExitRule(GrammarFileName, "function"); }
    	return;

    }
    // $ANTLR end "function"


    protected virtual void Enter_parameters() {}
    protected virtual void Leave_parameters() {}

    // $ANTLR start "parameters"
    // GenericEvilTreeParser.g:137:1: parameters[StructTypes stypes,SymbolTable stable, List<Type> sparams] : ^( PARAMS ( param_decl[stypes, stable, sparams] )* ) ;
    [GrammarRule("parameters")]
    private void parameters(StructTypes stypes, SymbolTable stable, List<Type> sparams)
    {

    	try { DebugEnterRule(GrammarFileName, "parameters");
    	DebugLocation(137, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:138:2: ( ^( PARAMS ( param_decl[stypes, stable, sparams] )* ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:138:4: ^( PARAMS ( param_decl[stypes, stable, sparams] )* )
    		{
    		DebugLocation(138, 4);
    		DebugLocation(138, 6);
    		Match(input,PARAMS,Follow._PARAMS_in_parameters474); 

    		if (input.LA(1) == TokenTypes.Down)
    		{
    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(138, 13);
    			// GenericEvilTreeParser.g:138:13: ( param_decl[stypes, stable, sparams] )*
    			try { DebugEnterSubRule(9);
    			while (true)
    			{
    				int alt9=2;
    				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
    				int LA9_0 = input.LA(1);

    				if ((LA9_0==DECL))
    				{
    					alt9=1;
    				}


    				} finally { DebugExitDecision(9); }
    				switch ( alt9 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// GenericEvilTreeParser.g:138:13: param_decl[stypes, stable, sparams]
    					{
    					DebugLocation(138, 13);
    					PushFollow(Follow._param_decl_in_parameters476);
    					param_decl(stypes, stable, sparams);
    					PopFollow();


    					}
    					break;

    				default:
    					goto loop9;
    				}
    			}

    			loop9:
    				;

    			} finally { DebugExitSubRule(9); }


    			Match(input, TokenTypes.Up, null); 
    		}

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(139, 1);
    	} finally { DebugExitRule(GrammarFileName, "parameters"); }
    	return;

    }
    // $ANTLR end "parameters"


    protected virtual void Enter_param_decl() {}
    protected virtual void Leave_param_decl() {}

    // $ANTLR start "param_decl"
    // GenericEvilTreeParser.g:141:1: param_decl[StructTypes stypes, SymbolTable stable, List<Type> sparams] : ^( DECL ^( TYPE tt= type[stypes] ) id= ID ) ;
    [GrammarRule("param_decl")]
    private void param_decl(StructTypes stypes, SymbolTable stable, List<Type> sparams)
    {

        CommonTree id=null;
        Type tt = default(Type);

    	try { DebugEnterRule(GrammarFileName, "param_decl");
    	DebugLocation(141, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:142:4: ( ^( DECL ^( TYPE tt= type[stypes] ) id= ID ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:142:7: ^( DECL ^( TYPE tt= type[stypes] ) id= ID )
    		{
    		DebugLocation(142, 7);
    		DebugLocation(142, 9);
    		Match(input,DECL,Follow._DECL_in_param_decl496); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(142, 14);
    		DebugLocation(142, 16);
    		Match(input,TYPE,Follow._TYPE_in_param_decl499); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(142, 23);
    		PushFollow(Follow._type_in_param_decl503);
    		tt=type(stypes);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(142, 40);
    		id=(CommonTree)Match(input,ID,Follow._ID_in_param_decl509); 

    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(143, 3);

    		  	if (stable.redef((id!=null?id.Text:null)))
    		  	{
    		  		error((id!=null?id.Line:0), "redefinition of parameter '" + id + "'");
    		  	}
    		  	stable.putFormal((id!=null?id.Text:null), tt);
    		  	sparams.Add(tt);
    		  

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(151, 3);
    	} finally { DebugExitRule(GrammarFileName, "param_decl"); }
    	return;

    }
    // $ANTLR end "param_decl"


    protected virtual void Enter_return_type() {}
    protected virtual void Leave_return_type() {}

    // $ANTLR start "return_type"
    // GenericEvilTreeParser.g:153:1: return_type[StructTypes stypes] returns [Type retT = null] : (t= type[stypes] | VOID );
    [GrammarRule("return_type")]
    private Type return_type(StructTypes stypes)
    {

        Type retT =  null;

        Type t = default(Type);

    	try { DebugEnterRule(GrammarFileName, "return_type");
    	DebugLocation(153, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:154:2: (t= type[stypes] | VOID )
    		int alt10=2;
    		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
    		int LA10_0 = input.LA(1);

    		if (((LA10_0>=STRUCT && LA10_0<=BOOL)))
    		{
    			alt10=1;
    		}
    		else if ((LA10_0==VOID))
    		{
    			alt10=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(10); }
    		switch (alt10)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:154:4: t= type[stypes]
    			{
    			DebugLocation(154, 5);
    			PushFollow(Follow._type_in_return_type534);
    			t=type(stypes);
    			PopFollow();

    			DebugLocation(154, 18);
    			retT = t;

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:155:4: VOID
    			{
    			DebugLocation(155, 4);
    			Match(input,VOID,Follow._VOID_in_return_type542); 
    			DebugLocation(155, 9);
    			retT = Type.voidType(); 

    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(156, 1);
    	} finally { DebugExitRule(GrammarFileName, "return_type"); }
    	return retT;

    }
    // $ANTLR end "return_type"


    protected virtual void Enter_statement() {}
    protected virtual void Leave_statement() {}

    // $ANTLR start "statement"
    // GenericEvilTreeParser.g:158:1: statement[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : (s= block[stypes,stable] | s= assignment[stypes,stable] | s= print[stypes,stable] | s= read[stypes,stable] | s= conditional[stypes,stable] | s= loop[stypes,stable] | s= delete[stypes,stable] | s= ret[stypes,stable] | s= invocation[stypes,stable] );
    [GrammarRule("statement")]
    private bool statement(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        bool s = default(bool);

    	try { DebugEnterRule(GrammarFileName, "statement");
    	DebugLocation(158, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:159:2: (s= block[stypes,stable] | s= assignment[stypes,stable] | s= print[stypes,stable] | s= read[stypes,stable] | s= conditional[stypes,stable] | s= loop[stypes,stable] | s= delete[stypes,stable] | s= ret[stypes,stable] | s= invocation[stypes,stable] )
    		int alt11=9;
    		try { DebugEnterDecision(11, decisionCanBacktrack[11]);
    		switch (input.LA(1))
    		{
    		case BLOCK:
    			{
    			alt11=1;
    			}
    			break;
    		case ASSIGN:
    			{
    			alt11=2;
    			}
    			break;
    		case PRINT:
    			{
    			alt11=3;
    			}
    			break;
    		case READ:
    			{
    			alt11=4;
    			}
    			break;
    		case IF:
    			{
    			alt11=5;
    			}
    			break;
    		case WHILE:
    			{
    			alt11=6;
    			}
    			break;
    		case DELETE:
    			{
    			alt11=7;
    			}
    			break;
    		case RETURN:
    			{
    			alt11=8;
    			}
    			break;
    		case INVOKE:
    			{
    			alt11=9;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(11); }
    		switch (alt11)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:159:4: s= block[stypes,stable]
    			{
    			DebugLocation(159, 5);
    			PushFollow(Follow._block_in_statement562);
    			s=block(stypes, stable);
    			PopFollow();

    			DebugLocation(159, 27);
    			 doesRet = s; 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:160:4: s= assignment[stypes,stable]
    			{
    			DebugLocation(160, 5);
    			PushFollow(Follow._assignment_in_statement572);
    			s=assignment(stypes, stable);
    			PopFollow();

    			DebugLocation(160, 32);
    			 doesRet = s; 

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// GenericEvilTreeParser.g:161:4: s= print[stypes,stable]
    			{
    			DebugLocation(161, 5);
    			PushFollow(Follow._print_in_statement582);
    			s=print(stypes, stable);
    			PopFollow();

    			DebugLocation(161, 27);
    			 doesRet = s; 

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// GenericEvilTreeParser.g:162:4: s= read[stypes,stable]
    			{
    			DebugLocation(162, 5);
    			PushFollow(Follow._read_in_statement592);
    			s=read(stypes, stable);
    			PopFollow();

    			DebugLocation(162, 26);
    			 doesRet = s; 

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// GenericEvilTreeParser.g:163:4: s= conditional[stypes,stable]
    			{
    			DebugLocation(163, 5);
    			PushFollow(Follow._conditional_in_statement602);
    			s=conditional(stypes, stable);
    			PopFollow();

    			DebugLocation(163, 33);
    			 doesRet = s; 

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// GenericEvilTreeParser.g:164:4: s= loop[stypes,stable]
    			{
    			DebugLocation(164, 5);
    			PushFollow(Follow._loop_in_statement612);
    			s=loop(stypes, stable);
    			PopFollow();

    			DebugLocation(164, 26);
    			 doesRet = s; 

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// GenericEvilTreeParser.g:165:4: s= delete[stypes,stable]
    			{
    			DebugLocation(165, 5);
    			PushFollow(Follow._delete_in_statement622);
    			s=delete(stypes, stable);
    			PopFollow();

    			DebugLocation(165, 28);
    			 doesRet = s; 

    			}
    			break;
    		case 8:
    			DebugEnterAlt(8);
    			// GenericEvilTreeParser.g:166:4: s= ret[stypes,stable]
    			{
    			DebugLocation(166, 5);
    			PushFollow(Follow._ret_in_statement632);
    			s=ret(stypes, stable);
    			PopFollow();

    			DebugLocation(166, 25);
    			 doesRet = s; 

    			}
    			break;
    		case 9:
    			DebugEnterAlt(9);
    			// GenericEvilTreeParser.g:167:4: s= invocation[stypes,stable]
    			{
    			DebugLocation(167, 5);
    			PushFollow(Follow._invocation_in_statement642);
    			s=invocation(stypes, stable);
    			PopFollow();

    			DebugLocation(167, 32);
    			 doesRet = s; 

    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(168, 1);
    	} finally { DebugExitRule(GrammarFileName, "statement"); }
    	return doesRet;

    }
    // $ANTLR end "statement"


    protected virtual void Enter_block() {}
    protected virtual void Leave_block() {}

    // $ANTLR start "block"
    // GenericEvilTreeParser.g:170:1: block[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( BLOCK s= statement_list[stypes,stable] ) ;
    [GrammarRule("block")]
    private bool block(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        bool s = default(bool);

    	try { DebugEnterRule(GrammarFileName, "block");
    	DebugLocation(170, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:171:2: ( ^( BLOCK s= statement_list[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:171:4: ^( BLOCK s= statement_list[stypes,stable] )
    		{
    		DebugLocation(171, 4);
    		DebugLocation(171, 6);
    		Match(input,BLOCK,Follow._BLOCK_in_block662); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(171, 13);
    		PushFollow(Follow._statement_list_in_block666);
    		s=statement_list(stypes, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(171, 45);
    		 doesRet = s; 

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(172, 1);
    	} finally { DebugExitRule(GrammarFileName, "block"); }
    	return doesRet;

    }
    // $ANTLR end "block"


    protected virtual void Enter_statement_list() {}
    protected virtual void Leave_statement_list() {}

    // $ANTLR start "statement_list"
    // GenericEvilTreeParser.g:174:1: statement_list[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( STMTS (s= statement[stypes,stable] )* ) ;
    [GrammarRule("statement_list")]
    private bool statement_list(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        bool s = default(bool);

    	try { DebugEnterRule(GrammarFileName, "statement_list");
    	DebugLocation(174, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:175:2: ( ^( STMTS (s= statement[stypes,stable] )* ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:175:4: ^( STMTS (s= statement[stypes,stable] )* )
    		{
    		DebugLocation(175, 4);
    		DebugLocation(175, 6);
    		Match(input,STMTS,Follow._STMTS_in_statement_list687); 

    		if (input.LA(1) == TokenTypes.Down)
    		{
    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(175, 12);
    			// GenericEvilTreeParser.g:175:12: (s= statement[stypes,stable] )*
    			try { DebugEnterSubRule(12);
    			while (true)
    			{
    				int alt12=2;
    				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
    				int LA12_0 = input.LA(1);

    				if ((LA12_0==PRINT||(LA12_0>=READ && LA12_0<=IF)||(LA12_0>=WHILE && LA12_0<=RETURN)||LA12_0==BLOCK||LA12_0==INVOKE||LA12_0==ASSIGN))
    				{
    					alt12=1;
    				}


    				} finally { DebugExitDecision(12); }
    				switch ( alt12 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// GenericEvilTreeParser.g:175:13: s= statement[stypes,stable]
    					{
    					DebugLocation(175, 14);
    					PushFollow(Follow._statement_in_statement_list692);
    					s=statement(stypes, stable);
    					PopFollow();

    					DebugLocation(176, 3);

    								if (s)
    									doesRet = true;
    							

    					}
    					break;

    				default:
    					goto loop12;
    				}
    			}

    			loop12:
    				;

    			} finally { DebugExitSubRule(12); }


    			Match(input, TokenTypes.Up, null); 
    		}

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(181, 1);
    	} finally { DebugExitRule(GrammarFileName, "statement_list"); }
    	return doesRet;

    }
    // $ANTLR end "statement_list"


    protected virtual void Enter_assignment() {}
    protected virtual void Leave_assignment() {}

    // $ANTLR start "assignment"
    // GenericEvilTreeParser.g:183:1: assignment[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( ASSIGN expression[stypes,stable] lvalue[stypes,stable] ) ;
    [GrammarRule("assignment")]
    private bool assignment(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

    	try { DebugEnterRule(GrammarFileName, "assignment");
    	DebugLocation(183, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:184:2: ( ^( ASSIGN expression[stypes,stable] lvalue[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:184:4: ^( ASSIGN expression[stypes,stable] lvalue[stypes,stable] )
    		{
    		DebugLocation(184, 4);
    		DebugLocation(184, 6);
    		Match(input,ASSIGN,Follow._ASSIGN_in_assignment719); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(184, 13);
    		PushFollow(Follow._expression_in_assignment721);
    		expression(stypes, stable);
    		PopFollow();

    		DebugLocation(184, 39);
    		PushFollow(Follow._lvalue_in_assignment724);
    		lvalue(stypes, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(185, 1);
    	} finally { DebugExitRule(GrammarFileName, "assignment"); }
    	return doesRet;

    }
    // $ANTLR end "assignment"


    protected virtual void Enter_print() {}
    protected virtual void Leave_print() {}

    // $ANTLR start "print"
    // GenericEvilTreeParser.g:187:1: print[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( PRINT expression[stypes,stable] ( ENDL )? ) ;
    [GrammarRule("print")]
    private bool print(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

    	try { DebugEnterRule(GrammarFileName, "print");
    	DebugLocation(187, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:188:2: ( ^( PRINT expression[stypes,stable] ( ENDL )? ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:188:4: ^( PRINT expression[stypes,stable] ( ENDL )? )
    		{
    		DebugLocation(188, 4);
    		DebugLocation(188, 6);
    		Match(input,PRINT,Follow._PRINT_in_print743); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(188, 12);
    		PushFollow(Follow._expression_in_print745);
    		expression(stypes, stable);
    		PopFollow();

    		DebugLocation(188, 38);
    		// GenericEvilTreeParser.g:188:38: ( ENDL )?
    		int alt13=2;
    		try { DebugEnterSubRule(13);
    		try { DebugEnterDecision(13, decisionCanBacktrack[13]);
    		int LA13_0 = input.LA(1);

    		if ((LA13_0==ENDL))
    		{
    			alt13=1;
    		}
    		} finally { DebugExitDecision(13); }
    		switch (alt13)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:188:39: ENDL
    			{
    			DebugLocation(188, 39);
    			Match(input,ENDL,Follow._ENDL_in_print749); 

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(13); }


    		Match(input, TokenTypes.Up, null); 

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(189, 1);
    	} finally { DebugExitRule(GrammarFileName, "print"); }
    	return doesRet;

    }
    // $ANTLR end "print"


    protected virtual void Enter_read() {}
    protected virtual void Leave_read() {}

    // $ANTLR start "read"
    // GenericEvilTreeParser.g:191:1: read[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( READ lvalue[stypes,stable] ) ;
    [GrammarRule("read")]
    private bool read(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

    	try { DebugEnterRule(GrammarFileName, "read");
    	DebugLocation(191, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:192:2: ( ^( READ lvalue[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:192:4: ^( READ lvalue[stypes,stable] )
    		{
    		DebugLocation(192, 4);
    		DebugLocation(192, 6);
    		Match(input,READ,Follow._READ_in_read769); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(192, 11);
    		PushFollow(Follow._lvalue_in_read771);
    		lvalue(stypes, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(193, 1);
    	} finally { DebugExitRule(GrammarFileName, "read"); }
    	return doesRet;

    }
    // $ANTLR end "read"


    protected virtual void Enter_conditional() {}
    protected virtual void Leave_conditional() {}

    // $ANTLR start "conditional"
    // GenericEvilTreeParser.g:195:1: conditional[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^(w= IF e= expression[stypes,stable] b1= block[stypes,stable] (b2= block[stypes,stable] )? ) ;
    [GrammarRule("conditional")]
    private bool conditional(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        CommonTree w=null;
        Type e = default(Type);
        bool b1 = default(bool);
        bool b2 = default(bool);

    	try { DebugEnterRule(GrammarFileName, "conditional");
    	DebugLocation(195, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:196:2: ( ^(w= IF e= expression[stypes,stable] b1= block[stypes,stable] (b2= block[stypes,stable] )? ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:196:4: ^(w= IF e= expression[stypes,stable] b1= block[stypes,stable] (b2= block[stypes,stable] )? )
    		{
    		DebugLocation(196, 4);
    		DebugLocation(196, 7);
    		w=(CommonTree)Match(input,IF,Follow._IF_in_conditional792); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(196, 12);
    		PushFollow(Follow._expression_in_conditional796);
    		e=expression(stypes, stable);
    		PopFollow();

    		DebugLocation(196, 41);
    		PushFollow(Follow._block_in_conditional801);
    		b1=block(stypes, stable);
    		PopFollow();

    		DebugLocation(196, 63);
    		// GenericEvilTreeParser.g:196:63: (b2= block[stypes,stable] )?
    		int alt14=2;
    		try { DebugEnterSubRule(14);
    		try { DebugEnterDecision(14, decisionCanBacktrack[14]);
    		int LA14_0 = input.LA(1);

    		if ((LA14_0==BLOCK))
    		{
    			alt14=1;
    		}
    		} finally { DebugExitDecision(14); }
    		switch (alt14)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:196:64: b2= block[stypes,stable]
    			{
    			DebugLocation(196, 66);
    			PushFollow(Follow._block_in_conditional807);
    			b2=block(stypes, stable);
    			PopFollow();


    			}
    			break;

    		}
    		} finally { DebugExitSubRule(14); }


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(197, 3);

    					if (!e.isBool())
    					{
    						error((w!=null?w.Line:0), "if needs a bool guard");
    					}
    					doesRet = b1 && b2;	
    				

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(204, 1);
    	} finally { DebugExitRule(GrammarFileName, "conditional"); }
    	return doesRet;

    }
    // $ANTLR end "conditional"


    protected virtual void Enter_loop() {}
    protected virtual void Leave_loop() {}

    // $ANTLR start "loop"
    // GenericEvilTreeParser.g:206:1: loop[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^(w= WHILE guard= expression[stypes,stable] b= block[stypes,stable] expression[stypes,stable] ) ;
    [GrammarRule("loop")]
    private bool loop(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        CommonTree w=null;
        Type guard = default(Type);
        bool b = default(bool);

    	try { DebugEnterRule(GrammarFileName, "loop");
    	DebugLocation(206, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:207:2: ( ^(w= WHILE guard= expression[stypes,stable] b= block[stypes,stable] expression[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:207:4: ^(w= WHILE guard= expression[stypes,stable] b= block[stypes,stable] expression[stypes,stable] )
    		{
    		DebugLocation(207, 4);
    		DebugLocation(207, 7);
    		w=(CommonTree)Match(input,WHILE,Follow._WHILE_in_loop834); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(207, 19);
    		PushFollow(Follow._expression_in_loop838);
    		guard=expression(stypes, stable);
    		PopFollow();

    		DebugLocation(207, 47);
    		PushFollow(Follow._block_in_loop843);
    		b=block(stypes, stable);
    		PopFollow();

    		DebugLocation(207, 69);
    		PushFollow(Follow._expression_in_loop846);
    		expression(stypes, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(208, 3);

    					if (!guard.isBool())
    					{
    						error((w!=null?w.Line:0), "while needs a bool guard");
    					}
    				

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(214, 1);
    	} finally { DebugExitRule(GrammarFileName, "loop"); }
    	return doesRet;

    }
    // $ANTLR end "loop"


    protected virtual void Enter_delete() {}
    protected virtual void Leave_delete() {}

    // $ANTLR start "delete"
    // GenericEvilTreeParser.g:216:1: delete[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^(d= DELETE e= expression[stypes,stable] ) ;
    [GrammarRule("delete")]
    private bool delete(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        CommonTree d=null;
        Type e = default(Type);

    	try { DebugEnterRule(GrammarFileName, "delete");
    	DebugLocation(216, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:217:2: ( ^(d= DELETE e= expression[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:217:4: ^(d= DELETE e= expression[stypes,stable] )
    		{
    		DebugLocation(217, 4);
    		DebugLocation(217, 7);
    		d=(CommonTree)Match(input,DELETE,Follow._DELETE_in_delete871); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(217, 16);
    		PushFollow(Follow._expression_in_delete875);
    		e=expression(stypes, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(218, 3);

    					if (!e.isStruct())
    					{
    						error((d!=null?d.Line:0), "delete needs a struct");
    					}
    				

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(224, 1);
    	} finally { DebugExitRule(GrammarFileName, "delete"); }
    	return doesRet;

    }
    // $ANTLR end "delete"


    protected virtual void Enter_ret() {}
    protected virtual void Leave_ret() {}

    // $ANTLR start "ret"
    // GenericEvilTreeParser.g:226:1: ret[StructTypes stypes,SymbolTable stable] returns [bool doesRet = true] : ^(r= RETURN (e= expression[stypes,stable] )? ) ;
    [GrammarRule("ret")]
    private bool ret(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  true;

        CommonTree r=null;
        Type e = default(Type);

    	try { DebugEnterRule(GrammarFileName, "ret");
    	DebugLocation(226, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:227:2: ( ^(r= RETURN (e= expression[stypes,stable] )? ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:227:4: ^(r= RETURN (e= expression[stypes,stable] )? )
    		{
    		DebugLocation(227, 4);
    		DebugLocation(227, 7);
    		r=(CommonTree)Match(input,RETURN,Follow._RETURN_in_ret901); 

    		if (input.LA(1) == TokenTypes.Down)
    		{
    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(227, 15);
    			// GenericEvilTreeParser.g:227:15: (e= expression[stypes,stable] )?
    			int alt15=2;
    			try { DebugEnterSubRule(15);
    			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
    			int LA15_0 = input.LA(1);

    			if (((LA15_0>=TRUE && LA15_0<=NULL)||LA15_0==INVOKE||LA15_0==NEG||(LA15_0>=DOT && LA15_0<=INTEGER)))
    			{
    				alt15=1;
    			}
    			} finally { DebugExitDecision(15); }
    			switch (alt15)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// GenericEvilTreeParser.g:227:16: e= expression[stypes,stable]
    				{
    				DebugLocation(227, 17);
    				PushFollow(Follow._expression_in_ret906);
    				e=expression(stypes, stable);
    				PopFollow();


    				}
    				break;

    			}
    			} finally { DebugExitSubRule(15); }


    			Match(input, TokenTypes.Up, null); 
    		}
    		DebugLocation(228, 3);

    					if (e==null)
    					{
    						if (!stable.returnType.isVoid())
    							error((r!=null?r.Line:0), "missing return value");
    					}
    					else
    					{
    						if (!stable.returnType.canAssign(e))
    							error((r!=null?r.Line:0), "return type mis-match");
    					}
    				

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(240, 1);
    	} finally { DebugExitRule(GrammarFileName, "ret"); }
    	return doesRet;

    }
    // $ANTLR end "ret"


    protected virtual void Enter_invocation() {}
    protected virtual void Leave_invocation() {}

    // $ANTLR start "invocation"
    // GenericEvilTreeParser.g:242:1: invocation[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( INVOKE id= ID args= arguments[stypes,stable] ) ;
    [GrammarRule("invocation")]
    private bool invocation(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        CommonTree id=null;
        List<Type> args = default(List<Type>);

    	try { DebugEnterRule(GrammarFileName, "invocation");
    	DebugLocation(242, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:243:2: ( ^( INVOKE id= ID args= arguments[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:243:4: ^( INVOKE id= ID args= arguments[stypes,stable] )
    		{
    		DebugLocation(243, 4);
    		DebugLocation(243, 6);
    		Match(input,INVOKE,Follow._INVOKE_in_invocation931); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(243, 15);
    		id=(CommonTree)Match(input,ID,Follow._ID_in_invocation935); 
    		DebugLocation(243, 23);
    		PushFollow(Follow._arguments_in_invocation939);
    		args=arguments(stypes, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(243, 50);
    		 getFun(stable, id,args); 

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(244, 1);
    	} finally { DebugExitRule(GrammarFileName, "invocation"); }
    	return doesRet;

    }
    // $ANTLR end "invocation"


    protected virtual void Enter_lvalue() {}
    protected virtual void Leave_lvalue() {}

    // $ANTLR start "lvalue"
    // GenericEvilTreeParser.g:246:1: lvalue[StructTypes stypes,SymbolTable stable] returns [Type t = null] : ( ^( DOT s= lvalue[stypes,stable] id= ID ) | id= ID );
    [GrammarRule("lvalue")]
    private Type lvalue(StructTypes stypes, SymbolTable stable)
    {

        Type t =  null;

        CommonTree id=null;
        Type s = default(Type);

    	try { DebugEnterRule(GrammarFileName, "lvalue");
    	DebugLocation(246, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:247:2: ( ^( DOT s= lvalue[stypes,stable] id= ID ) | id= ID )
    		int alt16=2;
    		try { DebugEnterDecision(16, decisionCanBacktrack[16]);
    		int LA16_0 = input.LA(1);

    		if ((LA16_0==DOT))
    		{
    			alt16=1;
    		}
    		else if ((LA16_0==ID))
    		{
    			alt16=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 16, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(16); }
    		switch (alt16)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:247:4: ^( DOT s= lvalue[stypes,stable] id= ID )
    			{
    			DebugLocation(247, 4);
    			DebugLocation(247, 6);
    			Match(input,DOT,Follow._DOT_in_lvalue960); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(247, 11);
    			PushFollow(Follow._lvalue_in_lvalue964);
    			s=lvalue(stypes, stable);
    			PopFollow();

    			DebugLocation(247, 36);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_lvalue969); 

    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(247, 41);
    			 t = getFieldType(stypes, s, id); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:248:4: id= ID
    			{
    			DebugLocation(248, 6);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_lvalue979); 
    			DebugLocation(248, 10);
    			 t = getVar(stable, id); 

    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(249, 1);
    	} finally { DebugExitRule(GrammarFileName, "lvalue"); }
    	return t;

    }
    // $ANTLR end "lvalue"


    protected virtual void Enter_expression() {}
    protected virtual void Leave_expression() {}

    // $ANTLR start "expression"
    // GenericEvilTreeParser.g:251:1: expression[StructTypes stypes,SymbolTable stable] returns [Type t = null] : ( ^(a= AND e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= OR e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= EQ e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= LT e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= GT e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= NE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= LE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= GE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= PLUS e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= MINUS e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= TIMES e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= DIVIDE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= NOT e= expression[stypes,stable] ) | ^(a= NEG e= expression[stypes,stable] ) | s= selector[stypes,stable] );
    [GrammarRule("expression")]
    private Type expression(StructTypes stypes, SymbolTable stable)
    {

        Type t =  null;

        CommonTree a=null;
        Type e1 = default(Type);
        Type e2 = default(Type);
        Type e = default(Type);
        Type s = default(Type);

    	try { DebugEnterRule(GrammarFileName, "expression");
    	DebugLocation(251, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:252:2: ( ^(a= AND e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= OR e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= EQ e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= LT e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= GT e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= NE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= LE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= GE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= PLUS e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= MINUS e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= TIMES e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= DIVIDE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= NOT e= expression[stypes,stable] ) | ^(a= NEG e= expression[stypes,stable] ) | s= selector[stypes,stable] )
    		int alt17=15;
    		try { DebugEnterDecision(17, decisionCanBacktrack[17]);
    		switch (input.LA(1))
    		{
    		case AND:
    			{
    			alt17=1;
    			}
    			break;
    		case OR:
    			{
    			alt17=2;
    			}
    			break;
    		case EQ:
    			{
    			alt17=3;
    			}
    			break;
    		case LT:
    			{
    			alt17=4;
    			}
    			break;
    		case GT:
    			{
    			alt17=5;
    			}
    			break;
    		case NE:
    			{
    			alt17=6;
    			}
    			break;
    		case LE:
    			{
    			alt17=7;
    			}
    			break;
    		case GE:
    			{
    			alt17=8;
    			}
    			break;
    		case PLUS:
    			{
    			alt17=9;
    			}
    			break;
    		case MINUS:
    			{
    			alt17=10;
    			}
    			break;
    		case TIMES:
    			{
    			alt17=11;
    			}
    			break;
    		case DIVIDE:
    			{
    			alt17=12;
    			}
    			break;
    		case NOT:
    			{
    			alt17=13;
    			}
    			break;
    		case NEG:
    			{
    			alt17=14;
    			}
    			break;
    		case TRUE:
    		case FALSE:
    		case NEW:
    		case NULL:
    		case INVOKE:
    		case DOT:
    		case ID:
    		case INTEGER:
    			{
    			alt17=15;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 17, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(17); }
    		switch (alt17)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:252:4: ^(a= AND e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(252, 4);
    			DebugLocation(252, 7);
    			a=(CommonTree)Match(input,AND,Follow._AND_in_expression1000); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(252, 14);
    			PushFollow(Follow._expression_in_expression1004);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(252, 43);
    			PushFollow(Follow._expression_in_expression1009);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(252, 71);
    			ensureBool((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:253:4: ^(a= OR e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(253, 4);
    			DebugLocation(253, 7);
    			a=(CommonTree)Match(input,OR,Follow._OR_in_expression1021); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(253, 13);
    			PushFollow(Follow._expression_in_expression1025);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(253, 42);
    			PushFollow(Follow._expression_in_expression1030);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(253, 70);
    			ensureBool((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// GenericEvilTreeParser.g:254:4: ^(a= EQ e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(254, 4);
    			DebugLocation(254, 7);
    			a=(CommonTree)Match(input,EQ,Follow._EQ_in_expression1042); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(254, 13);
    			PushFollow(Follow._expression_in_expression1046);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(254, 42);
    			PushFollow(Follow._expression_in_expression1051);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(254, 70);
    			ensureStructOrInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// GenericEvilTreeParser.g:255:4: ^(a= LT e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(255, 4);
    			DebugLocation(255, 7);
    			a=(CommonTree)Match(input,LT,Follow._LT_in_expression1063); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(255, 13);
    			PushFollow(Follow._expression_in_expression1067);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(255, 42);
    			PushFollow(Follow._expression_in_expression1072);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(255, 70);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// GenericEvilTreeParser.g:256:4: ^(a= GT e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(256, 4);
    			DebugLocation(256, 7);
    			a=(CommonTree)Match(input,GT,Follow._GT_in_expression1084); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(256, 13);
    			PushFollow(Follow._expression_in_expression1088);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(256, 42);
    			PushFollow(Follow._expression_in_expression1093);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(256, 70);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// GenericEvilTreeParser.g:257:4: ^(a= NE e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(257, 4);
    			DebugLocation(257, 7);
    			a=(CommonTree)Match(input,NE,Follow._NE_in_expression1105); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(257, 13);
    			PushFollow(Follow._expression_in_expression1109);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(257, 42);
    			PushFollow(Follow._expression_in_expression1114);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(257, 70);
    			ensureStructOrInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// GenericEvilTreeParser.g:258:4: ^(a= LE e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(258, 4);
    			DebugLocation(258, 7);
    			a=(CommonTree)Match(input,LE,Follow._LE_in_expression1126); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(258, 13);
    			PushFollow(Follow._expression_in_expression1130);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(258, 42);
    			PushFollow(Follow._expression_in_expression1135);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(258, 70);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 8:
    			DebugEnterAlt(8);
    			// GenericEvilTreeParser.g:259:4: ^(a= GE e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(259, 4);
    			DebugLocation(259, 7);
    			a=(CommonTree)Match(input,GE,Follow._GE_in_expression1147); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(259, 13);
    			PushFollow(Follow._expression_in_expression1151);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(259, 42);
    			PushFollow(Follow._expression_in_expression1156);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(259, 70);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 9:
    			DebugEnterAlt(9);
    			// GenericEvilTreeParser.g:260:4: ^(a= PLUS e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(260, 4);
    			DebugLocation(260, 7);
    			a=(CommonTree)Match(input,PLUS,Follow._PLUS_in_expression1168); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(260, 15);
    			PushFollow(Follow._expression_in_expression1172);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(260, 44);
    			PushFollow(Follow._expression_in_expression1177);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(260, 72);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.intType();

    			}
    			break;
    		case 10:
    			DebugEnterAlt(10);
    			// GenericEvilTreeParser.g:261:4: ^(a= MINUS e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(261, 4);
    			DebugLocation(261, 7);
    			a=(CommonTree)Match(input,MINUS,Follow._MINUS_in_expression1189); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(261, 16);
    			PushFollow(Follow._expression_in_expression1193);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(261, 45);
    			PushFollow(Follow._expression_in_expression1198);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(261, 73);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.intType();

    			}
    			break;
    		case 11:
    			DebugEnterAlt(11);
    			// GenericEvilTreeParser.g:262:4: ^(a= TIMES e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(262, 4);
    			DebugLocation(262, 7);
    			a=(CommonTree)Match(input,TIMES,Follow._TIMES_in_expression1210); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(262, 16);
    			PushFollow(Follow._expression_in_expression1214);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(262, 45);
    			PushFollow(Follow._expression_in_expression1219);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(262, 73);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.intType();

    			}
    			break;
    		case 12:
    			DebugEnterAlt(12);
    			// GenericEvilTreeParser.g:263:4: ^(a= DIVIDE e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(263, 4);
    			DebugLocation(263, 7);
    			a=(CommonTree)Match(input,DIVIDE,Follow._DIVIDE_in_expression1231); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(263, 17);
    			PushFollow(Follow._expression_in_expression1235);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(263, 46);
    			PushFollow(Follow._expression_in_expression1240);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(263, 74);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.intType();

    			}
    			break;
    		case 13:
    			DebugEnterAlt(13);
    			// GenericEvilTreeParser.g:264:4: ^(a= NOT e= expression[stypes,stable] )
    			{
    			DebugLocation(264, 4);
    			DebugLocation(264, 7);
    			a=(CommonTree)Match(input,NOT,Follow._NOT_in_expression1252); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(264, 13);
    			PushFollow(Follow._expression_in_expression1256);
    			e=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(264, 41);
    			ensureBool((a!=null?a.Line:0), e, Type.boolType()); t = Type.boolType();

    			}
    			break;
    		case 14:
    			DebugEnterAlt(14);
    			// GenericEvilTreeParser.g:265:4: ^(a= NEG e= expression[stypes,stable] )
    			{
    			DebugLocation(265, 4);
    			DebugLocation(265, 7);
    			a=(CommonTree)Match(input,NEG,Follow._NEG_in_expression1268); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(265, 13);
    			PushFollow(Follow._expression_in_expression1272);
    			e=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(265, 41);
    			ensureInt((a!=null?a.Line:0), e, Type.intType()); t = Type.intType();

    			}
    			break;
    		case 15:
    			DebugEnterAlt(15);
    			// GenericEvilTreeParser.g:266:4: s= selector[stypes,stable]
    			{
    			DebugLocation(266, 5);
    			PushFollow(Follow._selector_in_expression1283);
    			s=selector(stypes, stable);
    			PopFollow();

    			DebugLocation(266, 30);
    			 t = s; 

    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(267, 1);
    	} finally { DebugExitRule(GrammarFileName, "expression"); }
    	return t;

    }
    // $ANTLR end "expression"


    protected virtual void Enter_selector() {}
    protected virtual void Leave_selector() {}

    // $ANTLR start "selector"
    // GenericEvilTreeParser.g:269:1: selector[StructTypes stypes,SymbolTable stable] returns [Type t = null] : ( ^( DOT s= selector[stypes,stable] id= ID ) | f= factor[stypes,stable] );
    [GrammarRule("selector")]
    private Type selector(StructTypes stypes, SymbolTable stable)
    {

        Type t =  null;

        CommonTree id=null;
        Type s = default(Type);
        Type f = default(Type);

    	try { DebugEnterRule(GrammarFileName, "selector");
    	DebugLocation(269, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:270:2: ( ^( DOT s= selector[stypes,stable] id= ID ) | f= factor[stypes,stable] )
    		int alt18=2;
    		try { DebugEnterDecision(18, decisionCanBacktrack[18]);
    		int LA18_0 = input.LA(1);

    		if ((LA18_0==DOT))
    		{
    			alt18=1;
    		}
    		else if (((LA18_0>=TRUE && LA18_0<=NULL)||LA18_0==INVOKE||(LA18_0>=ID && LA18_0<=INTEGER)))
    		{
    			alt18=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 18, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(18); }
    		switch (alt18)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:270:4: ^( DOT s= selector[stypes,stable] id= ID )
    			{
    			DebugLocation(270, 4);
    			DebugLocation(270, 6);
    			Match(input,DOT,Follow._DOT_in_selector1303); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(270, 11);
    			PushFollow(Follow._selector_in_selector1307);
    			s=selector(stypes, stable);
    			PopFollow();

    			DebugLocation(270, 38);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_selector1312); 

    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(270, 43);
    			 t = getFieldType(stypes, s, id); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:271:4: f= factor[stypes,stable]
    			{
    			DebugLocation(271, 5);
    			PushFollow(Follow._factor_in_selector1322);
    			f=factor(stypes, stable);
    			PopFollow();

    			DebugLocation(271, 28);
    			t = f;

    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(272, 1);
    	} finally { DebugExitRule(GrammarFileName, "selector"); }
    	return t;

    }
    // $ANTLR end "selector"


    protected virtual void Enter_factor() {}
    protected virtual void Leave_factor() {}

    // $ANTLR start "factor"
    // GenericEvilTreeParser.g:274:1: factor[StructTypes stypes,SymbolTable stable] returns [Type t = null] : ( ^( INVOKE id= ID args= arguments[stypes,stable] ) | id= ID | INTEGER | TRUE | FALSE | ^( NEW id= ID ) | NULL );
    [GrammarRule("factor")]
    private Type factor(StructTypes stypes, SymbolTable stable)
    {

        Type t =  null;

        CommonTree id=null;
        List<Type> args = default(List<Type>);

    	try { DebugEnterRule(GrammarFileName, "factor");
    	DebugLocation(274, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:275:2: ( ^( INVOKE id= ID args= arguments[stypes,stable] ) | id= ID | INTEGER | TRUE | FALSE | ^( NEW id= ID ) | NULL )
    		int alt19=7;
    		try { DebugEnterDecision(19, decisionCanBacktrack[19]);
    		switch (input.LA(1))
    		{
    		case INVOKE:
    			{
    			alt19=1;
    			}
    			break;
    		case ID:
    			{
    			alt19=2;
    			}
    			break;
    		case INTEGER:
    			{
    			alt19=3;
    			}
    			break;
    		case TRUE:
    			{
    			alt19=4;
    			}
    			break;
    		case FALSE:
    			{
    			alt19=5;
    			}
    			break;
    		case NEW:
    			{
    			alt19=6;
    			}
    			break;
    		case NULL:
    			{
    			alt19=7;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 19, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(19); }
    		switch (alt19)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:275:4: ^( INVOKE id= ID args= arguments[stypes,stable] )
    			{
    			DebugLocation(275, 4);
    			DebugLocation(275, 6);
    			Match(input,INVOKE,Follow._INVOKE_in_factor1342); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(275, 15);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_factor1346); 
    			DebugLocation(275, 23);
    			PushFollow(Follow._arguments_in_factor1350);
    			args=arguments(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(275, 50);
    			t = getFun(stable, id,args); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:276:4: id= ID
    			{
    			DebugLocation(276, 6);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_factor1361); 
    			DebugLocation(276, 10);
    			t = getVar(stable, id);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// GenericEvilTreeParser.g:277:4: INTEGER
    			{
    			DebugLocation(277, 4);
    			Match(input,INTEGER,Follow._INTEGER_in_factor1368); 
    			DebugLocation(277, 12);
    			t = Type.intType();

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// GenericEvilTreeParser.g:278:4: TRUE
    			{
    			DebugLocation(278, 4);
    			Match(input,TRUE,Follow._TRUE_in_factor1375); 
    			DebugLocation(278, 9);
    			t = Type.boolType();

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// GenericEvilTreeParser.g:279:4: FALSE
    			{
    			DebugLocation(279, 4);
    			Match(input,FALSE,Follow._FALSE_in_factor1382); 
    			DebugLocation(279, 9);
    			t = Type.boolType();

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// GenericEvilTreeParser.g:280:4: ^( NEW id= ID )
    			{
    			DebugLocation(280, 4);
    			DebugLocation(280, 6);
    			Match(input,NEW,Follow._NEW_in_factor1389); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(280, 12);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_factor1393); 

    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(280, 17);
    			t = getStruct(stypes, id);

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// GenericEvilTreeParser.g:281:4: NULL
    			{
    			DebugLocation(281, 4);
    			Match(input,NULL,Follow._NULL_in_factor1401); 
    			DebugLocation(281, 9);
    			t = Type.nullType();

    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(282, 1);
    	} finally { DebugExitRule(GrammarFileName, "factor"); }
    	return t;

    }
    // $ANTLR end "factor"


    protected virtual void Enter_arguments() {}
    protected virtual void Leave_arguments() {}

    // $ANTLR start "arguments"
    // GenericEvilTreeParser.g:284:1: arguments[StructTypes stypes,SymbolTable stable] returns [List<Type> ret = null] : args= arg_list[stypes,stable] ;
    [GrammarRule("arguments")]
    private List<Type> arguments(StructTypes stypes, SymbolTable stable)
    {

        List<Type> ret =  null;

        List<Type> args = default(List<Type>);

    	try { DebugEnterRule(GrammarFileName, "arguments");
    	DebugLocation(284, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:285:2: (args= arg_list[stypes,stable] )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:285:4: args= arg_list[stypes,stable]
    		{
    		DebugLocation(285, 8);
    		PushFollow(Follow._arg_list_in_arguments1421);
    		args=arg_list(stypes, stable);
    		PopFollow();

    		DebugLocation(285, 33);
    		ret = args; 

    		}

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(286, 1);
    	} finally { DebugExitRule(GrammarFileName, "arguments"); }
    	return ret;

    }
    // $ANTLR end "arguments"


    protected virtual void Enter_arg_list() {}
    protected virtual void Leave_arg_list() {}

    // $ANTLR start "arg_list"
    // GenericEvilTreeParser.g:288:1: arg_list[StructTypes stypes,SymbolTable stable] returns [List<Type> args = new List<Type>()] : ( ^( ARGS (e= expression[stypes,stable] )+ ) | ARGS );
    [GrammarRule("arg_list")]
    private List<Type> arg_list(StructTypes stypes, SymbolTable stable)
    {

        List<Type> args =  new List<Type>();

        Type e = default(Type);

    	try { DebugEnterRule(GrammarFileName, "arg_list");
    	DebugLocation(288, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:289:2: ( ^( ARGS (e= expression[stypes,stable] )+ ) | ARGS )
    		int alt21=2;
    		try { DebugEnterDecision(21, decisionCanBacktrack[21]);
    		int LA21_0 = input.LA(1);

    		if ((LA21_0==ARGS))
    		{
    			int LA21_1 = input.LA(2);

    			if ((LA21_1==DOWN))
    			{
    				alt21=1;
    			}
    			else if ((LA21_1==UP))
    			{
    				alt21=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 21, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(21); }
    		switch (alt21)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:289:4: ^( ARGS (e= expression[stypes,stable] )+ )
    			{
    			DebugLocation(289, 4);
    			DebugLocation(289, 6);
    			Match(input,ARGS,Follow._ARGS_in_arg_list1441); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(289, 11);
    			// GenericEvilTreeParser.g:289:11: (e= expression[stypes,stable] )+
    			int cnt20=0;
    			try { DebugEnterSubRule(20);
    			while (true)
    			{
    				int alt20=2;
    				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
    				int LA20_0 = input.LA(1);

    				if (((LA20_0>=TRUE && LA20_0<=NULL)||LA20_0==INVOKE||LA20_0==NEG||(LA20_0>=DOT && LA20_0<=INTEGER)))
    				{
    					alt20=1;
    				}


    				} finally { DebugExitDecision(20); }
    				switch (alt20)
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// GenericEvilTreeParser.g:289:12: e= expression[stypes,stable]
    					{
    					DebugLocation(289, 13);
    					PushFollow(Follow._expression_in_arg_list1446);
    					e=expression(stypes, stable);
    					PopFollow();

    					DebugLocation(289, 39);
    					args.Add(e);

    					}
    					break;

    				default:
    					if (cnt20 >= 1)
    						goto loop20;

    					EarlyExitException eee20 = new EarlyExitException( 20, input );
    					DebugRecognitionException(eee20);
    					throw eee20;
    				}
    				cnt20++;
    			}
    			loop20:
    				;

    			} finally { DebugExitSubRule(20); }


    			Match(input, TokenTypes.Up, null); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:290:4: ARGS
    			{
    			DebugLocation(290, 4);
    			Match(input,ARGS,Follow._ARGS_in_arg_list1457); 

    			}
    			break;

    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	}
    	finally
    	{
        }
     	DebugLocation(291, 1);
    	} finally { DebugExitRule(GrammarFileName, "arg_list"); }
    	return args;

    }
    // $ANTLR end "arg_list"

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _PROGRAM_in_program58 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _types_in_program61 = new BitSet(new ulong[]{0x0000000003000000UL});
		public static readonly BitSet _declarations_in_program64 = new BitSet(new ulong[]{0x0000000003000000UL});
		public static readonly BitSet _functions_in_program67 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _TYPES_in_types91 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _types_sub_in_types93 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _TYPES_in_types103 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRUCT_in_type_declaration127 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_type_declaration132 = new BitSet(new ulong[]{0x0000000004000000UL});
		public static readonly BitSet _nested_decl_in_type_declaration151 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _field_decl_in_nested_decl185 = new BitSet(new ulong[]{0x0000000004000002UL});
		public static readonly BitSet _type_declaration_in_types_sub207 = new BitSet(new ulong[]{0x0000000000000010UL});
		public static readonly BitSet _types_sub_in_types_sub210 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _DECL_in_field_decl238 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _TYPE_in_field_decl241 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _type_in_field_decl245 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _ID_in_field_decl251 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _INT_in_type275 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BOOL_in_type282 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRUCT_in_type290 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_type294 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _DECLS_in_declarations311 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _declaration_in_declarations313 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _decl_list_in_declaration333 = new BitSet(new ulong[]{0x0000000008000002UL});
		public static readonly BitSet _DECLLIST_in_decl_list349 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _TYPE_in_decl_list352 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _type_in_decl_list356 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _id_list_in_decl_list360 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _ID_in_id_list380 = new BitSet(new ulong[]{0x0100000000000002UL});
		public static readonly BitSet _FUNCS_in_functions401 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _function_in_functions403 = new BitSet(new ulong[]{0x0000000000000088UL});
		public static readonly BitSet _FUN_in_function425 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_function429 = new BitSet(new ulong[]{0x0000000010000000UL});
		public static readonly BitSet _parameters_in_function433 = new BitSet(new ulong[]{0x0000000020000000UL});
		public static readonly BitSet _RETTYPE_in_function437 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _return_type_in_function441 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _declarations_in_function447 = new BitSet(new ulong[]{0x0000000080000000UL});
		public static readonly BitSet _statement_list_in_function455 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _PARAMS_in_parameters474 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _param_decl_in_parameters476 = new BitSet(new ulong[]{0x0000000004000008UL});
		public static readonly BitSet _DECL_in_param_decl496 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _TYPE_in_param_decl499 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _type_in_param_decl503 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _ID_in_param_decl509 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _type_in_return_type534 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VOID_in_return_type542 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _block_in_statement562 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assignment_in_statement572 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _print_in_statement582 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _read_in_statement592 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _conditional_in_statement602 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _loop_in_statement612 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _delete_in_statement622 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ret_in_statement632 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _invocation_in_statement642 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BLOCK_in_block662 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _statement_list_in_block666 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _STMTS_in_statement_list687 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _statement_in_statement_list692 = new BitSet(new ulong[]{0x000002014001DA08UL});
		public static readonly BitSet _ASSIGN_in_assignment719 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_assignment721 = new BitSet(new ulong[]{0x0100040000000000UL});
		public static readonly BitSet _lvalue_in_assignment724 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _PRINT_in_print743 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_print745 = new BitSet(new ulong[]{0x0000000000000408UL});
		public static readonly BitSet _ENDL_in_print749 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _READ_in_read769 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _lvalue_in_read771 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _IF_in_conditional792 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_conditional796 = new BitSet(new ulong[]{0x0000000040000000UL});
		public static readonly BitSet _block_in_conditional801 = new BitSet(new ulong[]{0x0000000040000008UL});
		public static readonly BitSet _block_in_conditional807 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _WHILE_in_loop834 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_loop838 = new BitSet(new ulong[]{0x0000000040000000UL});
		public static readonly BitSet _block_in_loop843 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_loop846 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _DELETE_in_delete871 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_delete875 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _RETURN_in_ret901 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_ret906 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _INVOKE_in_invocation931 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_invocation935 = new BitSet(new ulong[]{0x0000000200000000UL});
		public static readonly BitSet _arguments_in_invocation939 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _DOT_in_lvalue960 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _lvalue_in_lvalue964 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_lvalue969 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _ID_in_lvalue979 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _AND_in_expression1000 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1004 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1009 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _OR_in_expression1021 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1025 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1030 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _EQ_in_expression1042 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1046 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1051 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _LT_in_expression1063 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1067 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1072 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _GT_in_expression1084 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1088 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1093 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _NE_in_expression1105 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1109 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1114 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _LE_in_expression1126 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1130 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1135 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _GE_in_expression1147 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1151 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1156 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _PLUS_in_expression1168 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1172 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1177 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _MINUS_in_expression1189 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1193 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1198 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _TIMES_in_expression1210 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1214 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1219 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _DIVIDE_in_expression1231 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1235 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1240 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _NOT_in_expression1252 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1256 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _NEG_in_expression1268 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1272 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _selector_in_expression1283 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _DOT_in_selector1303 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _selector_in_selector1307 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_selector1312 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _factor_in_selector1322 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INVOKE_in_factor1342 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_factor1346 = new BitSet(new ulong[]{0x0000000200000000UL});
		public static readonly BitSet _arguments_in_factor1350 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _ID_in_factor1361 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INTEGER_in_factor1368 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _TRUE_in_factor1375 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FALSE_in_factor1382 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NEW_in_factor1389 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_factor1393 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _NULL_in_factor1401 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arg_list_in_arguments1421 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ARGS_in_arg_list1441 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_arg_list1446 = new BitSet(new ulong[]{0x03FFFC05001E0008UL});
		public static readonly BitSet _ARGS_in_arg_list1457 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}