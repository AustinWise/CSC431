// $ANTLR 3.3 Nov 30, 2010 12:50:56 GenericEvilTreeParser.g 2011-01-15 11:48:48

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
    // GenericEvilTreeParser.g:16:1: program[StructTypes stypes, SymbolTable stable] : ^( PROGRAM ( types[stypes] declarations[stypes, stable] functions[stypes, stable] ) ) ;
    [GrammarRule("program")]
    private void program(StructTypes stypes, SymbolTable stable)
    {

    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(16, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:17:2: ( ^( PROGRAM ( types[stypes] declarations[stypes, stable] functions[stypes, stable] ) ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:17:4: ^( PROGRAM ( types[stypes] declarations[stypes, stable] functions[stypes, stable] ) )
    		{
    		DebugLocation(17, 4);
    		DebugLocation(17, 6);
    		Match(input,PROGRAM,Follow._PROGRAM_in_program52); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(17, 14);
    		// GenericEvilTreeParser.g:17:14: ( types[stypes] declarations[stypes, stable] functions[stypes, stable] )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:17:15: types[stypes] declarations[stypes, stable] functions[stypes, stable]
    		{
    		DebugLocation(17, 15);
    		PushFollow(Follow._types_in_program55);
    		types(stypes);
    		PopFollow();

    		DebugLocation(17, 29);
    		PushFollow(Follow._declarations_in_program58);
    		declarations(stypes, stable);
    		PopFollow();

    		DebugLocation(17, 58);
    		PushFollow(Follow._functions_in_program61);
    		functions(stypes, stable);
    		PopFollow();


    		}


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(18, 2);

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
     	DebugLocation(29, 1);
    	} finally { DebugExitRule(GrammarFileName, "program"); }
    	return;

    }
    // $ANTLR end "program"


    protected virtual void Enter_types() {}
    protected virtual void Leave_types() {}

    // $ANTLR start "types"
    // GenericEvilTreeParser.g:31:1: types[StructTypes stypes] : ( ^( TYPES types_sub[stypes] ) | TYPES );
    [GrammarRule("types")]
    private void types(StructTypes stypes)
    {

    	try { DebugEnterRule(GrammarFileName, "types");
    	DebugLocation(31, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:32:4: ( ^( TYPES types_sub[stypes] ) | TYPES )
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
    			// GenericEvilTreeParser.g:32:7: ^( TYPES types_sub[stypes] )
    			{
    			DebugLocation(32, 7);
    			DebugLocation(32, 9);
    			Match(input,TYPES,Follow._TYPES_in_types85); 

    			if (input.LA(1) == TokenTypes.Down)
    			{
    				Match(input, TokenTypes.Down, null); 
    				DebugLocation(32, 15);
    				PushFollow(Follow._types_sub_in_types87);
    				types_sub(stypes);
    				PopFollow();


    				Match(input, TokenTypes.Up, null); 
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:33:7: TYPES
    			{
    			DebugLocation(33, 7);
    			Match(input,TYPES,Follow._TYPES_in_types97); 

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
     	DebugLocation(34, 3);
    	} finally { DebugExitRule(GrammarFileName, "types"); }
    	return;

    }
    // $ANTLR end "types"


    protected virtual void Enter_type_declaration() {}
    protected virtual void Leave_type_declaration() {}

    // $ANTLR start "type_declaration"
    // GenericEvilTreeParser.g:36:1: type_declaration[StructTypes stypes] : ^( STRUCT (id= ID ) nested_decl[stypes, sdef] ) ;
    [GrammarRule("type_declaration")]
    private void type_declaration(StructTypes stypes)
    {

        CommonTree id=null;

        StructTypes.StructDef sdef = null;
    	try { DebugEnterRule(GrammarFileName, "type_declaration");
    	DebugLocation(36, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:38:4: ( ^( STRUCT (id= ID ) nested_decl[stypes, sdef] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:38:7: ^( STRUCT (id= ID ) nested_decl[stypes, sdef] )
    		{
    		DebugLocation(38, 7);
    		DebugLocation(38, 9);
    		Match(input,STRUCT,Follow._STRUCT_in_type_declaration121); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(38, 16);
    		// GenericEvilTreeParser.g:38:16: (id= ID )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:38:17: id= ID
    		{
    		DebugLocation(38, 19);
    		id=(CommonTree)Match(input,ID,Follow._ID_in_type_declaration126); 

    		}

    		DebugLocation(39, 5);

    		   		if (stypes.isDefined((id!=null?id.Text:null)))
    		   		{
    		   			error((id!=null?id.Line:0), "struct type already defined: '" + (id!=null?id.Text:null) + "'");
    		   		}
    		   		sdef = stypes.define((id!=null?id.Text:null));
    		   	
    		DebugLocation(46, 10);
    		PushFollow(Follow._nested_decl_in_type_declaration145);
    		nested_decl(stypes, sdef);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(47, 11);

    		         	

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
     	DebugLocation(49, 3);
    	} finally { DebugExitRule(GrammarFileName, "type_declaration"); }
    	return;

    }
    // $ANTLR end "type_declaration"


    protected virtual void Enter_nested_decl() {}
    protected virtual void Leave_nested_decl() {}

    // $ANTLR start "nested_decl"
    // GenericEvilTreeParser.g:51:1: nested_decl[StructTypes stypes, StructTypes.StructDef sdef] : ( field_decl[stypes, sdef] )+ ;
    [GrammarRule("nested_decl")]
    private void nested_decl(StructTypes stypes, StructTypes.StructDef sdef)
    {

    	try { DebugEnterRule(GrammarFileName, "nested_decl");
    	DebugLocation(51, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:52:4: ( ( field_decl[stypes, sdef] )+ )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:52:7: ( field_decl[stypes, sdef] )+
    		{
    		DebugLocation(52, 7);
    		// GenericEvilTreeParser.g:52:7: ( field_decl[stypes, sdef] )+
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
    				// GenericEvilTreeParser.g:52:8: field_decl[stypes, sdef]
    				{
    				DebugLocation(52, 8);
    				PushFollow(Follow._field_decl_in_nested_decl179);
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
     	DebugLocation(53, 3);
    	} finally { DebugExitRule(GrammarFileName, "nested_decl"); }
    	return;

    }
    // $ANTLR end "nested_decl"


    protected virtual void Enter_types_sub() {}
    protected virtual void Leave_types_sub() {}

    // $ANTLR start "types_sub"
    // GenericEvilTreeParser.g:55:1: types_sub[StructTypes stypes] : ( ( type_declaration[stypes] types_sub[stypes] ) | );
    [GrammarRule("types_sub")]
    private void types_sub(StructTypes stypes)
    {

    	try { DebugEnterRule(GrammarFileName, "types_sub");
    	DebugLocation(55, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:56:4: ( ( type_declaration[stypes] types_sub[stypes] ) | )
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
    			// GenericEvilTreeParser.g:56:7: ( type_declaration[stypes] types_sub[stypes] )
    			{
    			DebugLocation(56, 7);
    			// GenericEvilTreeParser.g:56:7: ( type_declaration[stypes] types_sub[stypes] )
    			DebugEnterAlt(1);
    			// GenericEvilTreeParser.g:56:8: type_declaration[stypes] types_sub[stypes]
    			{
    			DebugLocation(56, 8);
    			PushFollow(Follow._type_declaration_in_types_sub201);
    			type_declaration(stypes);
    			PopFollow();

    			DebugLocation(56, 33);
    			PushFollow(Follow._types_sub_in_types_sub204);
    			types_sub(stypes);
    			PopFollow();


    			}


    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:57:6: 
    			{
    			DebugLocation(57, 6);


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
     	DebugLocation(58, 3);
    	} finally { DebugExitRule(GrammarFileName, "types_sub"); }
    	return;

    }
    // $ANTLR end "types_sub"


    protected virtual void Enter_field_decl() {}
    protected virtual void Leave_field_decl() {}

    // $ANTLR start "field_decl"
    // GenericEvilTreeParser.g:60:1: field_decl[StructTypes stypes, StructTypes.StructDef sdef] : ^( DECL ^( TYPE tt= type[stypes] ) id= ID ) ;
    [GrammarRule("field_decl")]
    private void field_decl(StructTypes stypes, StructTypes.StructDef sdef)
    {

        CommonTree id=null;
        Type tt = default(Type);

    	try { DebugEnterRule(GrammarFileName, "field_decl");
    	DebugLocation(60, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:61:4: ( ^( DECL ^( TYPE tt= type[stypes] ) id= ID ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:61:7: ^( DECL ^( TYPE tt= type[stypes] ) id= ID )
    		{
    		DebugLocation(61, 7);
    		DebugLocation(61, 9);
    		Match(input,DECL,Follow._DECL_in_field_decl232); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(61, 14);
    		DebugLocation(61, 16);
    		Match(input,TYPE,Follow._TYPE_in_field_decl235); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(61, 23);
    		PushFollow(Follow._type_in_field_decl239);
    		tt=type(stypes);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(61, 40);
    		id=(CommonTree)Match(input,ID,Follow._ID_in_field_decl245); 

    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(62, 2);

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
     	DebugLocation(69, 3);
    	} finally { DebugExitRule(GrammarFileName, "field_decl"); }
    	return;

    }
    // $ANTLR end "field_decl"


    protected virtual void Enter_type() {}
    protected virtual void Leave_type() {}

    // $ANTLR start "type"
    // GenericEvilTreeParser.g:71:1: type[StructTypes stypes] returns [Type t = null] : ( INT | BOOL | ^( STRUCT id= ID ) );
    [GrammarRule("type")]
    private Type type(StructTypes stypes)
    {

        Type t =  null;

        CommonTree id=null;

    	try { DebugEnterRule(GrammarFileName, "type");
    	DebugLocation(71, 0);
    	try
    	{
    		// GenericEvilTreeParser.g:72:2: ( INT | BOOL | ^( STRUCT id= ID ) )
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
    			// GenericEvilTreeParser.g:72:4: INT
    			{
    			DebugLocation(72, 4);
    			Match(input,INT,Follow._INT_in_type269); 
    			DebugLocation(72, 8);
    			 t = Type.intType(); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:73:4: BOOL
    			{
    			DebugLocation(73, 4);
    			Match(input,BOOL,Follow._BOOL_in_type276); 
    			DebugLocation(73, 9);
    			 t = Type.boolType(); 

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// GenericEvilTreeParser.g:74:4: ^( STRUCT id= ID )
    			{
    			DebugLocation(74, 4);
    			DebugLocation(74, 6);
    			Match(input,STRUCT,Follow._STRUCT_in_type284); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(74, 15);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_type288); 

    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(75, 2);

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
     	DebugLocation(82, 0);
    	} finally { DebugExitRule(GrammarFileName, "type"); }
    	return t;

    }
    // $ANTLR end "type"


    protected virtual void Enter_declarations() {}
    protected virtual void Leave_declarations() {}

    // $ANTLR start "declarations"
    // GenericEvilTreeParser.g:84:1: declarations[StructTypes stypes, SymbolTable stable] : ( ^( DECLS declaration[stypes,stable] ) | );
    [GrammarRule("declarations")]
    private void declarations(StructTypes stypes, SymbolTable stable)
    {

    	try { DebugEnterRule(GrammarFileName, "declarations");
    	DebugLocation(84, 0);
    	try
    	{
    		// GenericEvilTreeParser.g:85:2: ( ^( DECLS declaration[stypes,stable] ) | )
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
    			// GenericEvilTreeParser.g:85:4: ^( DECLS declaration[stypes,stable] )
    			{
    			DebugLocation(85, 4);
    			DebugLocation(85, 6);
    			Match(input,DECLS,Follow._DECLS_in_declarations305); 

    			if (input.LA(1) == TokenTypes.Down)
    			{
    				Match(input, TokenTypes.Down, null); 
    				DebugLocation(85, 12);
    				PushFollow(Follow._declaration_in_declarations307);
    				declaration(stypes, stable);
    				PopFollow();


    				Match(input, TokenTypes.Up, null); 
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:86:4: 
    			{
    			DebugLocation(86, 4);


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
     	DebugLocation(87, 0);
    	} finally { DebugExitRule(GrammarFileName, "declarations"); }
    	return;

    }
    // $ANTLR end "declarations"


    protected virtual void Enter_declaration() {}
    protected virtual void Leave_declaration() {}

    // $ANTLR start "declaration"
    // GenericEvilTreeParser.g:89:1: declaration[StructTypes stypes,SymbolTable stable] : ( decl_list[stypes,stable] )* ;
    [GrammarRule("declaration")]
    private void declaration(StructTypes stypes, SymbolTable stable)
    {

    	try { DebugEnterRule(GrammarFileName, "declaration");
    	DebugLocation(89, 0);
    	try
    	{
    		// GenericEvilTreeParser.g:90:2: ( ( decl_list[stypes,stable] )* )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:90:4: ( decl_list[stypes,stable] )*
    		{
    		DebugLocation(90, 4);
    		// GenericEvilTreeParser.g:90:4: ( decl_list[stypes,stable] )*
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
    				// GenericEvilTreeParser.g:90:5: decl_list[stypes,stable]
    				{
    				DebugLocation(90, 5);
    				PushFollow(Follow._decl_list_in_declaration327);
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
     	DebugLocation(91, 0);
    	} finally { DebugExitRule(GrammarFileName, "declaration"); }
    	return;

    }
    // $ANTLR end "declaration"


    protected virtual void Enter_decl_list() {}
    protected virtual void Leave_decl_list() {}

    // $ANTLR start "decl_list"
    // GenericEvilTreeParser.g:93:1: decl_list[StructTypes stypes,SymbolTable stable] : ^( DECLLIST ^( TYPE t= type[stypes] ) id_list[t,stable] ) ;
    [GrammarRule("decl_list")]
    private void decl_list(StructTypes stypes, SymbolTable stable)
    {

        Type t = default(Type);

    	try { DebugEnterRule(GrammarFileName, "decl_list");
    	DebugLocation(93, 0);
    	try
    	{
    		// GenericEvilTreeParser.g:94:2: ( ^( DECLLIST ^( TYPE t= type[stypes] ) id_list[t,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:94:4: ^( DECLLIST ^( TYPE t= type[stypes] ) id_list[t,stable] )
    		{
    		DebugLocation(94, 4);
    		DebugLocation(94, 6);
    		Match(input,DECLLIST,Follow._DECLLIST_in_decl_list343); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(94, 15);
    		DebugLocation(94, 17);
    		Match(input,TYPE,Follow._TYPE_in_decl_list346); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(94, 23);
    		PushFollow(Follow._type_in_decl_list350);
    		t=type(stypes);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(94, 38);
    		PushFollow(Follow._id_list_in_decl_list354);
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
     	DebugLocation(95, 0);
    	} finally { DebugExitRule(GrammarFileName, "decl_list"); }
    	return;

    }
    // $ANTLR end "decl_list"


    protected virtual void Enter_id_list() {}
    protected virtual void Leave_id_list() {}

    // $ANTLR start "id_list"
    // GenericEvilTreeParser.g:97:1: id_list[Type t, SymbolTable stable] : (id= ID )+ ;
    [GrammarRule("id_list")]
    private void id_list(Type t, SymbolTable stable)
    {

        CommonTree id=null;

    	try { DebugEnterRule(GrammarFileName, "id_list");
    	DebugLocation(97, 0);
    	try
    	{
    		// GenericEvilTreeParser.g:98:2: ( (id= ID )+ )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:98:4: (id= ID )+
    		{
    		DebugLocation(98, 4);
    		// GenericEvilTreeParser.g:98:4: (id= ID )+
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
    				// GenericEvilTreeParser.g:99:3: id= ID
    				{
    				DebugLocation(99, 5);
    				id=(CommonTree)Match(input,ID,Follow._ID_in_id_list374); 
    				DebugLocation(100, 3);

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
     	DebugLocation(112, 0);
    	} finally { DebugExitRule(GrammarFileName, "id_list"); }
    	return;

    }
    // $ANTLR end "id_list"


    protected virtual void Enter_functions() {}
    protected virtual void Leave_functions() {}

    // $ANTLR start "functions"
    // GenericEvilTreeParser.g:114:1: functions[StructTypes stypes,SymbolTable stable] : ^( FUNCS ( function[stypes, stable] )* ) ;
    [GrammarRule("functions")]
    private void functions(StructTypes stypes, SymbolTable stable)
    {

    	try { DebugEnterRule(GrammarFileName, "functions");
    	DebugLocation(114, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:115:2: ( ^( FUNCS ( function[stypes, stable] )* ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:115:4: ^( FUNCS ( function[stypes, stable] )* )
    		{
    		DebugLocation(115, 4);
    		DebugLocation(115, 6);
    		Match(input,FUNCS,Follow._FUNCS_in_functions395); 

    		if (input.LA(1) == TokenTypes.Down)
    		{
    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(115, 12);
    			// GenericEvilTreeParser.g:115:12: ( function[stypes, stable] )*
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
    					// GenericEvilTreeParser.g:115:12: function[stypes, stable]
    					{
    					DebugLocation(115, 12);
    					PushFollow(Follow._function_in_functions397);
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
     	DebugLocation(116, 1);
    	} finally { DebugExitRule(GrammarFileName, "functions"); }
    	return;

    }
    // $ANTLR end "functions"


    protected virtual void Enter_function() {}
    protected virtual void Leave_function() {}

    // $ANTLR start "function"
    // GenericEvilTreeParser.g:118:1: function[StructTypes stypes,SymbolTable globalStable] : ^( FUN id= ID p= parameters[stypes, myStable, sparams] ^( RETTYPE r= return_type[stypes] ) d= declarations[stypes, myStable] s= statement_list[stypes,myStable] ) ;
    [GrammarRule("function")]
    private void function(StructTypes stypes, SymbolTable globalStable)
    {

        CommonTree id=null;
        Type r = default(Type);
        bool s = default(bool);

        SymbolTable myStable = new SymbolTable(globalStable); List<Type> sparams = new List<Type>(); 
    	try { DebugEnterRule(GrammarFileName, "function");
    	DebugLocation(118, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:120:2: ( ^( FUN id= ID p= parameters[stypes, myStable, sparams] ^( RETTYPE r= return_type[stypes] ) d= declarations[stypes, myStable] s= statement_list[stypes,myStable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:120:4: ^( FUN id= ID p= parameters[stypes, myStable, sparams] ^( RETTYPE r= return_type[stypes] ) d= declarations[stypes, myStable] s= statement_list[stypes,myStable] )
    		{
    		DebugLocation(120, 4);
    		DebugLocation(120, 6);
    		Match(input,FUN,Follow._FUN_in_function419); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(120, 12);
    		id=(CommonTree)Match(input,ID,Follow._ID_in_function423); 
    		DebugLocation(120, 17);
    		PushFollow(Follow._parameters_in_function427);
    		parameters(stypes, myStable, sparams);
    		PopFollow();

    		DebugLocation(120, 56);
    		DebugLocation(120, 58);
    		Match(input,RETTYPE,Follow._RETTYPE_in_function431); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(120, 67);
    		PushFollow(Follow._return_type_in_function435);
    		r=return_type(stypes);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(120, 90);
    		PushFollow(Follow._declarations_in_function441);
    		declarations(stypes, myStable);
    		PopFollow();

    		DebugLocation(121, 2);

    				if (globalStable.redef((id!=null?id.Text:null)))
    				{
    					error((id!=null?id.Line:0), "redef function '" + id + "'");
    				}
    				globalStable.put((id!=null?id.Text:null), Type.funType(sparams, r));
    				myStable.returnType = r;
    			
    		DebugLocation(128, 5);
    		PushFollow(Follow._statement_list_in_function449);
    		s=statement_list(stypes, myStable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(129, 2);

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
     	DebugLocation(133, 1);
    	} finally { DebugExitRule(GrammarFileName, "function"); }
    	return;

    }
    // $ANTLR end "function"


    protected virtual void Enter_parameters() {}
    protected virtual void Leave_parameters() {}

    // $ANTLR start "parameters"
    // GenericEvilTreeParser.g:135:1: parameters[StructTypes stypes,SymbolTable stable, List<Type> sparams] : ^( PARAMS ( param_decl[stypes, stable, sparams] )* ) ;
    [GrammarRule("parameters")]
    private void parameters(StructTypes stypes, SymbolTable stable, List<Type> sparams)
    {

    	try { DebugEnterRule(GrammarFileName, "parameters");
    	DebugLocation(135, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:136:2: ( ^( PARAMS ( param_decl[stypes, stable, sparams] )* ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:136:4: ^( PARAMS ( param_decl[stypes, stable, sparams] )* )
    		{
    		DebugLocation(136, 4);
    		DebugLocation(136, 6);
    		Match(input,PARAMS,Follow._PARAMS_in_parameters468); 

    		if (input.LA(1) == TokenTypes.Down)
    		{
    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(136, 13);
    			// GenericEvilTreeParser.g:136:13: ( param_decl[stypes, stable, sparams] )*
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
    					// GenericEvilTreeParser.g:136:13: param_decl[stypes, stable, sparams]
    					{
    					DebugLocation(136, 13);
    					PushFollow(Follow._param_decl_in_parameters470);
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
     	DebugLocation(137, 1);
    	} finally { DebugExitRule(GrammarFileName, "parameters"); }
    	return;

    }
    // $ANTLR end "parameters"


    protected virtual void Enter_param_decl() {}
    protected virtual void Leave_param_decl() {}

    // $ANTLR start "param_decl"
    // GenericEvilTreeParser.g:139:1: param_decl[StructTypes stypes, SymbolTable stable, List<Type> sparams] : ^( DECL ^( TYPE tt= type[stypes] ) id= ID ) ;
    [GrammarRule("param_decl")]
    private void param_decl(StructTypes stypes, SymbolTable stable, List<Type> sparams)
    {

        CommonTree id=null;
        Type tt = default(Type);

    	try { DebugEnterRule(GrammarFileName, "param_decl");
    	DebugLocation(139, 3);
    	try
    	{
    		// GenericEvilTreeParser.g:140:4: ( ^( DECL ^( TYPE tt= type[stypes] ) id= ID ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:140:7: ^( DECL ^( TYPE tt= type[stypes] ) id= ID )
    		{
    		DebugLocation(140, 7);
    		DebugLocation(140, 9);
    		Match(input,DECL,Follow._DECL_in_param_decl490); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(140, 14);
    		DebugLocation(140, 16);
    		Match(input,TYPE,Follow._TYPE_in_param_decl493); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(140, 23);
    		PushFollow(Follow._type_in_param_decl497);
    		tt=type(stypes);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(140, 40);
    		id=(CommonTree)Match(input,ID,Follow._ID_in_param_decl503); 

    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(141, 3);

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
     	DebugLocation(149, 3);
    	} finally { DebugExitRule(GrammarFileName, "param_decl"); }
    	return;

    }
    // $ANTLR end "param_decl"


    protected virtual void Enter_return_type() {}
    protected virtual void Leave_return_type() {}

    // $ANTLR start "return_type"
    // GenericEvilTreeParser.g:151:1: return_type[StructTypes stypes] returns [Type retT = null] : (t= type[stypes] | VOID );
    [GrammarRule("return_type")]
    private Type return_type(StructTypes stypes)
    {

        Type retT =  null;

        Type t = default(Type);

    	try { DebugEnterRule(GrammarFileName, "return_type");
    	DebugLocation(151, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:152:2: (t= type[stypes] | VOID )
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
    			// GenericEvilTreeParser.g:152:4: t= type[stypes]
    			{
    			DebugLocation(152, 5);
    			PushFollow(Follow._type_in_return_type528);
    			t=type(stypes);
    			PopFollow();

    			DebugLocation(152, 18);
    			retT = t;

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:153:4: VOID
    			{
    			DebugLocation(153, 4);
    			Match(input,VOID,Follow._VOID_in_return_type536); 
    			DebugLocation(153, 9);
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
     	DebugLocation(154, 1);
    	} finally { DebugExitRule(GrammarFileName, "return_type"); }
    	return retT;

    }
    // $ANTLR end "return_type"


    protected virtual void Enter_statement() {}
    protected virtual void Leave_statement() {}

    // $ANTLR start "statement"
    // GenericEvilTreeParser.g:156:1: statement[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : (s= block[stypes,stable] | s= assignment[stypes,stable] | s= print[stypes,stable] | s= read[stypes,stable] | s= conditional[stypes,stable] | s= loop[stypes,stable] | s= delete[stypes,stable] | s= ret[stypes,stable] | s= invocation[stypes,stable] );
    [GrammarRule("statement")]
    private bool statement(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        bool s = default(bool);

    	try { DebugEnterRule(GrammarFileName, "statement");
    	DebugLocation(156, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:157:2: (s= block[stypes,stable] | s= assignment[stypes,stable] | s= print[stypes,stable] | s= read[stypes,stable] | s= conditional[stypes,stable] | s= loop[stypes,stable] | s= delete[stypes,stable] | s= ret[stypes,stable] | s= invocation[stypes,stable] )
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
    			// GenericEvilTreeParser.g:157:4: s= block[stypes,stable]
    			{
    			DebugLocation(157, 5);
    			PushFollow(Follow._block_in_statement556);
    			s=block(stypes, stable);
    			PopFollow();

    			DebugLocation(157, 27);
    			 doesRet = s; 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:158:4: s= assignment[stypes,stable]
    			{
    			DebugLocation(158, 5);
    			PushFollow(Follow._assignment_in_statement566);
    			s=assignment(stypes, stable);
    			PopFollow();

    			DebugLocation(158, 32);
    			 doesRet = s; 

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// GenericEvilTreeParser.g:159:4: s= print[stypes,stable]
    			{
    			DebugLocation(159, 5);
    			PushFollow(Follow._print_in_statement576);
    			s=print(stypes, stable);
    			PopFollow();

    			DebugLocation(159, 27);
    			 doesRet = s; 

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// GenericEvilTreeParser.g:160:4: s= read[stypes,stable]
    			{
    			DebugLocation(160, 5);
    			PushFollow(Follow._read_in_statement586);
    			s=read(stypes, stable);
    			PopFollow();

    			DebugLocation(160, 26);
    			 doesRet = s; 

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// GenericEvilTreeParser.g:161:4: s= conditional[stypes,stable]
    			{
    			DebugLocation(161, 5);
    			PushFollow(Follow._conditional_in_statement596);
    			s=conditional(stypes, stable);
    			PopFollow();

    			DebugLocation(161, 33);
    			 doesRet = s; 

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// GenericEvilTreeParser.g:162:4: s= loop[stypes,stable]
    			{
    			DebugLocation(162, 5);
    			PushFollow(Follow._loop_in_statement606);
    			s=loop(stypes, stable);
    			PopFollow();

    			DebugLocation(162, 26);
    			 doesRet = s; 

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// GenericEvilTreeParser.g:163:4: s= delete[stypes,stable]
    			{
    			DebugLocation(163, 5);
    			PushFollow(Follow._delete_in_statement616);
    			s=delete(stypes, stable);
    			PopFollow();

    			DebugLocation(163, 28);
    			 doesRet = s; 

    			}
    			break;
    		case 8:
    			DebugEnterAlt(8);
    			// GenericEvilTreeParser.g:164:4: s= ret[stypes,stable]
    			{
    			DebugLocation(164, 5);
    			PushFollow(Follow._ret_in_statement626);
    			s=ret(stypes, stable);
    			PopFollow();

    			DebugLocation(164, 25);
    			 doesRet = s; 

    			}
    			break;
    		case 9:
    			DebugEnterAlt(9);
    			// GenericEvilTreeParser.g:165:4: s= invocation[stypes,stable]
    			{
    			DebugLocation(165, 5);
    			PushFollow(Follow._invocation_in_statement636);
    			s=invocation(stypes, stable);
    			PopFollow();

    			DebugLocation(165, 32);
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
     	DebugLocation(166, 1);
    	} finally { DebugExitRule(GrammarFileName, "statement"); }
    	return doesRet;

    }
    // $ANTLR end "statement"


    protected virtual void Enter_block() {}
    protected virtual void Leave_block() {}

    // $ANTLR start "block"
    // GenericEvilTreeParser.g:168:1: block[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( BLOCK s= statement_list[stypes,stable] ) ;
    [GrammarRule("block")]
    private bool block(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        bool s = default(bool);

    	try { DebugEnterRule(GrammarFileName, "block");
    	DebugLocation(168, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:169:2: ( ^( BLOCK s= statement_list[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:169:4: ^( BLOCK s= statement_list[stypes,stable] )
    		{
    		DebugLocation(169, 4);
    		DebugLocation(169, 6);
    		Match(input,BLOCK,Follow._BLOCK_in_block656); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(169, 13);
    		PushFollow(Follow._statement_list_in_block660);
    		s=statement_list(stypes, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(169, 45);
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
     	DebugLocation(170, 1);
    	} finally { DebugExitRule(GrammarFileName, "block"); }
    	return doesRet;

    }
    // $ANTLR end "block"


    protected virtual void Enter_statement_list() {}
    protected virtual void Leave_statement_list() {}

    // $ANTLR start "statement_list"
    // GenericEvilTreeParser.g:172:1: statement_list[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( STMTS (s= statement[stypes,stable] )* ) ;
    [GrammarRule("statement_list")]
    private bool statement_list(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        bool s = default(bool);

    	try { DebugEnterRule(GrammarFileName, "statement_list");
    	DebugLocation(172, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:173:2: ( ^( STMTS (s= statement[stypes,stable] )* ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:173:4: ^( STMTS (s= statement[stypes,stable] )* )
    		{
    		DebugLocation(173, 4);
    		DebugLocation(173, 6);
    		Match(input,STMTS,Follow._STMTS_in_statement_list681); 

    		if (input.LA(1) == TokenTypes.Down)
    		{
    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(173, 12);
    			// GenericEvilTreeParser.g:173:12: (s= statement[stypes,stable] )*
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
    					// GenericEvilTreeParser.g:173:13: s= statement[stypes,stable]
    					{
    					DebugLocation(173, 14);
    					PushFollow(Follow._statement_in_statement_list686);
    					s=statement(stypes, stable);
    					PopFollow();

    					DebugLocation(174, 3);

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
     	DebugLocation(179, 1);
    	} finally { DebugExitRule(GrammarFileName, "statement_list"); }
    	return doesRet;

    }
    // $ANTLR end "statement_list"


    protected virtual void Enter_assignment() {}
    protected virtual void Leave_assignment() {}

    // $ANTLR start "assignment"
    // GenericEvilTreeParser.g:181:1: assignment[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( ASSIGN expression[stypes,stable] lvalue[stypes,stable] ) ;
    [GrammarRule("assignment")]
    private bool assignment(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

    	try { DebugEnterRule(GrammarFileName, "assignment");
    	DebugLocation(181, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:182:2: ( ^( ASSIGN expression[stypes,stable] lvalue[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:182:4: ^( ASSIGN expression[stypes,stable] lvalue[stypes,stable] )
    		{
    		DebugLocation(182, 4);
    		DebugLocation(182, 6);
    		Match(input,ASSIGN,Follow._ASSIGN_in_assignment713); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(182, 13);
    		PushFollow(Follow._expression_in_assignment715);
    		expression(stypes, stable);
    		PopFollow();

    		DebugLocation(182, 39);
    		PushFollow(Follow._lvalue_in_assignment718);
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
     	DebugLocation(183, 1);
    	} finally { DebugExitRule(GrammarFileName, "assignment"); }
    	return doesRet;

    }
    // $ANTLR end "assignment"


    protected virtual void Enter_print() {}
    protected virtual void Leave_print() {}

    // $ANTLR start "print"
    // GenericEvilTreeParser.g:185:1: print[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( PRINT expression[stypes,stable] ( ENDL )? ) ;
    [GrammarRule("print")]
    private bool print(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

    	try { DebugEnterRule(GrammarFileName, "print");
    	DebugLocation(185, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:186:2: ( ^( PRINT expression[stypes,stable] ( ENDL )? ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:186:4: ^( PRINT expression[stypes,stable] ( ENDL )? )
    		{
    		DebugLocation(186, 4);
    		DebugLocation(186, 6);
    		Match(input,PRINT,Follow._PRINT_in_print737); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(186, 12);
    		PushFollow(Follow._expression_in_print739);
    		expression(stypes, stable);
    		PopFollow();

    		DebugLocation(186, 38);
    		// GenericEvilTreeParser.g:186:38: ( ENDL )?
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
    			// GenericEvilTreeParser.g:186:39: ENDL
    			{
    			DebugLocation(186, 39);
    			Match(input,ENDL,Follow._ENDL_in_print743); 

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
     	DebugLocation(187, 1);
    	} finally { DebugExitRule(GrammarFileName, "print"); }
    	return doesRet;

    }
    // $ANTLR end "print"


    protected virtual void Enter_read() {}
    protected virtual void Leave_read() {}

    // $ANTLR start "read"
    // GenericEvilTreeParser.g:189:1: read[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( READ lvalue[stypes,stable] ) ;
    [GrammarRule("read")]
    private bool read(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

    	try { DebugEnterRule(GrammarFileName, "read");
    	DebugLocation(189, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:190:2: ( ^( READ lvalue[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:190:4: ^( READ lvalue[stypes,stable] )
    		{
    		DebugLocation(190, 4);
    		DebugLocation(190, 6);
    		Match(input,READ,Follow._READ_in_read763); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(190, 11);
    		PushFollow(Follow._lvalue_in_read765);
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
     	DebugLocation(191, 1);
    	} finally { DebugExitRule(GrammarFileName, "read"); }
    	return doesRet;

    }
    // $ANTLR end "read"


    protected virtual void Enter_conditional() {}
    protected virtual void Leave_conditional() {}

    // $ANTLR start "conditional"
    // GenericEvilTreeParser.g:193:1: conditional[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^(w= IF e= expression[stypes,stable] b1= block[stypes,stable] (b2= block[stypes,stable] )? ) ;
    [GrammarRule("conditional")]
    private bool conditional(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        CommonTree w=null;
        Type e = default(Type);
        bool b1 = default(bool);
        bool b2 = default(bool);

    	try { DebugEnterRule(GrammarFileName, "conditional");
    	DebugLocation(193, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:194:2: ( ^(w= IF e= expression[stypes,stable] b1= block[stypes,stable] (b2= block[stypes,stable] )? ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:194:4: ^(w= IF e= expression[stypes,stable] b1= block[stypes,stable] (b2= block[stypes,stable] )? )
    		{
    		DebugLocation(194, 4);
    		DebugLocation(194, 7);
    		w=(CommonTree)Match(input,IF,Follow._IF_in_conditional786); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(194, 12);
    		PushFollow(Follow._expression_in_conditional790);
    		e=expression(stypes, stable);
    		PopFollow();

    		DebugLocation(194, 41);
    		PushFollow(Follow._block_in_conditional795);
    		b1=block(stypes, stable);
    		PopFollow();

    		DebugLocation(194, 63);
    		// GenericEvilTreeParser.g:194:63: (b2= block[stypes,stable] )?
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
    			// GenericEvilTreeParser.g:194:64: b2= block[stypes,stable]
    			{
    			DebugLocation(194, 66);
    			PushFollow(Follow._block_in_conditional801);
    			b2=block(stypes, stable);
    			PopFollow();


    			}
    			break;

    		}
    		} finally { DebugExitSubRule(14); }


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(195, 3);

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
     	DebugLocation(202, 1);
    	} finally { DebugExitRule(GrammarFileName, "conditional"); }
    	return doesRet;

    }
    // $ANTLR end "conditional"


    protected virtual void Enter_loop() {}
    protected virtual void Leave_loop() {}

    // $ANTLR start "loop"
    // GenericEvilTreeParser.g:204:1: loop[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^(w= WHILE guard= expression[stypes,stable] b= block[stypes,stable] expression[stypes,stable] ) ;
    [GrammarRule("loop")]
    private bool loop(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        CommonTree w=null;
        Type guard = default(Type);
        bool b = default(bool);

    	try { DebugEnterRule(GrammarFileName, "loop");
    	DebugLocation(204, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:205:2: ( ^(w= WHILE guard= expression[stypes,stable] b= block[stypes,stable] expression[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:205:4: ^(w= WHILE guard= expression[stypes,stable] b= block[stypes,stable] expression[stypes,stable] )
    		{
    		DebugLocation(205, 4);
    		DebugLocation(205, 7);
    		w=(CommonTree)Match(input,WHILE,Follow._WHILE_in_loop828); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(205, 19);
    		PushFollow(Follow._expression_in_loop832);
    		guard=expression(stypes, stable);
    		PopFollow();

    		DebugLocation(205, 47);
    		PushFollow(Follow._block_in_loop837);
    		b=block(stypes, stable);
    		PopFollow();

    		DebugLocation(205, 69);
    		PushFollow(Follow._expression_in_loop840);
    		expression(stypes, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(206, 3);

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
     	DebugLocation(212, 1);
    	} finally { DebugExitRule(GrammarFileName, "loop"); }
    	return doesRet;

    }
    // $ANTLR end "loop"


    protected virtual void Enter_delete() {}
    protected virtual void Leave_delete() {}

    // $ANTLR start "delete"
    // GenericEvilTreeParser.g:214:1: delete[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^(d= DELETE e= expression[stypes,stable] ) ;
    [GrammarRule("delete")]
    private bool delete(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        CommonTree d=null;
        Type e = default(Type);

    	try { DebugEnterRule(GrammarFileName, "delete");
    	DebugLocation(214, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:215:2: ( ^(d= DELETE e= expression[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:215:4: ^(d= DELETE e= expression[stypes,stable] )
    		{
    		DebugLocation(215, 4);
    		DebugLocation(215, 7);
    		d=(CommonTree)Match(input,DELETE,Follow._DELETE_in_delete865); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(215, 16);
    		PushFollow(Follow._expression_in_delete869);
    		e=expression(stypes, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(216, 3);

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
     	DebugLocation(222, 1);
    	} finally { DebugExitRule(GrammarFileName, "delete"); }
    	return doesRet;

    }
    // $ANTLR end "delete"


    protected virtual void Enter_ret() {}
    protected virtual void Leave_ret() {}

    // $ANTLR start "ret"
    // GenericEvilTreeParser.g:224:1: ret[StructTypes stypes,SymbolTable stable] returns [bool doesRet = true] : ^(r= RETURN (e= expression[stypes,stable] )? ) ;
    [GrammarRule("ret")]
    private bool ret(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  true;

        CommonTree r=null;
        Type e = default(Type);

    	try { DebugEnterRule(GrammarFileName, "ret");
    	DebugLocation(224, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:225:2: ( ^(r= RETURN (e= expression[stypes,stable] )? ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:225:4: ^(r= RETURN (e= expression[stypes,stable] )? )
    		{
    		DebugLocation(225, 4);
    		DebugLocation(225, 7);
    		r=(CommonTree)Match(input,RETURN,Follow._RETURN_in_ret895); 

    		if (input.LA(1) == TokenTypes.Down)
    		{
    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(225, 15);
    			// GenericEvilTreeParser.g:225:15: (e= expression[stypes,stable] )?
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
    				// GenericEvilTreeParser.g:225:16: e= expression[stypes,stable]
    				{
    				DebugLocation(225, 17);
    				PushFollow(Follow._expression_in_ret900);
    				e=expression(stypes, stable);
    				PopFollow();


    				}
    				break;

    			}
    			} finally { DebugExitSubRule(15); }


    			Match(input, TokenTypes.Up, null); 
    		}
    		DebugLocation(226, 3);

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
     	DebugLocation(238, 1);
    	} finally { DebugExitRule(GrammarFileName, "ret"); }
    	return doesRet;

    }
    // $ANTLR end "ret"


    protected virtual void Enter_invocation() {}
    protected virtual void Leave_invocation() {}

    // $ANTLR start "invocation"
    // GenericEvilTreeParser.g:240:1: invocation[StructTypes stypes,SymbolTable stable] returns [bool doesRet = false] : ^( INVOKE id= ID args= arguments[stypes,stable] ) ;
    [GrammarRule("invocation")]
    private bool invocation(StructTypes stypes, SymbolTable stable)
    {

        bool doesRet =  false;

        CommonTree id=null;
        List<Type> args = default(List<Type>);

    	try { DebugEnterRule(GrammarFileName, "invocation");
    	DebugLocation(240, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:241:2: ( ^( INVOKE id= ID args= arguments[stypes,stable] ) )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:241:4: ^( INVOKE id= ID args= arguments[stypes,stable] )
    		{
    		DebugLocation(241, 4);
    		DebugLocation(241, 6);
    		Match(input,INVOKE,Follow._INVOKE_in_invocation925); 

    		Match(input, TokenTypes.Down, null); 
    		DebugLocation(241, 15);
    		id=(CommonTree)Match(input,ID,Follow._ID_in_invocation929); 
    		DebugLocation(241, 23);
    		PushFollow(Follow._arguments_in_invocation933);
    		args=arguments(stypes, stable);
    		PopFollow();


    		Match(input, TokenTypes.Up, null); 
    		DebugLocation(241, 50);
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
     	DebugLocation(242, 1);
    	} finally { DebugExitRule(GrammarFileName, "invocation"); }
    	return doesRet;

    }
    // $ANTLR end "invocation"


    protected virtual void Enter_lvalue() {}
    protected virtual void Leave_lvalue() {}

    // $ANTLR start "lvalue"
    // GenericEvilTreeParser.g:244:1: lvalue[StructTypes stypes,SymbolTable stable] returns [Type t = null] : ( ^( DOT s= lvalue[stypes,stable] id= ID ) | id= ID );
    [GrammarRule("lvalue")]
    private Type lvalue(StructTypes stypes, SymbolTable stable)
    {

        Type t =  null;

        CommonTree id=null;
        Type s = default(Type);

    	try { DebugEnterRule(GrammarFileName, "lvalue");
    	DebugLocation(244, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:245:2: ( ^( DOT s= lvalue[stypes,stable] id= ID ) | id= ID )
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
    			// GenericEvilTreeParser.g:245:4: ^( DOT s= lvalue[stypes,stable] id= ID )
    			{
    			DebugLocation(245, 4);
    			DebugLocation(245, 6);
    			Match(input,DOT,Follow._DOT_in_lvalue954); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(245, 11);
    			PushFollow(Follow._lvalue_in_lvalue958);
    			s=lvalue(stypes, stable);
    			PopFollow();

    			DebugLocation(245, 36);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_lvalue963); 

    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(245, 41);
    			 t = getFieldType(stypes, s, id); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:246:4: id= ID
    			{
    			DebugLocation(246, 6);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_lvalue973); 
    			DebugLocation(246, 10);
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
     	DebugLocation(247, 1);
    	} finally { DebugExitRule(GrammarFileName, "lvalue"); }
    	return t;

    }
    // $ANTLR end "lvalue"


    protected virtual void Enter_expression() {}
    protected virtual void Leave_expression() {}

    // $ANTLR start "expression"
    // GenericEvilTreeParser.g:249:1: expression[StructTypes stypes,SymbolTable stable] returns [Type t = null] : ( ^(a= AND e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= OR e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= EQ e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= LT e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= GT e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= NE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= LE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= GE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= PLUS e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= MINUS e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= TIMES e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= DIVIDE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= NOT e= expression[stypes,stable] ) | ^(a= NEG e= expression[stypes,stable] ) | s= selector[stypes,stable] );
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
    	DebugLocation(249, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:250:2: ( ^(a= AND e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= OR e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= EQ e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= LT e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= GT e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= NE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= LE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= GE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= PLUS e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= MINUS e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= TIMES e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= DIVIDE e1= expression[stypes,stable] e2= expression[stypes,stable] ) | ^(a= NOT e= expression[stypes,stable] ) | ^(a= NEG e= expression[stypes,stable] ) | s= selector[stypes,stable] )
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
    			// GenericEvilTreeParser.g:250:4: ^(a= AND e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(250, 4);
    			DebugLocation(250, 7);
    			a=(CommonTree)Match(input,AND,Follow._AND_in_expression994); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(250, 14);
    			PushFollow(Follow._expression_in_expression998);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(250, 43);
    			PushFollow(Follow._expression_in_expression1003);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(250, 71);
    			ensureBool((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:251:4: ^(a= OR e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(251, 4);
    			DebugLocation(251, 7);
    			a=(CommonTree)Match(input,OR,Follow._OR_in_expression1015); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(251, 13);
    			PushFollow(Follow._expression_in_expression1019);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(251, 42);
    			PushFollow(Follow._expression_in_expression1024);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(251, 70);
    			ensureBool((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// GenericEvilTreeParser.g:252:4: ^(a= EQ e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(252, 4);
    			DebugLocation(252, 7);
    			a=(CommonTree)Match(input,EQ,Follow._EQ_in_expression1036); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(252, 13);
    			PushFollow(Follow._expression_in_expression1040);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(252, 42);
    			PushFollow(Follow._expression_in_expression1045);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(252, 70);
    			ensureStructOrInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// GenericEvilTreeParser.g:253:4: ^(a= LT e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(253, 4);
    			DebugLocation(253, 7);
    			a=(CommonTree)Match(input,LT,Follow._LT_in_expression1057); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(253, 13);
    			PushFollow(Follow._expression_in_expression1061);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(253, 42);
    			PushFollow(Follow._expression_in_expression1066);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(253, 70);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// GenericEvilTreeParser.g:254:4: ^(a= GT e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(254, 4);
    			DebugLocation(254, 7);
    			a=(CommonTree)Match(input,GT,Follow._GT_in_expression1078); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(254, 13);
    			PushFollow(Follow._expression_in_expression1082);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(254, 42);
    			PushFollow(Follow._expression_in_expression1087);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(254, 70);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// GenericEvilTreeParser.g:255:4: ^(a= NE e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(255, 4);
    			DebugLocation(255, 7);
    			a=(CommonTree)Match(input,NE,Follow._NE_in_expression1099); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(255, 13);
    			PushFollow(Follow._expression_in_expression1103);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(255, 42);
    			PushFollow(Follow._expression_in_expression1108);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(255, 70);
    			ensureStructOrInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// GenericEvilTreeParser.g:256:4: ^(a= LE e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(256, 4);
    			DebugLocation(256, 7);
    			a=(CommonTree)Match(input,LE,Follow._LE_in_expression1120); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(256, 13);
    			PushFollow(Follow._expression_in_expression1124);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(256, 42);
    			PushFollow(Follow._expression_in_expression1129);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(256, 70);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 8:
    			DebugEnterAlt(8);
    			// GenericEvilTreeParser.g:257:4: ^(a= GE e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(257, 4);
    			DebugLocation(257, 7);
    			a=(CommonTree)Match(input,GE,Follow._GE_in_expression1141); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(257, 13);
    			PushFollow(Follow._expression_in_expression1145);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(257, 42);
    			PushFollow(Follow._expression_in_expression1150);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(257, 70);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.boolType();

    			}
    			break;
    		case 9:
    			DebugEnterAlt(9);
    			// GenericEvilTreeParser.g:258:4: ^(a= PLUS e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(258, 4);
    			DebugLocation(258, 7);
    			a=(CommonTree)Match(input,PLUS,Follow._PLUS_in_expression1162); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(258, 15);
    			PushFollow(Follow._expression_in_expression1166);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(258, 44);
    			PushFollow(Follow._expression_in_expression1171);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(258, 72);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.intType();

    			}
    			break;
    		case 10:
    			DebugEnterAlt(10);
    			// GenericEvilTreeParser.g:259:4: ^(a= MINUS e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(259, 4);
    			DebugLocation(259, 7);
    			a=(CommonTree)Match(input,MINUS,Follow._MINUS_in_expression1183); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(259, 16);
    			PushFollow(Follow._expression_in_expression1187);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(259, 45);
    			PushFollow(Follow._expression_in_expression1192);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(259, 73);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.intType();

    			}
    			break;
    		case 11:
    			DebugEnterAlt(11);
    			// GenericEvilTreeParser.g:260:4: ^(a= TIMES e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(260, 4);
    			DebugLocation(260, 7);
    			a=(CommonTree)Match(input,TIMES,Follow._TIMES_in_expression1204); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(260, 16);
    			PushFollow(Follow._expression_in_expression1208);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(260, 45);
    			PushFollow(Follow._expression_in_expression1213);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(260, 73);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.intType();

    			}
    			break;
    		case 12:
    			DebugEnterAlt(12);
    			// GenericEvilTreeParser.g:261:4: ^(a= DIVIDE e1= expression[stypes,stable] e2= expression[stypes,stable] )
    			{
    			DebugLocation(261, 4);
    			DebugLocation(261, 7);
    			a=(CommonTree)Match(input,DIVIDE,Follow._DIVIDE_in_expression1225); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(261, 17);
    			PushFollow(Follow._expression_in_expression1229);
    			e1=expression(stypes, stable);
    			PopFollow();

    			DebugLocation(261, 46);
    			PushFollow(Follow._expression_in_expression1234);
    			e2=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(261, 74);
    			ensureInt((a!=null?a.Line:0), e1, e2); t = Type.intType();

    			}
    			break;
    		case 13:
    			DebugEnterAlt(13);
    			// GenericEvilTreeParser.g:262:4: ^(a= NOT e= expression[stypes,stable] )
    			{
    			DebugLocation(262, 4);
    			DebugLocation(262, 7);
    			a=(CommonTree)Match(input,NOT,Follow._NOT_in_expression1246); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(262, 13);
    			PushFollow(Follow._expression_in_expression1250);
    			e=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(262, 41);
    			ensureBool((a!=null?a.Line:0), e, Type.boolType()); t = Type.boolType();

    			}
    			break;
    		case 14:
    			DebugEnterAlt(14);
    			// GenericEvilTreeParser.g:263:4: ^(a= NEG e= expression[stypes,stable] )
    			{
    			DebugLocation(263, 4);
    			DebugLocation(263, 7);
    			a=(CommonTree)Match(input,NEG,Follow._NEG_in_expression1262); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(263, 13);
    			PushFollow(Follow._expression_in_expression1266);
    			e=expression(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(263, 41);
    			ensureInt((a!=null?a.Line:0), e, Type.intType()); t = Type.intType();

    			}
    			break;
    		case 15:
    			DebugEnterAlt(15);
    			// GenericEvilTreeParser.g:264:4: s= selector[stypes,stable]
    			{
    			DebugLocation(264, 5);
    			PushFollow(Follow._selector_in_expression1277);
    			s=selector(stypes, stable);
    			PopFollow();

    			DebugLocation(264, 30);
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
     	DebugLocation(265, 1);
    	} finally { DebugExitRule(GrammarFileName, "expression"); }
    	return t;

    }
    // $ANTLR end "expression"


    protected virtual void Enter_selector() {}
    protected virtual void Leave_selector() {}

    // $ANTLR start "selector"
    // GenericEvilTreeParser.g:267:1: selector[StructTypes stypes,SymbolTable stable] returns [Type t = null] : ( ^( DOT s= selector[stypes,stable] id= ID ) | f= factor[stypes,stable] );
    [GrammarRule("selector")]
    private Type selector(StructTypes stypes, SymbolTable stable)
    {

        Type t =  null;

        CommonTree id=null;
        Type s = default(Type);
        Type f = default(Type);

    	try { DebugEnterRule(GrammarFileName, "selector");
    	DebugLocation(267, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:268:2: ( ^( DOT s= selector[stypes,stable] id= ID ) | f= factor[stypes,stable] )
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
    			// GenericEvilTreeParser.g:268:4: ^( DOT s= selector[stypes,stable] id= ID )
    			{
    			DebugLocation(268, 4);
    			DebugLocation(268, 6);
    			Match(input,DOT,Follow._DOT_in_selector1297); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(268, 11);
    			PushFollow(Follow._selector_in_selector1301);
    			s=selector(stypes, stable);
    			PopFollow();

    			DebugLocation(268, 38);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_selector1306); 

    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(268, 43);
    			 t = getFieldType(stypes, s, id); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:269:4: f= factor[stypes,stable]
    			{
    			DebugLocation(269, 5);
    			PushFollow(Follow._factor_in_selector1316);
    			f=factor(stypes, stable);
    			PopFollow();

    			DebugLocation(269, 28);
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
     	DebugLocation(270, 1);
    	} finally { DebugExitRule(GrammarFileName, "selector"); }
    	return t;

    }
    // $ANTLR end "selector"


    protected virtual void Enter_factor() {}
    protected virtual void Leave_factor() {}

    // $ANTLR start "factor"
    // GenericEvilTreeParser.g:272:1: factor[StructTypes stypes,SymbolTable stable] returns [Type t = null] : ( ^( INVOKE id= ID args= arguments[stypes,stable] ) | id= ID | INTEGER | TRUE | FALSE | ^( NEW id= ID ) | NULL );
    [GrammarRule("factor")]
    private Type factor(StructTypes stypes, SymbolTable stable)
    {

        Type t =  null;

        CommonTree id=null;
        List<Type> args = default(List<Type>);

    	try { DebugEnterRule(GrammarFileName, "factor");
    	DebugLocation(272, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:273:2: ( ^( INVOKE id= ID args= arguments[stypes,stable] ) | id= ID | INTEGER | TRUE | FALSE | ^( NEW id= ID ) | NULL )
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
    			// GenericEvilTreeParser.g:273:4: ^( INVOKE id= ID args= arguments[stypes,stable] )
    			{
    			DebugLocation(273, 4);
    			DebugLocation(273, 6);
    			Match(input,INVOKE,Follow._INVOKE_in_factor1336); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(273, 15);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_factor1340); 
    			DebugLocation(273, 23);
    			PushFollow(Follow._arguments_in_factor1344);
    			args=arguments(stypes, stable);
    			PopFollow();


    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(273, 50);
    			t = getFun(stable, id,args); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// GenericEvilTreeParser.g:274:4: id= ID
    			{
    			DebugLocation(274, 6);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_factor1355); 
    			DebugLocation(274, 10);
    			t = getVar(stable, id);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// GenericEvilTreeParser.g:275:4: INTEGER
    			{
    			DebugLocation(275, 4);
    			Match(input,INTEGER,Follow._INTEGER_in_factor1362); 
    			DebugLocation(275, 12);
    			t = Type.intType();

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// GenericEvilTreeParser.g:276:4: TRUE
    			{
    			DebugLocation(276, 4);
    			Match(input,TRUE,Follow._TRUE_in_factor1369); 
    			DebugLocation(276, 9);
    			t = Type.boolType();

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// GenericEvilTreeParser.g:277:4: FALSE
    			{
    			DebugLocation(277, 4);
    			Match(input,FALSE,Follow._FALSE_in_factor1376); 
    			DebugLocation(277, 9);
    			t = Type.boolType();

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// GenericEvilTreeParser.g:278:4: ^( NEW id= ID )
    			{
    			DebugLocation(278, 4);
    			DebugLocation(278, 6);
    			Match(input,NEW,Follow._NEW_in_factor1383); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(278, 12);
    			id=(CommonTree)Match(input,ID,Follow._ID_in_factor1387); 

    			Match(input, TokenTypes.Up, null); 
    			DebugLocation(278, 17);
    			t = getStruct(stypes, id);

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// GenericEvilTreeParser.g:279:4: NULL
    			{
    			DebugLocation(279, 4);
    			Match(input,NULL,Follow._NULL_in_factor1395); 
    			DebugLocation(279, 9);
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
     	DebugLocation(280, 1);
    	} finally { DebugExitRule(GrammarFileName, "factor"); }
    	return t;

    }
    // $ANTLR end "factor"


    protected virtual void Enter_arguments() {}
    protected virtual void Leave_arguments() {}

    // $ANTLR start "arguments"
    // GenericEvilTreeParser.g:282:1: arguments[StructTypes stypes,SymbolTable stable] returns [List<Type> ret = null] : args= arg_list[stypes,stable] ;
    [GrammarRule("arguments")]
    private List<Type> arguments(StructTypes stypes, SymbolTable stable)
    {

        List<Type> ret =  null;

        List<Type> args = default(List<Type>);

    	try { DebugEnterRule(GrammarFileName, "arguments");
    	DebugLocation(282, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:283:2: (args= arg_list[stypes,stable] )
    		DebugEnterAlt(1);
    		// GenericEvilTreeParser.g:283:4: args= arg_list[stypes,stable]
    		{
    		DebugLocation(283, 8);
    		PushFollow(Follow._arg_list_in_arguments1415);
    		args=arg_list(stypes, stable);
    		PopFollow();

    		DebugLocation(283, 33);
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
     	DebugLocation(284, 1);
    	} finally { DebugExitRule(GrammarFileName, "arguments"); }
    	return ret;

    }
    // $ANTLR end "arguments"


    protected virtual void Enter_arg_list() {}
    protected virtual void Leave_arg_list() {}

    // $ANTLR start "arg_list"
    // GenericEvilTreeParser.g:286:1: arg_list[StructTypes stypes,SymbolTable stable] returns [List<Type> args = new List<Type>()] : ( ^( ARGS (e= expression[stypes,stable] )+ ) | ARGS );
    [GrammarRule("arg_list")]
    private List<Type> arg_list(StructTypes stypes, SymbolTable stable)
    {

        List<Type> args =  new List<Type>();

        Type e = default(Type);

    	try { DebugEnterRule(GrammarFileName, "arg_list");
    	DebugLocation(286, 1);
    	try
    	{
    		// GenericEvilTreeParser.g:287:2: ( ^( ARGS (e= expression[stypes,stable] )+ ) | ARGS )
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
    			// GenericEvilTreeParser.g:287:4: ^( ARGS (e= expression[stypes,stable] )+ )
    			{
    			DebugLocation(287, 4);
    			DebugLocation(287, 6);
    			Match(input,ARGS,Follow._ARGS_in_arg_list1435); 

    			Match(input, TokenTypes.Down, null); 
    			DebugLocation(287, 11);
    			// GenericEvilTreeParser.g:287:11: (e= expression[stypes,stable] )+
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
    					// GenericEvilTreeParser.g:287:12: e= expression[stypes,stable]
    					{
    					DebugLocation(287, 13);
    					PushFollow(Follow._expression_in_arg_list1440);
    					e=expression(stypes, stable);
    					PopFollow();

    					DebugLocation(287, 39);
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
    			// GenericEvilTreeParser.g:288:4: ARGS
    			{
    			DebugLocation(288, 4);
    			Match(input,ARGS,Follow._ARGS_in_arg_list1451); 

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
     	DebugLocation(289, 1);
    	} finally { DebugExitRule(GrammarFileName, "arg_list"); }
    	return args;

    }
    // $ANTLR end "arg_list"

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _PROGRAM_in_program52 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _types_in_program55 = new BitSet(new ulong[]{0x0000000003000000UL});
		public static readonly BitSet _declarations_in_program58 = new BitSet(new ulong[]{0x0000000003000000UL});
		public static readonly BitSet _functions_in_program61 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _TYPES_in_types85 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _types_sub_in_types87 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _TYPES_in_types97 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRUCT_in_type_declaration121 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_type_declaration126 = new BitSet(new ulong[]{0x0000000004000000UL});
		public static readonly BitSet _nested_decl_in_type_declaration145 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _field_decl_in_nested_decl179 = new BitSet(new ulong[]{0x0000000004000002UL});
		public static readonly BitSet _type_declaration_in_types_sub201 = new BitSet(new ulong[]{0x0000000000000010UL});
		public static readonly BitSet _types_sub_in_types_sub204 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _DECL_in_field_decl232 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _TYPE_in_field_decl235 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _type_in_field_decl239 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _ID_in_field_decl245 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _INT_in_type269 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BOOL_in_type276 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRUCT_in_type284 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_type288 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _DECLS_in_declarations305 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _declaration_in_declarations307 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _decl_list_in_declaration327 = new BitSet(new ulong[]{0x0000000008000002UL});
		public static readonly BitSet _DECLLIST_in_decl_list343 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _TYPE_in_decl_list346 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _type_in_decl_list350 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _id_list_in_decl_list354 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _ID_in_id_list374 = new BitSet(new ulong[]{0x0100000000000002UL});
		public static readonly BitSet _FUNCS_in_functions395 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _function_in_functions397 = new BitSet(new ulong[]{0x0000000000000088UL});
		public static readonly BitSet _FUN_in_function419 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_function423 = new BitSet(new ulong[]{0x0000000010000000UL});
		public static readonly BitSet _parameters_in_function427 = new BitSet(new ulong[]{0x0000000020000000UL});
		public static readonly BitSet _RETTYPE_in_function431 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _return_type_in_function435 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _declarations_in_function441 = new BitSet(new ulong[]{0x0000000080000000UL});
		public static readonly BitSet _statement_list_in_function449 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _PARAMS_in_parameters468 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _param_decl_in_parameters470 = new BitSet(new ulong[]{0x0000000004000008UL});
		public static readonly BitSet _DECL_in_param_decl490 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _TYPE_in_param_decl493 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _type_in_param_decl497 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _ID_in_param_decl503 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _type_in_return_type528 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VOID_in_return_type536 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _block_in_statement556 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assignment_in_statement566 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _print_in_statement576 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _read_in_statement586 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _conditional_in_statement596 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _loop_in_statement606 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _delete_in_statement616 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ret_in_statement626 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _invocation_in_statement636 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BLOCK_in_block656 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _statement_list_in_block660 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _STMTS_in_statement_list681 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _statement_in_statement_list686 = new BitSet(new ulong[]{0x000002014001DA08UL});
		public static readonly BitSet _ASSIGN_in_assignment713 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_assignment715 = new BitSet(new ulong[]{0x0100040000000000UL});
		public static readonly BitSet _lvalue_in_assignment718 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _PRINT_in_print737 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_print739 = new BitSet(new ulong[]{0x0000000000000408UL});
		public static readonly BitSet _ENDL_in_print743 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _READ_in_read763 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _lvalue_in_read765 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _IF_in_conditional786 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_conditional790 = new BitSet(new ulong[]{0x0000000040000000UL});
		public static readonly BitSet _block_in_conditional795 = new BitSet(new ulong[]{0x0000000040000008UL});
		public static readonly BitSet _block_in_conditional801 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _WHILE_in_loop828 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_loop832 = new BitSet(new ulong[]{0x0000000040000000UL});
		public static readonly BitSet _block_in_loop837 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_loop840 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _DELETE_in_delete865 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_delete869 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _RETURN_in_ret895 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_ret900 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _INVOKE_in_invocation925 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_invocation929 = new BitSet(new ulong[]{0x0000000200000000UL});
		public static readonly BitSet _arguments_in_invocation933 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _DOT_in_lvalue954 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _lvalue_in_lvalue958 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_lvalue963 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _ID_in_lvalue973 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _AND_in_expression994 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression998 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1003 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _OR_in_expression1015 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1019 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1024 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _EQ_in_expression1036 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1040 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1045 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _LT_in_expression1057 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1061 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1066 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _GT_in_expression1078 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1082 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1087 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _NE_in_expression1099 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1103 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1108 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _LE_in_expression1120 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1124 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1129 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _GE_in_expression1141 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1145 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1150 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _PLUS_in_expression1162 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1166 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1171 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _MINUS_in_expression1183 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1187 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1192 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _TIMES_in_expression1204 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1208 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1213 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _DIVIDE_in_expression1225 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1229 = new BitSet(new ulong[]{0x03FFFC05001E0000UL});
		public static readonly BitSet _expression_in_expression1234 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _NOT_in_expression1246 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1250 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _NEG_in_expression1262 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_expression1266 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _selector_in_expression1277 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _DOT_in_selector1297 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _selector_in_selector1301 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_selector1306 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _factor_in_selector1316 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INVOKE_in_factor1336 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_factor1340 = new BitSet(new ulong[]{0x0000000200000000UL});
		public static readonly BitSet _arguments_in_factor1344 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _ID_in_factor1355 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INTEGER_in_factor1362 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _TRUE_in_factor1369 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FALSE_in_factor1376 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NEW_in_factor1383 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _ID_in_factor1387 = new BitSet(new ulong[]{0x0000000000000008UL});
		public static readonly BitSet _NULL_in_factor1395 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arg_list_in_arguments1415 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ARGS_in_arg_list1435 = new BitSet(new ulong[]{0x0000000000000004UL});
		public static readonly BitSet _expression_in_arg_list1440 = new BitSet(new ulong[]{0x03FFFC05001E0008UL});
		public static readonly BitSet _ARGS_in_arg_list1451 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
