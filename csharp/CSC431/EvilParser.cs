// $ANTLR 3.3 Nov 30, 2010 12:50:56 Evil.g 2011-01-15 13:44:21

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


   /* package declaration here */
   



using System;
using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace CSC431
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class EvilParser : Antlr.Runtime.Parser
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
				true, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public EvilParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public EvilParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	void CreateTreeAdaptor(ref ITreeAdaptor adaptor) {}

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return EvilParser.tokenNames; } }
	public override string GrammarFileName { get { return "Evil.g"; } }



 	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_program() {}
    protected virtual void Leave_program() {}

    // $ANTLR start "program"
    // Evil.g:108:1: program : t= types d= declarations f= functions EOF -> ^( PROGRAM $t $d $f) ;
    [GrammarRule("program")]
    private EvilParser.program_return program()
    {

        EvilParser.program_return retval = new EvilParser.program_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken EOF1=null;
        EvilParser.types_return t = default(EvilParser.types_return);
        EvilParser.declarations_return d = default(EvilParser.declarations_return);
        EvilParser.functions_return f = default(EvilParser.functions_return);

        object EOF1_tree=null;
        RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
        RewriteRuleSubtreeStream stream_functions=new RewriteRuleSubtreeStream(adaptor,"rule functions");
        RewriteRuleSubtreeStream stream_types=new RewriteRuleSubtreeStream(adaptor,"rule types");
        RewriteRuleSubtreeStream stream_declarations=new RewriteRuleSubtreeStream(adaptor,"rule declarations");
    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(108, 3);
    	try
    	{
    		// Evil.g:109:4: (t= types d= declarations f= functions EOF -> ^( PROGRAM $t $d $f) )
    		DebugEnterAlt(1);
    		// Evil.g:109:7: t= types d= declarations f= functions EOF
    		{
    		DebugLocation(109, 8);
    		PushFollow(Follow._types_in_program1066);
    		t=types();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_types.Add(t.Tree);
    		DebugLocation(109, 16);
    		PushFollow(Follow._declarations_in_program1070);
    		d=declarations();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_declarations.Add(d.Tree);
    		DebugLocation(109, 31);
    		PushFollow(Follow._functions_in_program1074);
    		f=functions();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_functions.Add(f.Tree);
    		DebugLocation(109, 42);
    		EOF1=(IToken)Match(input,EOF,Follow._EOF_in_program1076); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_EOF.Add(EOF1);



    		{
    		// AST REWRITE
    		// elements: f, t, d
    		// token labels: 
    		// rule labels: f, retval, d, t
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_f=new RewriteRuleSubtreeStream(adaptor,"rule f",f!=null?f.Tree:null);
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    		RewriteRuleSubtreeStream stream_d=new RewriteRuleSubtreeStream(adaptor,"rule d",d!=null?d.Tree:null);
    		RewriteRuleSubtreeStream stream_t=new RewriteRuleSubtreeStream(adaptor,"rule t",t!=null?t.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 110:7: -> ^( PROGRAM $t $d $f)
    		{
    			DebugLocation(110, 10);
    			// Evil.g:110:10: ^( PROGRAM $t $d $f)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(110, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

    			DebugLocation(110, 20);
    			adaptor.AddChild(root_1, stream_t.NextTree());
    			DebugLocation(110, 23);
    			adaptor.AddChild(root_1, stream_d.NextTree());
    			DebugLocation(110, 26);
    			adaptor.AddChild(root_1, stream_f.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(111, 3);
    	} finally { DebugExitRule(GrammarFileName, "program"); }
    	return retval;

    }
    // $ANTLR end "program"

    public class types_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_types() {}
    protected virtual void Leave_types() {}

    // $ANTLR start "types"
    // Evil.g:112:1: types : ( ( STRUCT ID LBRACE )=> types_sub -> ^( TYPES types_sub ) | -> TYPES );
    [GrammarRule("types")]
    private EvilParser.types_return types()
    {

        EvilParser.types_return retval = new EvilParser.types_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.types_sub_return types_sub2 = default(EvilParser.types_sub_return);

        RewriteRuleSubtreeStream stream_types_sub=new RewriteRuleSubtreeStream(adaptor,"rule types_sub");
    	try { DebugEnterRule(GrammarFileName, "types");
    	DebugLocation(112, 3);
    	try
    	{
    		// Evil.g:113:4: ( ( STRUCT ID LBRACE )=> types_sub -> ^( TYPES types_sub ) | -> TYPES )
    		int alt1=2;
    		try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    		switch (input.LA(1))
    		{
    		case STRUCT:
    			{
    			int LA1_1 = input.LA(2);

    			if ((EvaluatePredicate(synpred1_Evil_fragment)))
    			{
    				alt1=1;
    			}
    			else if ((true))
    			{
    				alt1=2;
    			}
    			else
    			{
    				if (state.backtracking>0) {state.failed=true; return retval;}
    				NoViableAltException nvae = new NoViableAltException("", 1, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    			}
    			break;
    		case INT:
    			{
    			int LA1_2 = input.LA(2);

    			if ((EvaluatePredicate(synpred1_Evil_fragment)))
    			{
    				alt1=1;
    			}
    			else if ((true))
    			{
    				alt1=2;
    			}
    			else
    			{
    				if (state.backtracking>0) {state.failed=true; return retval;}
    				NoViableAltException nvae = new NoViableAltException("", 1, 2, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    			}
    			break;
    		case BOOL:
    			{
    			int LA1_3 = input.LA(2);

    			if ((EvaluatePredicate(synpred1_Evil_fragment)))
    			{
    				alt1=1;
    			}
    			else if ((true))
    			{
    				alt1=2;
    			}
    			else
    			{
    				if (state.backtracking>0) {state.failed=true; return retval;}
    				NoViableAltException nvae = new NoViableAltException("", 1, 3, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    			}
    			break;
    		case FUN:
    			{
    			int LA1_4 = input.LA(2);

    			if ((EvaluatePredicate(synpred1_Evil_fragment)))
    			{
    				alt1=1;
    			}
    			else if ((true))
    			{
    				alt1=2;
    			}
    			else
    			{
    				if (state.backtracking>0) {state.failed=true; return retval;}
    				NoViableAltException nvae = new NoViableAltException("", 1, 4, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    			}
    			break;
    		case EOF:
    			{
    			int LA1_5 = input.LA(2);

    			if ((EvaluatePredicate(synpred1_Evil_fragment)))
    			{
    				alt1=1;
    			}
    			else if ((true))
    			{
    				alt1=2;
    			}
    			else
    			{
    				if (state.backtracking>0) {state.failed=true; return retval;}
    				NoViableAltException nvae = new NoViableAltException("", 1, 5, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    			}
    			break;
    		default:
    			{
    				if (state.backtracking>0) {state.failed=true; return retval;}
    				NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(1); }
    		switch (alt1)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:113:7: ( STRUCT ID LBRACE )=> types_sub
    			{
    			DebugLocation(113, 29);
    			PushFollow(Follow._types_sub_in_types1122);
    			types_sub2=types_sub();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) stream_types_sub.Add(types_sub2.Tree);


    			{
    			// AST REWRITE
    			// elements: types_sub
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			if ( (state.backtracking==0) ) {
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 113:39: -> ^( TYPES types_sub )
    			{
    				DebugLocation(113, 42);
    				// Evil.g:113:42: ^( TYPES types_sub )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(113, 44);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPES, "TYPES"), root_1);

    				DebugLocation(113, 50);
    				adaptor.AddChild(root_1, stream_types_sub.NextTree());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:114:7: 
    			{

    			{
    			// AST REWRITE
    			// elements: 
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			if ( (state.backtracking==0) ) {
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 114:7: -> TYPES
    			{
    				DebugLocation(114, 10);
    				adaptor.AddChild(root_0, (object)adaptor.Create(TYPES, "TYPES"));

    			}

    			retval.Tree = root_0;
    			}
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(115, 3);
    	} finally { DebugExitRule(GrammarFileName, "types"); }
    	return retval;

    }
    // $ANTLR end "types"

    public class types_sub_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_types_sub() {}
    protected virtual void Leave_types_sub() {}

    // $ANTLR start "types_sub"
    // Evil.g:116:1: types_sub : ( ( STRUCT ID LBRACE )=> type_declaration types_sub | );
    [GrammarRule("types_sub")]
    private EvilParser.types_sub_return types_sub()
    {

        EvilParser.types_sub_return retval = new EvilParser.types_sub_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.type_declaration_return type_declaration3 = default(EvilParser.type_declaration_return);
        EvilParser.types_sub_return types_sub4 = default(EvilParser.types_sub_return);


    	try { DebugEnterRule(GrammarFileName, "types_sub");
    	DebugLocation(116, 3);
    	try
    	{
    		// Evil.g:117:4: ( ( STRUCT ID LBRACE )=> type_declaration types_sub | )
    		int alt2=2;
    		try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    		int LA2_0 = input.LA(1);

    		if ((LA2_0==STRUCT))
    		{
    			int LA2_1 = input.LA(2);

    			if ((LA2_1==ID))
    			{
    				int LA2_3 = input.LA(3);

    				if ((LA2_3==LBRACE) && (EvaluatePredicate(synpred2_Evil_fragment)))
    				{
    					alt2=1;
    				}
    				else if ((LA2_3==ID))
    				{
    					alt2=2;
    				}
    				else
    				{
    					if (state.backtracking>0) {state.failed=true; return retval;}
    					NoViableAltException nvae = new NoViableAltException("", 2, 3, input);

    					DebugRecognitionException(nvae);
    					throw nvae;
    				}
    			}
    			else
    			{
    				if (state.backtracking>0) {state.failed=true; return retval;}
    				NoViableAltException nvae = new NoViableAltException("", 2, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else if ((LA2_0==EOF||(LA2_0>=INT && LA2_0<=FUN)))
    		{
    			alt2=2;
    		}
    		else
    		{
    			if (state.backtracking>0) {state.failed=true; return retval;}
    			NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(2); }
    		switch (alt2)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:117:7: ( STRUCT ID LBRACE )=> type_declaration types_sub
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(117, 29);
    			PushFollow(Follow._type_declaration_in_types_sub1165);
    			type_declaration3=type_declaration();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, type_declaration3.Tree);
    			DebugLocation(117, 46);
    			PushFollow(Follow._types_sub_in_types_sub1167);
    			types_sub4=types_sub();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, types_sub4.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:119:4: 
    			{
    			root_0 = (object)adaptor.Nil();

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(119, 3);
    	} finally { DebugExitRule(GrammarFileName, "types_sub"); }
    	return retval;

    }
    // $ANTLR end "types_sub"

    public class type_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_type_declaration() {}
    protected virtual void Leave_type_declaration() {}

    // $ANTLR start "type_declaration"
    // Evil.g:120:1: type_declaration : STRUCT ID LBRACE nested_decl RBRACE SEMI ;
    [GrammarRule("type_declaration")]
    private EvilParser.type_declaration_return type_declaration()
    {

        EvilParser.type_declaration_return retval = new EvilParser.type_declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken STRUCT5=null;
        IToken ID6=null;
        IToken LBRACE7=null;
        IToken RBRACE9=null;
        IToken SEMI10=null;
        EvilParser.nested_decl_return nested_decl8 = default(EvilParser.nested_decl_return);

        object STRUCT5_tree=null;
        object ID6_tree=null;
        object LBRACE7_tree=null;
        object RBRACE9_tree=null;
        object SEMI10_tree=null;

    	try { DebugEnterRule(GrammarFileName, "type_declaration");
    	DebugLocation(120, 3);
    	try
    	{
    		// Evil.g:121:4: ( STRUCT ID LBRACE nested_decl RBRACE SEMI )
    		DebugEnterAlt(1);
    		// Evil.g:121:7: STRUCT ID LBRACE nested_decl RBRACE SEMI
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(121, 13);
    		STRUCT5=(IToken)Match(input,STRUCT,Follow._STRUCT_in_type_declaration1187); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		STRUCT5_tree = (object)adaptor.Create(STRUCT5);
    		root_0 = (object)adaptor.BecomeRoot(STRUCT5_tree, root_0);
    		}
    		DebugLocation(121, 15);
    		ID6=(IToken)Match(input,ID,Follow._ID_in_type_declaration1190); if (state.failed) return retval;
    		if ( state.backtracking==0 ) {
    		ID6_tree = (object)adaptor.Create(ID6);
    		adaptor.AddChild(root_0, ID6_tree);
    		}
    		DebugLocation(121, 24);
    		LBRACE7=(IToken)Match(input,LBRACE,Follow._LBRACE_in_type_declaration1192); if (state.failed) return retval;
    		DebugLocation(121, 26);
    		PushFollow(Follow._nested_decl_in_type_declaration1195);
    		nested_decl8=nested_decl();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, nested_decl8.Tree);
    		DebugLocation(121, 44);
    		RBRACE9=(IToken)Match(input,RBRACE,Follow._RBRACE_in_type_declaration1197); if (state.failed) return retval;
    		DebugLocation(121, 50);
    		SEMI10=(IToken)Match(input,SEMI,Follow._SEMI_in_type_declaration1200); if (state.failed) return retval;

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(122, 3);
    	} finally { DebugExitRule(GrammarFileName, "type_declaration"); }
    	return retval;

    }
    // $ANTLR end "type_declaration"

    public class nested_decl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_nested_decl() {}
    protected virtual void Leave_nested_decl() {}

    // $ANTLR start "nested_decl"
    // Evil.g:123:1: nested_decl : ( decl SEMI )+ ;
    [GrammarRule("nested_decl")]
    private EvilParser.nested_decl_return nested_decl()
    {

        EvilParser.nested_decl_return retval = new EvilParser.nested_decl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken SEMI12=null;
        EvilParser.decl_return decl11 = default(EvilParser.decl_return);

        object SEMI12_tree=null;

    	try { DebugEnterRule(GrammarFileName, "nested_decl");
    	DebugLocation(123, 3);
    	try
    	{
    		// Evil.g:124:4: ( ( decl SEMI )+ )
    		DebugEnterAlt(1);
    		// Evil.g:124:7: ( decl SEMI )+
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(124, 7);
    		// Evil.g:124:7: ( decl SEMI )+
    		int cnt3=0;
    		try { DebugEnterSubRule(3);
    		while (true)
    		{
    			int alt3=2;
    			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    			int LA3_0 = input.LA(1);

    			if (((LA3_0>=STRUCT && LA3_0<=BOOL)))
    			{
    				alt3=1;
    			}


    			} finally { DebugExitDecision(3); }
    			switch (alt3)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:124:8: decl SEMI
    				{
    				DebugLocation(124, 8);
    				PushFollow(Follow._decl_in_nested_decl1217);
    				decl11=decl();
    				PopFollow();
    				if (state.failed) return retval;
    				if ( (state.backtracking==0) ) adaptor.AddChild(root_0, decl11.Tree);
    				DebugLocation(124, 17);
    				SEMI12=(IToken)Match(input,SEMI,Follow._SEMI_in_nested_decl1219); if (state.failed) return retval;

    				}
    				break;

    			default:
    				if (cnt3 >= 1)
    					goto loop3;

    				if (state.backtracking>0) {state.failed=true; return retval;}
    				EarlyExitException eee3 = new EarlyExitException( 3, input );
    				DebugRecognitionException(eee3);
    				throw eee3;
    			}
    			cnt3++;
    		}
    		loop3:
    			;

    		} finally { DebugExitSubRule(3); }


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(125, 3);
    	} finally { DebugExitRule(GrammarFileName, "nested_decl"); }
    	return retval;

    }
    // $ANTLR end "nested_decl"

    public class decl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_decl() {}
    protected virtual void Leave_decl() {}

    // $ANTLR start "decl"
    // Evil.g:126:1: decl : t= type i= ID -> ^( DECL ^( TYPE $t) $i) ;
    [GrammarRule("decl")]
    private EvilParser.decl_return decl()
    {

        EvilParser.decl_return retval = new EvilParser.decl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken i=null;
        EvilParser.type_return t = default(EvilParser.type_return);

        object i_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
    	try { DebugEnterRule(GrammarFileName, "decl");
    	DebugLocation(126, 3);
    	try
    	{
    		// Evil.g:127:4: (t= type i= ID -> ^( DECL ^( TYPE $t) $i) )
    		DebugEnterAlt(1);
    		// Evil.g:127:7: t= type i= ID
    		{
    		DebugLocation(127, 8);
    		PushFollow(Follow._type_in_decl1239);
    		t=type();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_type.Add(t.Tree);
    		DebugLocation(127, 15);
    		i=(IToken)Match(input,ID,Follow._ID_in_decl1243); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_ID.Add(i);



    		{
    		// AST REWRITE
    		// elements: i, t
    		// token labels: i
    		// rule labels: retval, t
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleITokenStream stream_i=new RewriteRuleITokenStream(adaptor,"token i",i);
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    		RewriteRuleSubtreeStream stream_t=new RewriteRuleSubtreeStream(adaptor,"rule t",t!=null?t.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 128:7: -> ^( DECL ^( TYPE $t) $i)
    		{
    			DebugLocation(128, 10);
    			// Evil.g:128:10: ^( DECL ^( TYPE $t) $i)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(128, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECL, "DECL"), root_1);

    			DebugLocation(128, 17);
    			// Evil.g:128:17: ^( TYPE $t)
    			{
    			object root_2 = (object)adaptor.Nil();
    			DebugLocation(128, 19);
    			root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE, "TYPE"), root_2);

    			DebugLocation(128, 24);
    			adaptor.AddChild(root_2, stream_t.NextTree());

    			adaptor.AddChild(root_1, root_2);
    			}
    			DebugLocation(128, 28);
    			adaptor.AddChild(root_1, stream_i.NextNode());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(129, 3);
    	} finally { DebugExitRule(GrammarFileName, "decl"); }
    	return retval;

    }
    // $ANTLR end "decl"

    public class type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_type() {}
    protected virtual void Leave_type() {}

    // $ANTLR start "type"
    // Evil.g:130:1: type : ( INT | BOOL | STRUCT ID );
    [GrammarRule("type")]
    private EvilParser.type_return type()
    {

        EvilParser.type_return retval = new EvilParser.type_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken INT13=null;
        IToken BOOL14=null;
        IToken STRUCT15=null;
        IToken ID16=null;

        object INT13_tree=null;
        object BOOL14_tree=null;
        object STRUCT15_tree=null;
        object ID16_tree=null;

    	try { DebugEnterRule(GrammarFileName, "type");
    	DebugLocation(130, 3);
    	try
    	{
    		// Evil.g:131:4: ( INT | BOOL | STRUCT ID )
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
    				if (state.backtracking>0) {state.failed=true; return retval;}
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
    			// Evil.g:131:7: INT
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(131, 7);
    			INT13=(IToken)Match(input,INT,Follow._INT_in_type1280); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			INT13_tree = (object)adaptor.Create(INT13);
    			adaptor.AddChild(root_0, INT13_tree);
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:132:7: BOOL
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(132, 7);
    			BOOL14=(IToken)Match(input,BOOL,Follow._BOOL_in_type1288); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			BOOL14_tree = (object)adaptor.Create(BOOL14);
    			adaptor.AddChild(root_0, BOOL14_tree);
    			}

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Evil.g:133:7: STRUCT ID
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(133, 13);
    			STRUCT15=(IToken)Match(input,STRUCT,Follow._STRUCT_in_type1296); if (state.failed) return retval;
    			if ( (state.backtracking==0) ) {
    			STRUCT15_tree = (object)adaptor.Create(STRUCT15);
    			root_0 = (object)adaptor.BecomeRoot(STRUCT15_tree, root_0);
    			}
    			DebugLocation(133, 15);
    			ID16=(IToken)Match(input,ID,Follow._ID_in_type1299); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			ID16_tree = (object)adaptor.Create(ID16);
    			adaptor.AddChild(root_0, ID16_tree);
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(134, 3);
    	} finally { DebugExitRule(GrammarFileName, "type"); }
    	return retval;

    }
    // $ANTLR end "type"

    public class declarations_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_declarations() {}
    protected virtual void Leave_declarations() {}

    // $ANTLR start "declarations"
    // Evil.g:135:1: declarations : ( declaration )* -> ^( DECLS ( declaration )* ) ;
    [GrammarRule("declarations")]
    private EvilParser.declarations_return declarations()
    {

        EvilParser.declarations_return retval = new EvilParser.declarations_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.declaration_return declaration17 = default(EvilParser.declaration_return);

        RewriteRuleSubtreeStream stream_declaration=new RewriteRuleSubtreeStream(adaptor,"rule declaration");
    	try { DebugEnterRule(GrammarFileName, "declarations");
    	DebugLocation(135, 3);
    	try
    	{
    		// Evil.g:136:4: ( ( declaration )* -> ^( DECLS ( declaration )* ) )
    		DebugEnterAlt(1);
    		// Evil.g:136:7: ( declaration )*
    		{
    		DebugLocation(136, 7);
    		// Evil.g:136:7: ( declaration )*
    		try { DebugEnterSubRule(5);
    		while (true)
    		{
    			int alt5=2;
    			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    			int LA5_0 = input.LA(1);

    			if (((LA5_0>=STRUCT && LA5_0<=BOOL)))
    			{
    				alt5=1;
    			}


    			} finally { DebugExitDecision(5); }
    			switch ( alt5 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:136:8: declaration
    				{
    				DebugLocation(136, 8);
    				PushFollow(Follow._declaration_in_declarations1315);
    				declaration17=declaration();
    				PopFollow();
    				if (state.failed) return retval;
    				if ( (state.backtracking==0) ) stream_declaration.Add(declaration17.Tree);

    				}
    				break;

    			default:
    				goto loop5;
    			}
    		}

    		loop5:
    			;

    		} finally { DebugExitSubRule(5); }



    		{
    		// AST REWRITE
    		// elements: declaration
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 136:22: -> ^( DECLS ( declaration )* )
    		{
    			DebugLocation(136, 25);
    			// Evil.g:136:25: ^( DECLS ( declaration )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(136, 27);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECLS, "DECLS"), root_1);

    			DebugLocation(136, 33);
    			// Evil.g:136:33: ( declaration )*
    			while ( stream_declaration.HasNext )
    			{
    				DebugLocation(136, 33);
    				adaptor.AddChild(root_1, stream_declaration.NextTree());

    			}
    			stream_declaration.Reset();

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(137, 3);
    	} finally { DebugExitRule(GrammarFileName, "declarations"); }
    	return retval;

    }
    // $ANTLR end "declarations"

    public class declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_declaration() {}
    protected virtual void Leave_declaration() {}

    // $ANTLR start "declaration"
    // Evil.g:138:1: declaration : t= type ilist= id_list SEMI -> ^( DECLLIST ^( TYPE $t) $ilist) ;
    [GrammarRule("declaration")]
    private EvilParser.declaration_return declaration()
    {

        EvilParser.declaration_return retval = new EvilParser.declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken SEMI18=null;
        EvilParser.type_return t = default(EvilParser.type_return);
        EvilParser.id_list_return ilist = default(EvilParser.id_list_return);

        object SEMI18_tree=null;
        RewriteRuleITokenStream stream_SEMI=new RewriteRuleITokenStream(adaptor,"token SEMI");
        RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_id_list=new RewriteRuleSubtreeStream(adaptor,"rule id_list");
    	try { DebugEnterRule(GrammarFileName, "declaration");
    	DebugLocation(138, 3);
    	try
    	{
    		// Evil.g:139:4: (t= type ilist= id_list SEMI -> ^( DECLLIST ^( TYPE $t) $ilist) )
    		DebugEnterAlt(1);
    		// Evil.g:139:7: t= type ilist= id_list SEMI
    		{
    		DebugLocation(139, 8);
    		PushFollow(Follow._type_in_declaration1343);
    		t=type();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_type.Add(t.Tree);
    		DebugLocation(139, 19);
    		PushFollow(Follow._id_list_in_declaration1347);
    		ilist=id_list();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_id_list.Add(ilist.Tree);
    		DebugLocation(139, 28);
    		SEMI18=(IToken)Match(input,SEMI,Follow._SEMI_in_declaration1349); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_SEMI.Add(SEMI18);



    		{
    		// AST REWRITE
    		// elements: t, ilist
    		// token labels: 
    		// rule labels: retval, t, ilist
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    		RewriteRuleSubtreeStream stream_t=new RewriteRuleSubtreeStream(adaptor,"rule t",t!=null?t.Tree:null);
    		RewriteRuleSubtreeStream stream_ilist=new RewriteRuleSubtreeStream(adaptor,"rule ilist",ilist!=null?ilist.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 140:7: -> ^( DECLLIST ^( TYPE $t) $ilist)
    		{
    			DebugLocation(140, 10);
    			// Evil.g:140:10: ^( DECLLIST ^( TYPE $t) $ilist)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(140, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECLLIST, "DECLLIST"), root_1);

    			DebugLocation(140, 21);
    			// Evil.g:140:21: ^( TYPE $t)
    			{
    			object root_2 = (object)adaptor.Nil();
    			DebugLocation(140, 23);
    			root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE, "TYPE"), root_2);

    			DebugLocation(140, 28);
    			adaptor.AddChild(root_2, stream_t.NextTree());

    			adaptor.AddChild(root_1, root_2);
    			}
    			DebugLocation(140, 32);
    			adaptor.AddChild(root_1, stream_ilist.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(141, 3);
    	} finally { DebugExitRule(GrammarFileName, "declaration"); }
    	return retval;

    }
    // $ANTLR end "declaration"

    public class id_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_id_list() {}
    protected virtual void Leave_id_list() {}

    // $ANTLR start "id_list"
    // Evil.g:142:1: id_list : ID ( COMMA ID )* ;
    [GrammarRule("id_list")]
    private EvilParser.id_list_return id_list()
    {

        EvilParser.id_list_return retval = new EvilParser.id_list_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ID19=null;
        IToken COMMA20=null;
        IToken ID21=null;

        object ID19_tree=null;
        object COMMA20_tree=null;
        object ID21_tree=null;

    	try { DebugEnterRule(GrammarFileName, "id_list");
    	DebugLocation(142, 3);
    	try
    	{
    		// Evil.g:143:4: ( ID ( COMMA ID )* )
    		DebugEnterAlt(1);
    		// Evil.g:143:7: ID ( COMMA ID )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(143, 7);
    		ID19=(IToken)Match(input,ID,Follow._ID_in_id_list1386); if (state.failed) return retval;
    		if ( state.backtracking==0 ) {
    		ID19_tree = (object)adaptor.Create(ID19);
    		adaptor.AddChild(root_0, ID19_tree);
    		}
    		DebugLocation(143, 10);
    		// Evil.g:143:10: ( COMMA ID )*
    		try { DebugEnterSubRule(6);
    		while (true)
    		{
    			int alt6=2;
    			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    			int LA6_0 = input.LA(1);

    			if ((LA6_0==COMMA))
    			{
    				alt6=1;
    			}


    			} finally { DebugExitDecision(6); }
    			switch ( alt6 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:143:11: COMMA ID
    				{
    				DebugLocation(143, 16);
    				COMMA20=(IToken)Match(input,COMMA,Follow._COMMA_in_id_list1389); if (state.failed) return retval;
    				DebugLocation(143, 18);
    				ID21=(IToken)Match(input,ID,Follow._ID_in_id_list1392); if (state.failed) return retval;
    				if ( state.backtracking==0 ) {
    				ID21_tree = (object)adaptor.Create(ID21);
    				adaptor.AddChild(root_0, ID21_tree);
    				}

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

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(144, 3);
    	} finally { DebugExitRule(GrammarFileName, "id_list"); }
    	return retval;

    }
    // $ANTLR end "id_list"

    public class functions_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_functions() {}
    protected virtual void Leave_functions() {}

    // $ANTLR start "functions"
    // Evil.g:145:1: functions : ( function )* -> ^( FUNCS ( function )* ) ;
    [GrammarRule("functions")]
    private EvilParser.functions_return functions()
    {

        EvilParser.functions_return retval = new EvilParser.functions_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.function_return function22 = default(EvilParser.function_return);

        RewriteRuleSubtreeStream stream_function=new RewriteRuleSubtreeStream(adaptor,"rule function");
    	try { DebugEnterRule(GrammarFileName, "functions");
    	DebugLocation(145, 3);
    	try
    	{
    		// Evil.g:146:4: ( ( function )* -> ^( FUNCS ( function )* ) )
    		DebugEnterAlt(1);
    		// Evil.g:146:7: ( function )*
    		{
    		DebugLocation(146, 7);
    		// Evil.g:146:7: ( function )*
    		try { DebugEnterSubRule(7);
    		while (true)
    		{
    			int alt7=2;
    			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
    			int LA7_0 = input.LA(1);

    			if ((LA7_0==FUN))
    			{
    				alt7=1;
    			}


    			} finally { DebugExitDecision(7); }
    			switch ( alt7 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:146:7: function
    				{
    				DebugLocation(146, 7);
    				PushFollow(Follow._function_in_functions1409);
    				function22=function();
    				PopFollow();
    				if (state.failed) return retval;
    				if ( (state.backtracking==0) ) stream_function.Add(function22.Tree);

    				}
    				break;

    			default:
    				goto loop7;
    			}
    		}

    		loop7:
    			;

    		} finally { DebugExitSubRule(7); }



    		{
    		// AST REWRITE
    		// elements: function
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 146:17: -> ^( FUNCS ( function )* )
    		{
    			DebugLocation(146, 20);
    			// Evil.g:146:20: ^( FUNCS ( function )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(146, 22);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCS, "FUNCS"), root_1);

    			DebugLocation(146, 28);
    			// Evil.g:146:28: ( function )*
    			while ( stream_function.HasNext )
    			{
    				DebugLocation(146, 28);
    				adaptor.AddChild(root_1, stream_function.NextTree());

    			}
    			stream_function.Reset();

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(147, 3);
    	} finally { DebugExitRule(GrammarFileName, "functions"); }
    	return retval;

    }
    // $ANTLR end "functions"

    public class function_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_function() {}
    protected virtual void Leave_function() {}

    // $ANTLR start "function"
    // Evil.g:148:1: function : FUN id= ID p= parameters r= return_type LBRACE d= declarations s= statement_list RBRACE -> ^( FUN $id $p ^( RETTYPE $r) $d $s) ;
    [GrammarRule("function")]
    private EvilParser.function_return function()
    {

        EvilParser.function_return retval = new EvilParser.function_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken id=null;
        IToken FUN23=null;
        IToken LBRACE24=null;
        IToken RBRACE25=null;
        EvilParser.parameters_return p = default(EvilParser.parameters_return);
        EvilParser.return_type_return r = default(EvilParser.return_type_return);
        EvilParser.declarations_return d = default(EvilParser.declarations_return);
        EvilParser.statement_list_return s = default(EvilParser.statement_list_return);

        object id_tree=null;
        object FUN23_tree=null;
        object LBRACE24_tree=null;
        object RBRACE25_tree=null;
        RewriteRuleITokenStream stream_RBRACE=new RewriteRuleITokenStream(adaptor,"token RBRACE");
        RewriteRuleITokenStream stream_FUN=new RewriteRuleITokenStream(adaptor,"token FUN");
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_LBRACE=new RewriteRuleITokenStream(adaptor,"token LBRACE");
        RewriteRuleSubtreeStream stream_statement_list=new RewriteRuleSubtreeStream(adaptor,"rule statement_list");
        RewriteRuleSubtreeStream stream_parameters=new RewriteRuleSubtreeStream(adaptor,"rule parameters");
        RewriteRuleSubtreeStream stream_return_type=new RewriteRuleSubtreeStream(adaptor,"rule return_type");
        RewriteRuleSubtreeStream stream_declarations=new RewriteRuleSubtreeStream(adaptor,"rule declarations");
    	try { DebugEnterRule(GrammarFileName, "function");
    	DebugLocation(148, 3);
    	try
    	{
    		// Evil.g:149:4: ( FUN id= ID p= parameters r= return_type LBRACE d= declarations s= statement_list RBRACE -> ^( FUN $id $p ^( RETTYPE $r) $d $s) )
    		DebugEnterAlt(1);
    		// Evil.g:149:7: FUN id= ID p= parameters r= return_type LBRACE d= declarations s= statement_list RBRACE
    		{
    		DebugLocation(149, 7);
    		FUN23=(IToken)Match(input,FUN,Follow._FUN_in_function1434); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_FUN.Add(FUN23);

    		DebugLocation(149, 13);
    		id=(IToken)Match(input,ID,Follow._ID_in_function1438); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_ID.Add(id);

    		DebugLocation(149, 18);
    		PushFollow(Follow._parameters_in_function1442);
    		p=parameters();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_parameters.Add(p.Tree);
    		DebugLocation(149, 31);
    		PushFollow(Follow._return_type_in_function1446);
    		r=return_type();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_return_type.Add(r.Tree);
    		DebugLocation(149, 44);
    		LBRACE24=(IToken)Match(input,LBRACE,Follow._LBRACE_in_function1448); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_LBRACE.Add(LBRACE24);

    		DebugLocation(149, 52);
    		PushFollow(Follow._declarations_in_function1452);
    		d=declarations();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_declarations.Add(d.Tree);
    		DebugLocation(149, 67);
    		PushFollow(Follow._statement_list_in_function1456);
    		s=statement_list();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_statement_list.Add(s.Tree);
    		DebugLocation(149, 83);
    		RBRACE25=(IToken)Match(input,RBRACE,Follow._RBRACE_in_function1458); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_RBRACE.Add(RBRACE25);



    		{
    		// AST REWRITE
    		// elements: r, s, d, FUN, id, p
    		// token labels: id
    		// rule labels: retval, d, s, r, p
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleITokenStream stream_id=new RewriteRuleITokenStream(adaptor,"token id",id);
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    		RewriteRuleSubtreeStream stream_d=new RewriteRuleSubtreeStream(adaptor,"rule d",d!=null?d.Tree:null);
    		RewriteRuleSubtreeStream stream_s=new RewriteRuleSubtreeStream(adaptor,"rule s",s!=null?s.Tree:null);
    		RewriteRuleSubtreeStream stream_r=new RewriteRuleSubtreeStream(adaptor,"rule r",r!=null?r.Tree:null);
    		RewriteRuleSubtreeStream stream_p=new RewriteRuleSubtreeStream(adaptor,"rule p",p!=null?p.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 150:7: -> ^( FUN $id $p ^( RETTYPE $r) $d $s)
    		{
    			DebugLocation(150, 10);
    			// Evil.g:150:10: ^( FUN $id $p ^( RETTYPE $r) $d $s)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(150, 12);
    			root_1 = (object)adaptor.BecomeRoot(stream_FUN.NextNode(), root_1);

    			DebugLocation(150, 16);
    			adaptor.AddChild(root_1, stream_id.NextNode());
    			DebugLocation(150, 20);
    			adaptor.AddChild(root_1, stream_p.NextTree());
    			DebugLocation(150, 23);
    			// Evil.g:150:23: ^( RETTYPE $r)
    			{
    			object root_2 = (object)adaptor.Nil();
    			DebugLocation(150, 25);
    			root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETTYPE, "RETTYPE"), root_2);

    			DebugLocation(150, 33);
    			adaptor.AddChild(root_2, stream_r.NextTree());

    			adaptor.AddChild(root_1, root_2);
    			}
    			DebugLocation(150, 37);
    			adaptor.AddChild(root_1, stream_d.NextTree());
    			DebugLocation(150, 40);
    			adaptor.AddChild(root_1, stream_s.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(151, 3);
    	} finally { DebugExitRule(GrammarFileName, "function"); }
    	return retval;

    }
    // $ANTLR end "function"

    public class parameters_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_parameters() {}
    protected virtual void Leave_parameters() {}

    // $ANTLR start "parameters"
    // Evil.g:152:1: parameters : LPAREN ( decl ( COMMA decl )* )? RPAREN -> ^( PARAMS ( decl )* ) ;
    [GrammarRule("parameters")]
    private EvilParser.parameters_return parameters()
    {

        EvilParser.parameters_return retval = new EvilParser.parameters_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken LPAREN26=null;
        IToken COMMA28=null;
        IToken RPAREN30=null;
        EvilParser.decl_return decl27 = default(EvilParser.decl_return);
        EvilParser.decl_return decl29 = default(EvilParser.decl_return);

        object LPAREN26_tree=null;
        object COMMA28_tree=null;
        object RPAREN30_tree=null;
        RewriteRuleITokenStream stream_RPAREN=new RewriteRuleITokenStream(adaptor,"token RPAREN");
        RewriteRuleITokenStream stream_COMMA=new RewriteRuleITokenStream(adaptor,"token COMMA");
        RewriteRuleITokenStream stream_LPAREN=new RewriteRuleITokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_decl=new RewriteRuleSubtreeStream(adaptor,"rule decl");
    	try { DebugEnterRule(GrammarFileName, "parameters");
    	DebugLocation(152, 3);
    	try
    	{
    		// Evil.g:153:4: ( LPAREN ( decl ( COMMA decl )* )? RPAREN -> ^( PARAMS ( decl )* ) )
    		DebugEnterAlt(1);
    		// Evil.g:153:7: LPAREN ( decl ( COMMA decl )* )? RPAREN
    		{
    		DebugLocation(153, 7);
    		LPAREN26=(IToken)Match(input,LPAREN,Follow._LPAREN_in_parameters1504); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN26);

    		DebugLocation(153, 14);
    		// Evil.g:153:14: ( decl ( COMMA decl )* )?
    		int alt9=2;
    		try { DebugEnterSubRule(9);
    		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
    		int LA9_0 = input.LA(1);

    		if (((LA9_0>=STRUCT && LA9_0<=BOOL)))
    		{
    			alt9=1;
    		}
    		} finally { DebugExitDecision(9); }
    		switch (alt9)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:153:15: decl ( COMMA decl )*
    			{
    			DebugLocation(153, 15);
    			PushFollow(Follow._decl_in_parameters1507);
    			decl27=decl();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) stream_decl.Add(decl27.Tree);
    			DebugLocation(153, 20);
    			// Evil.g:153:20: ( COMMA decl )*
    			try { DebugEnterSubRule(8);
    			while (true)
    			{
    				int alt8=2;
    				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
    				int LA8_0 = input.LA(1);

    				if ((LA8_0==COMMA))
    				{
    					alt8=1;
    				}


    				} finally { DebugExitDecision(8); }
    				switch ( alt8 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Evil.g:153:21: COMMA decl
    					{
    					DebugLocation(153, 21);
    					COMMA28=(IToken)Match(input,COMMA,Follow._COMMA_in_parameters1510); if (state.failed) return retval; 
    					if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA28);

    					DebugLocation(153, 27);
    					PushFollow(Follow._decl_in_parameters1512);
    					decl29=decl();
    					PopFollow();
    					if (state.failed) return retval;
    					if ( (state.backtracking==0) ) stream_decl.Add(decl29.Tree);

    					}
    					break;

    				default:
    					goto loop8;
    				}
    			}

    			loop8:
    				;

    			} finally { DebugExitSubRule(8); }


    			}
    			break;

    		}
    		} finally { DebugExitSubRule(9); }

    		DebugLocation(153, 36);
    		RPAREN30=(IToken)Match(input,RPAREN,Follow._RPAREN_in_parameters1518); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN30);



    		{
    		// AST REWRITE
    		// elements: decl
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 154:7: -> ^( PARAMS ( decl )* )
    		{
    			DebugLocation(154, 10);
    			// Evil.g:154:10: ^( PARAMS ( decl )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(154, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_1);

    			DebugLocation(154, 19);
    			// Evil.g:154:19: ( decl )*
    			while ( stream_decl.HasNext )
    			{
    				DebugLocation(154, 19);
    				adaptor.AddChild(root_1, stream_decl.NextTree());

    			}
    			stream_decl.Reset();

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(155, 3);
    	} finally { DebugExitRule(GrammarFileName, "parameters"); }
    	return retval;

    }
    // $ANTLR end "parameters"

    public class return_type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_return_type() {}
    protected virtual void Leave_return_type() {}

    // $ANTLR start "return_type"
    // Evil.g:156:1: return_type : ( type | VOID );
    [GrammarRule("return_type")]
    private EvilParser.return_type_return return_type()
    {

        EvilParser.return_type_return retval = new EvilParser.return_type_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VOID32=null;
        EvilParser.type_return type31 = default(EvilParser.type_return);

        object VOID32_tree=null;

    	try { DebugEnterRule(GrammarFileName, "return_type");
    	DebugLocation(156, 3);
    	try
    	{
    		// Evil.g:157:4: ( type | VOID )
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
    			if (state.backtracking>0) {state.failed=true; return retval;}
    			NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(10); }
    		switch (alt10)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:157:7: type
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(157, 7);
    			PushFollow(Follow._type_in_return_type1548);
    			type31=type();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, type31.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:158:7: VOID
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(158, 7);
    			VOID32=(IToken)Match(input,VOID,Follow._VOID_in_return_type1556); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			VOID32_tree = (object)adaptor.Create(VOID32);
    			adaptor.AddChild(root_0, VOID32_tree);
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(159, 3);
    	} finally { DebugExitRule(GrammarFileName, "return_type"); }
    	return retval;

    }
    // $ANTLR end "return_type"

    public class statement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_statement() {}
    protected virtual void Leave_statement() {}

    // $ANTLR start "statement"
    // Evil.g:160:1: statement : ( block | ( lvalue ASSIGN )=> assignment | print | read | conditional | loop | delete | ret | ( ID LPAREN )=> invocation );
    [GrammarRule("statement")]
    private EvilParser.statement_return statement()
    {

        EvilParser.statement_return retval = new EvilParser.statement_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.block_return block33 = default(EvilParser.block_return);
        EvilParser.assignment_return assignment34 = default(EvilParser.assignment_return);
        EvilParser.print_return print35 = default(EvilParser.print_return);
        EvilParser.read_return read36 = default(EvilParser.read_return);
        EvilParser.conditional_return conditional37 = default(EvilParser.conditional_return);
        EvilParser.loop_return loop38 = default(EvilParser.loop_return);
        EvilParser.delete_return delete39 = default(EvilParser.delete_return);
        EvilParser.ret_return ret40 = default(EvilParser.ret_return);
        EvilParser.invocation_return invocation41 = default(EvilParser.invocation_return);


    	try { DebugEnterRule(GrammarFileName, "statement");
    	DebugLocation(160, 3);
    	try
    	{
    		// Evil.g:161:4: ( block | ( lvalue ASSIGN )=> assignment | print | read | conditional | loop | delete | ret | ( ID LPAREN )=> invocation )
    		int alt11=9;
    		try { DebugEnterDecision(11, decisionCanBacktrack[11]);
    		try
    		{
    			alt11 = dfa11.Predict(input);
    		}
    		catch (NoViableAltException nvae)
    		{
    			DebugRecognitionException(nvae);
    			throw;
    		}
    		} finally { DebugExitDecision(11); }
    		switch (alt11)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:161:7: block
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(161, 7);
    			PushFollow(Follow._block_in_statement1571);
    			block33=block();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, block33.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:162:7: ( lvalue ASSIGN )=> assignment
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(162, 26);
    			PushFollow(Follow._assignment_in_statement1587);
    			assignment34=assignment();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, assignment34.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Evil.g:163:7: print
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(163, 7);
    			PushFollow(Follow._print_in_statement1595);
    			print35=print();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, print35.Tree);

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Evil.g:164:7: read
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(164, 7);
    			PushFollow(Follow._read_in_statement1603);
    			read36=read();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, read36.Tree);

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Evil.g:165:7: conditional
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(165, 7);
    			PushFollow(Follow._conditional_in_statement1611);
    			conditional37=conditional();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, conditional37.Tree);

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// Evil.g:166:7: loop
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(166, 7);
    			PushFollow(Follow._loop_in_statement1619);
    			loop38=loop();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, loop38.Tree);

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// Evil.g:167:7: delete
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(167, 7);
    			PushFollow(Follow._delete_in_statement1627);
    			delete39=delete();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, delete39.Tree);

    			}
    			break;
    		case 8:
    			DebugEnterAlt(8);
    			// Evil.g:168:7: ret
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(168, 7);
    			PushFollow(Follow._ret_in_statement1635);
    			ret40=ret();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, ret40.Tree);

    			}
    			break;
    		case 9:
    			DebugEnterAlt(9);
    			// Evil.g:169:7: ( ID LPAREN )=> invocation
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(169, 22);
    			PushFollow(Follow._invocation_in_statement1651);
    			invocation41=invocation();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, invocation41.Tree);

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(170, 3);
    	} finally { DebugExitRule(GrammarFileName, "statement"); }
    	return retval;

    }
    // $ANTLR end "statement"

    public class block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_block() {}
    protected virtual void Leave_block() {}

    // $ANTLR start "block"
    // Evil.g:171:1: block : LBRACE s= statement_list RBRACE -> ^( BLOCK $s) ;
    [GrammarRule("block")]
    private EvilParser.block_return block()
    {

        EvilParser.block_return retval = new EvilParser.block_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken LBRACE42=null;
        IToken RBRACE43=null;
        EvilParser.statement_list_return s = default(EvilParser.statement_list_return);

        object LBRACE42_tree=null;
        object RBRACE43_tree=null;
        RewriteRuleITokenStream stream_RBRACE=new RewriteRuleITokenStream(adaptor,"token RBRACE");
        RewriteRuleITokenStream stream_LBRACE=new RewriteRuleITokenStream(adaptor,"token LBRACE");
        RewriteRuleSubtreeStream stream_statement_list=new RewriteRuleSubtreeStream(adaptor,"rule statement_list");
    	try { DebugEnterRule(GrammarFileName, "block");
    	DebugLocation(171, 3);
    	try
    	{
    		// Evil.g:172:4: ( LBRACE s= statement_list RBRACE -> ^( BLOCK $s) )
    		DebugEnterAlt(1);
    		// Evil.g:172:7: LBRACE s= statement_list RBRACE
    		{
    		DebugLocation(172, 7);
    		LBRACE42=(IToken)Match(input,LBRACE,Follow._LBRACE_in_block1666); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_LBRACE.Add(LBRACE42);

    		DebugLocation(172, 15);
    		PushFollow(Follow._statement_list_in_block1670);
    		s=statement_list();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_statement_list.Add(s.Tree);
    		DebugLocation(172, 31);
    		RBRACE43=(IToken)Match(input,RBRACE,Follow._RBRACE_in_block1672); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_RBRACE.Add(RBRACE43);



    		{
    		// AST REWRITE
    		// elements: s
    		// token labels: 
    		// rule labels: retval, s
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    		RewriteRuleSubtreeStream stream_s=new RewriteRuleSubtreeStream(adaptor,"rule s",s!=null?s.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 173:7: -> ^( BLOCK $s)
    		{
    			DebugLocation(173, 10);
    			// Evil.g:173:10: ^( BLOCK $s)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(173, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

    			DebugLocation(173, 18);
    			adaptor.AddChild(root_1, stream_s.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(174, 3);
    	} finally { DebugExitRule(GrammarFileName, "block"); }
    	return retval;

    }
    // $ANTLR end "block"

    public class statement_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_statement_list() {}
    protected virtual void Leave_statement_list() {}

    // $ANTLR start "statement_list"
    // Evil.g:175:1: statement_list : ( statement )* -> ^( STMTS ( statement )* ) ;
    [GrammarRule("statement_list")]
    private EvilParser.statement_list_return statement_list()
    {

        EvilParser.statement_list_return retval = new EvilParser.statement_list_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.statement_return statement44 = default(EvilParser.statement_return);

        RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
    	try { DebugEnterRule(GrammarFileName, "statement_list");
    	DebugLocation(175, 3);
    	try
    	{
    		// Evil.g:176:4: ( ( statement )* -> ^( STMTS ( statement )* ) )
    		DebugEnterAlt(1);
    		// Evil.g:176:7: ( statement )*
    		{
    		DebugLocation(176, 7);
    		// Evil.g:176:7: ( statement )*
    		try { DebugEnterSubRule(12);
    		while (true)
    		{
    			int alt12=2;
    			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
    			int LA12_0 = input.LA(1);

    			if ((LA12_0==PRINT||(LA12_0>=READ && LA12_0<=IF)||(LA12_0>=WHILE && LA12_0<=RETURN)||LA12_0==LBRACE||LA12_0==ID))
    			{
    				alt12=1;
    			}


    			} finally { DebugExitDecision(12); }
    			switch ( alt12 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:176:8: statement
    				{
    				DebugLocation(176, 8);
    				PushFollow(Follow._statement_in_statement_list1703);
    				statement44=statement();
    				PopFollow();
    				if (state.failed) return retval;
    				if ( (state.backtracking==0) ) stream_statement.Add(statement44.Tree);

    				}
    				break;

    			default:
    				goto loop12;
    			}
    		}

    		loop12:
    			;

    		} finally { DebugExitSubRule(12); }



    		{
    		// AST REWRITE
    		// elements: statement
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 176:20: -> ^( STMTS ( statement )* )
    		{
    			DebugLocation(176, 23);
    			// Evil.g:176:23: ^( STMTS ( statement )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(176, 25);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STMTS, "STMTS"), root_1);

    			DebugLocation(176, 31);
    			// Evil.g:176:31: ( statement )*
    			while ( stream_statement.HasNext )
    			{
    				DebugLocation(176, 31);
    				adaptor.AddChild(root_1, stream_statement.NextTree());

    			}
    			stream_statement.Reset();

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(177, 3);
    	} finally { DebugExitRule(GrammarFileName, "statement_list"); }
    	return retval;

    }
    // $ANTLR end "statement_list"

    public class assignment_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_assignment() {}
    protected virtual void Leave_assignment() {}

    // $ANTLR start "assignment"
    // Evil.g:178:1: assignment : l= lvalue ASSIGN e= expression SEMI -> ^( ASSIGN $e $l) ;
    [GrammarRule("assignment")]
    private EvilParser.assignment_return assignment()
    {

        EvilParser.assignment_return retval = new EvilParser.assignment_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ASSIGN45=null;
        IToken SEMI46=null;
        EvilParser.lvalue_return l = default(EvilParser.lvalue_return);
        EvilParser.expression_return e = default(EvilParser.expression_return);

        object ASSIGN45_tree=null;
        object SEMI46_tree=null;
        RewriteRuleITokenStream stream_SEMI=new RewriteRuleITokenStream(adaptor,"token SEMI");
        RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_lvalue=new RewriteRuleSubtreeStream(adaptor,"rule lvalue");
    	try { DebugEnterRule(GrammarFileName, "assignment");
    	DebugLocation(178, 3);
    	try
    	{
    		// Evil.g:179:4: (l= lvalue ASSIGN e= expression SEMI -> ^( ASSIGN $e $l) )
    		DebugEnterAlt(1);
    		// Evil.g:179:7: l= lvalue ASSIGN e= expression SEMI
    		{
    		DebugLocation(179, 8);
    		PushFollow(Follow._lvalue_in_assignment1731);
    		l=lvalue();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_lvalue.Add(l.Tree);
    		DebugLocation(179, 16);
    		ASSIGN45=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignment1733); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN45);

    		DebugLocation(179, 24);
    		PushFollow(Follow._expression_in_assignment1737);
    		e=expression();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_expression.Add(e.Tree);
    		DebugLocation(179, 36);
    		SEMI46=(IToken)Match(input,SEMI,Follow._SEMI_in_assignment1739); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_SEMI.Add(SEMI46);



    		{
    		// AST REWRITE
    		// elements: l, ASSIGN, e
    		// token labels: 
    		// rule labels: retval, e, l
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    		RewriteRuleSubtreeStream stream_e=new RewriteRuleSubtreeStream(adaptor,"rule e",e!=null?e.Tree:null);
    		RewriteRuleSubtreeStream stream_l=new RewriteRuleSubtreeStream(adaptor,"rule l",l!=null?l.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 180:7: -> ^( ASSIGN $e $l)
    		{
    			DebugLocation(180, 10);
    			// Evil.g:180:10: ^( ASSIGN $e $l)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(180, 12);
    			root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

    			DebugLocation(180, 19);
    			adaptor.AddChild(root_1, stream_e.NextTree());
    			DebugLocation(180, 22);
    			adaptor.AddChild(root_1, stream_l.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(181, 3);
    	} finally { DebugExitRule(GrammarFileName, "assignment"); }
    	return retval;

    }
    // $ANTLR end "assignment"

    public class print_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_print() {}
    protected virtual void Leave_print() {}

    // $ANTLR start "print"
    // Evil.g:182:1: print : PRINT expression ( ENDL )? SEMI ;
    [GrammarRule("print")]
    private EvilParser.print_return print()
    {

        EvilParser.print_return retval = new EvilParser.print_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PRINT47=null;
        IToken ENDL49=null;
        IToken SEMI50=null;
        EvilParser.expression_return expression48 = default(EvilParser.expression_return);

        object PRINT47_tree=null;
        object ENDL49_tree=null;
        object SEMI50_tree=null;

    	try { DebugEnterRule(GrammarFileName, "print");
    	DebugLocation(182, 3);
    	try
    	{
    		// Evil.g:183:4: ( PRINT expression ( ENDL )? SEMI )
    		DebugEnterAlt(1);
    		// Evil.g:183:7: PRINT expression ( ENDL )? SEMI
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(183, 12);
    		PRINT47=(IToken)Match(input,PRINT,Follow._PRINT_in_print1772); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		PRINT47_tree = (object)adaptor.Create(PRINT47);
    		root_0 = (object)adaptor.BecomeRoot(PRINT47_tree, root_0);
    		}
    		DebugLocation(183, 14);
    		PushFollow(Follow._expression_in_print1775);
    		expression48=expression();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, expression48.Tree);
    		DebugLocation(183, 25);
    		// Evil.g:183:25: ( ENDL )?
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
    			// Evil.g:183:26: ENDL
    			{
    			DebugLocation(183, 26);
    			ENDL49=(IToken)Match(input,ENDL,Follow._ENDL_in_print1778); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			ENDL49_tree = (object)adaptor.Create(ENDL49);
    			adaptor.AddChild(root_0, ENDL49_tree);
    			}

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(13); }

    		DebugLocation(183, 37);
    		SEMI50=(IToken)Match(input,SEMI,Follow._SEMI_in_print1782); if (state.failed) return retval;

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(184, 3);
    	} finally { DebugExitRule(GrammarFileName, "print"); }
    	return retval;

    }
    // $ANTLR end "print"

    public class read_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_read() {}
    protected virtual void Leave_read() {}

    // $ANTLR start "read"
    // Evil.g:185:1: read : READ lvalue SEMI ;
    [GrammarRule("read")]
    private EvilParser.read_return read()
    {

        EvilParser.read_return retval = new EvilParser.read_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken READ51=null;
        IToken SEMI53=null;
        EvilParser.lvalue_return lvalue52 = default(EvilParser.lvalue_return);

        object READ51_tree=null;
        object SEMI53_tree=null;

    	try { DebugEnterRule(GrammarFileName, "read");
    	DebugLocation(185, 3);
    	try
    	{
    		// Evil.g:186:4: ( READ lvalue SEMI )
    		DebugEnterAlt(1);
    		// Evil.g:186:7: READ lvalue SEMI
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(186, 11);
    		READ51=(IToken)Match(input,READ,Follow._READ_in_read1798); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		READ51_tree = (object)adaptor.Create(READ51);
    		root_0 = (object)adaptor.BecomeRoot(READ51_tree, root_0);
    		}
    		DebugLocation(186, 13);
    		PushFollow(Follow._lvalue_in_read1801);
    		lvalue52=lvalue();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, lvalue52.Tree);
    		DebugLocation(186, 24);
    		SEMI53=(IToken)Match(input,SEMI,Follow._SEMI_in_read1803); if (state.failed) return retval;

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(187, 3);
    	} finally { DebugExitRule(GrammarFileName, "read"); }
    	return retval;

    }
    // $ANTLR end "read"

    public class conditional_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_conditional() {}
    protected virtual void Leave_conditional() {}

    // $ANTLR start "conditional"
    // Evil.g:188:1: conditional : IF LPAREN expression RPAREN block ( ELSE block )? ;
    [GrammarRule("conditional")]
    private EvilParser.conditional_return conditional()
    {

        EvilParser.conditional_return retval = new EvilParser.conditional_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken IF54=null;
        IToken LPAREN55=null;
        IToken RPAREN57=null;
        IToken ELSE59=null;
        EvilParser.expression_return expression56 = default(EvilParser.expression_return);
        EvilParser.block_return block58 = default(EvilParser.block_return);
        EvilParser.block_return block60 = default(EvilParser.block_return);

        object IF54_tree=null;
        object LPAREN55_tree=null;
        object RPAREN57_tree=null;
        object ELSE59_tree=null;

    	try { DebugEnterRule(GrammarFileName, "conditional");
    	DebugLocation(188, 3);
    	try
    	{
    		// Evil.g:189:4: ( IF LPAREN expression RPAREN block ( ELSE block )? )
    		DebugEnterAlt(1);
    		// Evil.g:189:7: IF LPAREN expression RPAREN block ( ELSE block )?
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(189, 9);
    		IF54=(IToken)Match(input,IF,Follow._IF_in_conditional1819); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		IF54_tree = (object)adaptor.Create(IF54);
    		root_0 = (object)adaptor.BecomeRoot(IF54_tree, root_0);
    		}
    		DebugLocation(189, 17);
    		LPAREN55=(IToken)Match(input,LPAREN,Follow._LPAREN_in_conditional1822); if (state.failed) return retval;
    		DebugLocation(189, 19);
    		PushFollow(Follow._expression_in_conditional1825);
    		expression56=expression();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, expression56.Tree);
    		DebugLocation(189, 36);
    		RPAREN57=(IToken)Match(input,RPAREN,Follow._RPAREN_in_conditional1827); if (state.failed) return retval;
    		DebugLocation(189, 38);
    		PushFollow(Follow._block_in_conditional1830);
    		block58=block();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, block58.Tree);
    		DebugLocation(189, 44);
    		// Evil.g:189:44: ( ELSE block )?
    		int alt14=2;
    		try { DebugEnterSubRule(14);
    		try { DebugEnterDecision(14, decisionCanBacktrack[14]);
    		int LA14_0 = input.LA(1);

    		if ((LA14_0==ELSE))
    		{
    			alt14=1;
    		}
    		} finally { DebugExitDecision(14); }
    		switch (alt14)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:189:45: ELSE block
    			{
    			DebugLocation(189, 49);
    			ELSE59=(IToken)Match(input,ELSE,Follow._ELSE_in_conditional1833); if (state.failed) return retval;
    			DebugLocation(189, 51);
    			PushFollow(Follow._block_in_conditional1836);
    			block60=block();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, block60.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(14); }


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(190, 3);
    	} finally { DebugExitRule(GrammarFileName, "conditional"); }
    	return retval;

    }
    // $ANTLR end "conditional"

    public class loop_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_loop() {}
    protected virtual void Leave_loop() {}

    // $ANTLR start "loop"
    // Evil.g:191:1: loop : WHILE LPAREN e= expression RPAREN b= block -> ^( WHILE $e $b $e) ;
    [GrammarRule("loop")]
    private EvilParser.loop_return loop()
    {

        EvilParser.loop_return retval = new EvilParser.loop_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken WHILE61=null;
        IToken LPAREN62=null;
        IToken RPAREN63=null;
        EvilParser.expression_return e = default(EvilParser.expression_return);
        EvilParser.block_return b = default(EvilParser.block_return);

        object WHILE61_tree=null;
        object LPAREN62_tree=null;
        object RPAREN63_tree=null;
        RewriteRuleITokenStream stream_RPAREN=new RewriteRuleITokenStream(adaptor,"token RPAREN");
        RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
        RewriteRuleITokenStream stream_LPAREN=new RewriteRuleITokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
    	try { DebugEnterRule(GrammarFileName, "loop");
    	DebugLocation(191, 3);
    	try
    	{
    		// Evil.g:192:4: ( WHILE LPAREN e= expression RPAREN b= block -> ^( WHILE $e $b $e) )
    		DebugEnterAlt(1);
    		// Evil.g:192:7: WHILE LPAREN e= expression RPAREN b= block
    		{
    		DebugLocation(192, 7);
    		WHILE61=(IToken)Match(input,WHILE,Follow._WHILE_in_loop1853); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE61);

    		DebugLocation(192, 13);
    		LPAREN62=(IToken)Match(input,LPAREN,Follow._LPAREN_in_loop1855); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN62);

    		DebugLocation(192, 21);
    		PushFollow(Follow._expression_in_loop1859);
    		e=expression();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_expression.Add(e.Tree);
    		DebugLocation(192, 33);
    		RPAREN63=(IToken)Match(input,RPAREN,Follow._RPAREN_in_loop1861); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN63);

    		DebugLocation(192, 41);
    		PushFollow(Follow._block_in_loop1865);
    		b=block();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_block.Add(b.Tree);


    		{
    		// AST REWRITE
    		// elements: b, e, e, WHILE
    		// token labels: 
    		// rule labels: retval, e, b
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    		RewriteRuleSubtreeStream stream_e=new RewriteRuleSubtreeStream(adaptor,"rule e",e!=null?e.Tree:null);
    		RewriteRuleSubtreeStream stream_b=new RewriteRuleSubtreeStream(adaptor,"rule b",b!=null?b.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 193:7: -> ^( WHILE $e $b $e)
    		{
    			DebugLocation(193, 10);
    			// Evil.g:193:10: ^( WHILE $e $b $e)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(193, 12);
    			root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

    			DebugLocation(193, 18);
    			adaptor.AddChild(root_1, stream_e.NextTree());
    			DebugLocation(193, 21);
    			adaptor.AddChild(root_1, stream_b.NextTree());
    			DebugLocation(193, 24);
    			adaptor.AddChild(root_1, stream_e.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(194, 3);
    	} finally { DebugExitRule(GrammarFileName, "loop"); }
    	return retval;

    }
    // $ANTLR end "loop"

    public class delete_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_delete() {}
    protected virtual void Leave_delete() {}

    // $ANTLR start "delete"
    // Evil.g:195:1: delete : DELETE expression SEMI ;
    [GrammarRule("delete")]
    private EvilParser.delete_return delete()
    {

        EvilParser.delete_return retval = new EvilParser.delete_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken DELETE64=null;
        IToken SEMI66=null;
        EvilParser.expression_return expression65 = default(EvilParser.expression_return);

        object DELETE64_tree=null;
        object SEMI66_tree=null;

    	try { DebugEnterRule(GrammarFileName, "delete");
    	DebugLocation(195, 3);
    	try
    	{
    		// Evil.g:196:4: ( DELETE expression SEMI )
    		DebugEnterAlt(1);
    		// Evil.g:196:7: DELETE expression SEMI
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(196, 13);
    		DELETE64=(IToken)Match(input,DELETE,Follow._DELETE_in_delete1901); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		DELETE64_tree = (object)adaptor.Create(DELETE64);
    		root_0 = (object)adaptor.BecomeRoot(DELETE64_tree, root_0);
    		}
    		DebugLocation(196, 15);
    		PushFollow(Follow._expression_in_delete1904);
    		expression65=expression();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, expression65.Tree);
    		DebugLocation(196, 30);
    		SEMI66=(IToken)Match(input,SEMI,Follow._SEMI_in_delete1906); if (state.failed) return retval;

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(197, 3);
    	} finally { DebugExitRule(GrammarFileName, "delete"); }
    	return retval;

    }
    // $ANTLR end "delete"

    public class ret_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_ret() {}
    protected virtual void Leave_ret() {}

    // $ANTLR start "ret"
    // Evil.g:198:1: ret : RETURN ( expression )? SEMI ;
    [GrammarRule("ret")]
    private EvilParser.ret_return ret()
    {

        EvilParser.ret_return retval = new EvilParser.ret_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken RETURN67=null;
        IToken SEMI69=null;
        EvilParser.expression_return expression68 = default(EvilParser.expression_return);

        object RETURN67_tree=null;
        object SEMI69_tree=null;

    	try { DebugEnterRule(GrammarFileName, "ret");
    	DebugLocation(198, 3);
    	try
    	{
    		// Evil.g:199:4: ( RETURN ( expression )? SEMI )
    		DebugEnterAlt(1);
    		// Evil.g:199:7: RETURN ( expression )? SEMI
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(199, 13);
    		RETURN67=(IToken)Match(input,RETURN,Follow._RETURN_in_ret1922); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		RETURN67_tree = (object)adaptor.Create(RETURN67);
    		root_0 = (object)adaptor.BecomeRoot(RETURN67_tree, root_0);
    		}
    		DebugLocation(199, 15);
    		// Evil.g:199:15: ( expression )?
    		int alt15=2;
    		try { DebugEnterSubRule(15);
    		try { DebugEnterDecision(15, decisionCanBacktrack[15]);
    		int LA15_0 = input.LA(1);

    		if (((LA15_0>=TRUE && LA15_0<=NULL)||LA15_0==LPAREN||LA15_0==MINUS||(LA15_0>=NOT && LA15_0<=INTEGER)))
    		{
    			alt15=1;
    		}
    		} finally { DebugExitDecision(15); }
    		switch (alt15)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:199:16: expression
    			{
    			DebugLocation(199, 16);
    			PushFollow(Follow._expression_in_ret1926);
    			expression68=expression();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, expression68.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(15); }

    		DebugLocation(199, 33);
    		SEMI69=(IToken)Match(input,SEMI,Follow._SEMI_in_ret1930); if (state.failed) return retval;

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(200, 3);
    	} finally { DebugExitRule(GrammarFileName, "ret"); }
    	return retval;

    }
    // $ANTLR end "ret"

    public class invocation_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_invocation() {}
    protected virtual void Leave_invocation() {}

    // $ANTLR start "invocation"
    // Evil.g:201:1: invocation : id= ID a= arguments SEMI -> ^( INVOKE $id $a) ;
    [GrammarRule("invocation")]
    private EvilParser.invocation_return invocation()
    {

        EvilParser.invocation_return retval = new EvilParser.invocation_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken id=null;
        IToken SEMI70=null;
        EvilParser.arguments_return a = default(EvilParser.arguments_return);

        object id_tree=null;
        object SEMI70_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_SEMI=new RewriteRuleITokenStream(adaptor,"token SEMI");
        RewriteRuleSubtreeStream stream_arguments=new RewriteRuleSubtreeStream(adaptor,"rule arguments");
    	try { DebugEnterRule(GrammarFileName, "invocation");
    	DebugLocation(201, 3);
    	try
    	{
    		// Evil.g:202:4: (id= ID a= arguments SEMI -> ^( INVOKE $id $a) )
    		DebugEnterAlt(1);
    		// Evil.g:202:7: id= ID a= arguments SEMI
    		{
    		DebugLocation(202, 9);
    		id=(IToken)Match(input,ID,Follow._ID_in_invocation1948); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_ID.Add(id);

    		DebugLocation(202, 14);
    		PushFollow(Follow._arguments_in_invocation1952);
    		a=arguments();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_arguments.Add(a.Tree);
    		DebugLocation(202, 25);
    		SEMI70=(IToken)Match(input,SEMI,Follow._SEMI_in_invocation1954); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_SEMI.Add(SEMI70);



    		{
    		// AST REWRITE
    		// elements: id, a
    		// token labels: id
    		// rule labels: retval, a
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		if ( (state.backtracking==0) ) {
    		retval.Tree = root_0;
    		RewriteRuleITokenStream stream_id=new RewriteRuleITokenStream(adaptor,"token id",id);
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    		RewriteRuleSubtreeStream stream_a=new RewriteRuleSubtreeStream(adaptor,"rule a",a!=null?a.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 203:7: -> ^( INVOKE $id $a)
    		{
    			DebugLocation(203, 10);
    			// Evil.g:203:10: ^( INVOKE $id $a)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(203, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INVOKE, "INVOKE"), root_1);

    			DebugLocation(203, 19);
    			adaptor.AddChild(root_1, stream_id.NextNode());
    			DebugLocation(203, 23);
    			adaptor.AddChild(root_1, stream_a.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(204, 3);
    	} finally { DebugExitRule(GrammarFileName, "invocation"); }
    	return retval;

    }
    // $ANTLR end "invocation"

    public class lvalue_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_lvalue() {}
    protected virtual void Leave_lvalue() {}

    // $ANTLR start "lvalue"
    // Evil.g:205:1: lvalue : ID ( DOT ID )* ;
    [GrammarRule("lvalue")]
    private EvilParser.lvalue_return lvalue()
    {

        EvilParser.lvalue_return retval = new EvilParser.lvalue_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ID71=null;
        IToken DOT72=null;
        IToken ID73=null;

        object ID71_tree=null;
        object DOT72_tree=null;
        object ID73_tree=null;

    	try { DebugEnterRule(GrammarFileName, "lvalue");
    	DebugLocation(205, 3);
    	try
    	{
    		// Evil.g:206:4: ( ID ( DOT ID )* )
    		DebugEnterAlt(1);
    		// Evil.g:206:7: ID ( DOT ID )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(206, 7);
    		ID71=(IToken)Match(input,ID,Follow._ID_in_lvalue1987); if (state.failed) return retval;
    		if ( state.backtracking==0 ) {
    		ID71_tree = (object)adaptor.Create(ID71);
    		adaptor.AddChild(root_0, ID71_tree);
    		}
    		DebugLocation(206, 10);
    		// Evil.g:206:10: ( DOT ID )*
    		try { DebugEnterSubRule(16);
    		while (true)
    		{
    			int alt16=2;
    			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
    			int LA16_0 = input.LA(1);

    			if ((LA16_0==DOT))
    			{
    				alt16=1;
    			}


    			} finally { DebugExitDecision(16); }
    			switch ( alt16 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:206:11: DOT ID
    				{
    				DebugLocation(206, 14);
    				DOT72=(IToken)Match(input,DOT,Follow._DOT_in_lvalue1990); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				DOT72_tree = (object)adaptor.Create(DOT72);
    				root_0 = (object)adaptor.BecomeRoot(DOT72_tree, root_0);
    				}
    				DebugLocation(206, 16);
    				ID73=(IToken)Match(input,ID,Follow._ID_in_lvalue1993); if (state.failed) return retval;
    				if ( state.backtracking==0 ) {
    				ID73_tree = (object)adaptor.Create(ID73);
    				adaptor.AddChild(root_0, ID73_tree);
    				}

    				}
    				break;

    			default:
    				goto loop16;
    			}
    		}

    		loop16:
    			;

    		} finally { DebugExitSubRule(16); }


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(207, 3);
    	} finally { DebugExitRule(GrammarFileName, "lvalue"); }
    	return retval;

    }
    // $ANTLR end "lvalue"

    public class expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_expression() {}
    protected virtual void Leave_expression() {}

    // $ANTLR start "expression"
    // Evil.g:208:1: expression : boolterm ( ( AND | OR ) boolterm )* ;
    [GrammarRule("expression")]
    private EvilParser.expression_return expression()
    {

        EvilParser.expression_return retval = new EvilParser.expression_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken AND75=null;
        IToken OR76=null;
        EvilParser.boolterm_return boolterm74 = default(EvilParser.boolterm_return);
        EvilParser.boolterm_return boolterm77 = default(EvilParser.boolterm_return);

        object AND75_tree=null;
        object OR76_tree=null;

    	try { DebugEnterRule(GrammarFileName, "expression");
    	DebugLocation(208, 3);
    	try
    	{
    		// Evil.g:209:4: ( boolterm ( ( AND | OR ) boolterm )* )
    		DebugEnterAlt(1);
    		// Evil.g:209:7: boolterm ( ( AND | OR ) boolterm )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(209, 7);
    		PushFollow(Follow._boolterm_in_expression2010);
    		boolterm74=boolterm();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, boolterm74.Tree);
    		DebugLocation(209, 16);
    		// Evil.g:209:16: ( ( AND | OR ) boolterm )*
    		try { DebugEnterSubRule(18);
    		while (true)
    		{
    			int alt18=2;
    			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
    			int LA18_0 = input.LA(1);

    			if (((LA18_0>=AND && LA18_0<=OR)))
    			{
    				alt18=1;
    			}


    			} finally { DebugExitDecision(18); }
    			switch ( alt18 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:209:17: ( AND | OR ) boolterm
    				{
    				DebugLocation(209, 17);
    				// Evil.g:209:17: ( AND | OR )
    				int alt17=2;
    				try { DebugEnterSubRule(17);
    				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
    				int LA17_0 = input.LA(1);

    				if ((LA17_0==AND))
    				{
    					alt17=1;
    				}
    				else if ((LA17_0==OR))
    				{
    					alt17=2;
    				}
    				else
    				{
    					if (state.backtracking>0) {state.failed=true; return retval;}
    					NoViableAltException nvae = new NoViableAltException("", 17, 0, input);

    					DebugRecognitionException(nvae);
    					throw nvae;
    				}
    				} finally { DebugExitDecision(17); }
    				switch (alt17)
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Evil.g:209:18: AND
    					{
    					DebugLocation(209, 21);
    					AND75=(IToken)Match(input,AND,Follow._AND_in_expression2014); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					AND75_tree = (object)adaptor.Create(AND75);
    					root_0 = (object)adaptor.BecomeRoot(AND75_tree, root_0);
    					}

    					}
    					break;
    				case 2:
    					DebugEnterAlt(2);
    					// Evil.g:209:25: OR
    					{
    					DebugLocation(209, 27);
    					OR76=(IToken)Match(input,OR,Follow._OR_in_expression2019); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					OR76_tree = (object)adaptor.Create(OR76);
    					root_0 = (object)adaptor.BecomeRoot(OR76_tree, root_0);
    					}

    					}
    					break;

    				}
    				} finally { DebugExitSubRule(17); }

    				DebugLocation(209, 30);
    				PushFollow(Follow._boolterm_in_expression2023);
    				boolterm77=boolterm();
    				PopFollow();
    				if (state.failed) return retval;
    				if ( (state.backtracking==0) ) adaptor.AddChild(root_0, boolterm77.Tree);

    				}
    				break;

    			default:
    				goto loop18;
    			}
    		}

    		loop18:
    			;

    		} finally { DebugExitSubRule(18); }


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(210, 3);
    	} finally { DebugExitRule(GrammarFileName, "expression"); }
    	return retval;

    }
    // $ANTLR end "expression"

    public class boolterm_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_boolterm() {}
    protected virtual void Leave_boolterm() {}

    // $ANTLR start "boolterm"
    // Evil.g:211:1: boolterm : simple ( ( EQ | LT | GT | NE | LE | GE ) simple )? ;
    [GrammarRule("boolterm")]
    private EvilParser.boolterm_return boolterm()
    {

        EvilParser.boolterm_return retval = new EvilParser.boolterm_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken EQ79=null;
        IToken LT80=null;
        IToken GT81=null;
        IToken NE82=null;
        IToken LE83=null;
        IToken GE84=null;
        EvilParser.simple_return simple78 = default(EvilParser.simple_return);
        EvilParser.simple_return simple85 = default(EvilParser.simple_return);

        object EQ79_tree=null;
        object LT80_tree=null;
        object GT81_tree=null;
        object NE82_tree=null;
        object LE83_tree=null;
        object GE84_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolterm");
    	DebugLocation(211, 3);
    	try
    	{
    		// Evil.g:212:4: ( simple ( ( EQ | LT | GT | NE | LE | GE ) simple )? )
    		DebugEnterAlt(1);
    		// Evil.g:212:7: simple ( ( EQ | LT | GT | NE | LE | GE ) simple )?
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(212, 7);
    		PushFollow(Follow._simple_in_boolterm2040);
    		simple78=simple();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, simple78.Tree);
    		DebugLocation(212, 14);
    		// Evil.g:212:14: ( ( EQ | LT | GT | NE | LE | GE ) simple )?
    		int alt20=2;
    		try { DebugEnterSubRule(20);
    		try { DebugEnterDecision(20, decisionCanBacktrack[20]);
    		int LA20_0 = input.LA(1);

    		if (((LA20_0>=EQ && LA20_0<=GE)))
    		{
    			alt20=1;
    		}
    		} finally { DebugExitDecision(20); }
    		switch (alt20)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:212:15: ( EQ | LT | GT | NE | LE | GE ) simple
    			{
    			DebugLocation(212, 15);
    			// Evil.g:212:15: ( EQ | LT | GT | NE | LE | GE )
    			int alt19=6;
    			try { DebugEnterSubRule(19);
    			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
    			switch (input.LA(1))
    			{
    			case EQ:
    				{
    				alt19=1;
    				}
    				break;
    			case LT:
    				{
    				alt19=2;
    				}
    				break;
    			case GT:
    				{
    				alt19=3;
    				}
    				break;
    			case NE:
    				{
    				alt19=4;
    				}
    				break;
    			case LE:
    				{
    				alt19=5;
    				}
    				break;
    			case GE:
    				{
    				alt19=6;
    				}
    				break;
    			default:
    				{
    					if (state.backtracking>0) {state.failed=true; return retval;}
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
    				// Evil.g:212:16: EQ
    				{
    				DebugLocation(212, 18);
    				EQ79=(IToken)Match(input,EQ,Follow._EQ_in_boolterm2044); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				EQ79_tree = (object)adaptor.Create(EQ79);
    				root_0 = (object)adaptor.BecomeRoot(EQ79_tree, root_0);
    				}

    				}
    				break;
    			case 2:
    				DebugEnterAlt(2);
    				// Evil.g:212:22: LT
    				{
    				DebugLocation(212, 24);
    				LT80=(IToken)Match(input,LT,Follow._LT_in_boolterm2049); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				LT80_tree = (object)adaptor.Create(LT80);
    				root_0 = (object)adaptor.BecomeRoot(LT80_tree, root_0);
    				}

    				}
    				break;
    			case 3:
    				DebugEnterAlt(3);
    				// Evil.g:212:28: GT
    				{
    				DebugLocation(212, 30);
    				GT81=(IToken)Match(input,GT,Follow._GT_in_boolterm2054); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				GT81_tree = (object)adaptor.Create(GT81);
    				root_0 = (object)adaptor.BecomeRoot(GT81_tree, root_0);
    				}

    				}
    				break;
    			case 4:
    				DebugEnterAlt(4);
    				// Evil.g:212:34: NE
    				{
    				DebugLocation(212, 36);
    				NE82=(IToken)Match(input,NE,Follow._NE_in_boolterm2059); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				NE82_tree = (object)adaptor.Create(NE82);
    				root_0 = (object)adaptor.BecomeRoot(NE82_tree, root_0);
    				}

    				}
    				break;
    			case 5:
    				DebugEnterAlt(5);
    				// Evil.g:212:40: LE
    				{
    				DebugLocation(212, 42);
    				LE83=(IToken)Match(input,LE,Follow._LE_in_boolterm2064); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				LE83_tree = (object)adaptor.Create(LE83);
    				root_0 = (object)adaptor.BecomeRoot(LE83_tree, root_0);
    				}

    				}
    				break;
    			case 6:
    				DebugEnterAlt(6);
    				// Evil.g:212:46: GE
    				{
    				DebugLocation(212, 48);
    				GE84=(IToken)Match(input,GE,Follow._GE_in_boolterm2069); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				GE84_tree = (object)adaptor.Create(GE84);
    				root_0 = (object)adaptor.BecomeRoot(GE84_tree, root_0);
    				}

    				}
    				break;

    			}
    			} finally { DebugExitSubRule(19); }

    			DebugLocation(212, 51);
    			PushFollow(Follow._simple_in_boolterm2073);
    			simple85=simple();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, simple85.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(20); }


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(213, 3);
    	} finally { DebugExitRule(GrammarFileName, "boolterm"); }
    	return retval;

    }
    // $ANTLR end "boolterm"

    public class simple_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_simple() {}
    protected virtual void Leave_simple() {}

    // $ANTLR start "simple"
    // Evil.g:214:1: simple : term ( ( PLUS | MINUS ) term )* ;
    [GrammarRule("simple")]
    private EvilParser.simple_return simple()
    {

        EvilParser.simple_return retval = new EvilParser.simple_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PLUS87=null;
        IToken MINUS88=null;
        EvilParser.term_return term86 = default(EvilParser.term_return);
        EvilParser.term_return term89 = default(EvilParser.term_return);

        object PLUS87_tree=null;
        object MINUS88_tree=null;

    	try { DebugEnterRule(GrammarFileName, "simple");
    	DebugLocation(214, 3);
    	try
    	{
    		// Evil.g:215:4: ( term ( ( PLUS | MINUS ) term )* )
    		DebugEnterAlt(1);
    		// Evil.g:215:7: term ( ( PLUS | MINUS ) term )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(215, 7);
    		PushFollow(Follow._term_in_simple2090);
    		term86=term();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, term86.Tree);
    		DebugLocation(215, 12);
    		// Evil.g:215:12: ( ( PLUS | MINUS ) term )*
    		try { DebugEnterSubRule(22);
    		while (true)
    		{
    			int alt22=2;
    			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
    			int LA22_0 = input.LA(1);

    			if (((LA22_0>=PLUS && LA22_0<=MINUS)))
    			{
    				alt22=1;
    			}


    			} finally { DebugExitDecision(22); }
    			switch ( alt22 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:215:13: ( PLUS | MINUS ) term
    				{
    				DebugLocation(215, 13);
    				// Evil.g:215:13: ( PLUS | MINUS )
    				int alt21=2;
    				try { DebugEnterSubRule(21);
    				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
    				int LA21_0 = input.LA(1);

    				if ((LA21_0==PLUS))
    				{
    					alt21=1;
    				}
    				else if ((LA21_0==MINUS))
    				{
    					alt21=2;
    				}
    				else
    				{
    					if (state.backtracking>0) {state.failed=true; return retval;}
    					NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

    					DebugRecognitionException(nvae);
    					throw nvae;
    				}
    				} finally { DebugExitDecision(21); }
    				switch (alt21)
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Evil.g:215:14: PLUS
    					{
    					DebugLocation(215, 18);
    					PLUS87=(IToken)Match(input,PLUS,Follow._PLUS_in_simple2094); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					PLUS87_tree = (object)adaptor.Create(PLUS87);
    					root_0 = (object)adaptor.BecomeRoot(PLUS87_tree, root_0);
    					}

    					}
    					break;
    				case 2:
    					DebugEnterAlt(2);
    					// Evil.g:215:22: MINUS
    					{
    					DebugLocation(215, 27);
    					MINUS88=(IToken)Match(input,MINUS,Follow._MINUS_in_simple2099); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					MINUS88_tree = (object)adaptor.Create(MINUS88);
    					root_0 = (object)adaptor.BecomeRoot(MINUS88_tree, root_0);
    					}

    					}
    					break;

    				}
    				} finally { DebugExitSubRule(21); }

    				DebugLocation(215, 30);
    				PushFollow(Follow._term_in_simple2103);
    				term89=term();
    				PopFollow();
    				if (state.failed) return retval;
    				if ( (state.backtracking==0) ) adaptor.AddChild(root_0, term89.Tree);

    				}
    				break;

    			default:
    				goto loop22;
    			}
    		}

    		loop22:
    			;

    		} finally { DebugExitSubRule(22); }


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(216, 3);
    	} finally { DebugExitRule(GrammarFileName, "simple"); }
    	return retval;

    }
    // $ANTLR end "simple"

    public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_term() {}
    protected virtual void Leave_term() {}

    // $ANTLR start "term"
    // Evil.g:217:1: term : unary ( ( TIMES | DIVIDE ) unary )* ;
    [GrammarRule("term")]
    private EvilParser.term_return term()
    {

        EvilParser.term_return retval = new EvilParser.term_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken TIMES91=null;
        IToken DIVIDE92=null;
        EvilParser.unary_return unary90 = default(EvilParser.unary_return);
        EvilParser.unary_return unary93 = default(EvilParser.unary_return);

        object TIMES91_tree=null;
        object DIVIDE92_tree=null;

    	try { DebugEnterRule(GrammarFileName, "term");
    	DebugLocation(217, 3);
    	try
    	{
    		// Evil.g:218:4: ( unary ( ( TIMES | DIVIDE ) unary )* )
    		DebugEnterAlt(1);
    		// Evil.g:218:7: unary ( ( TIMES | DIVIDE ) unary )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(218, 7);
    		PushFollow(Follow._unary_in_term2120);
    		unary90=unary();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, unary90.Tree);
    		DebugLocation(218, 13);
    		// Evil.g:218:13: ( ( TIMES | DIVIDE ) unary )*
    		try { DebugEnterSubRule(24);
    		while (true)
    		{
    			int alt24=2;
    			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
    			int LA24_0 = input.LA(1);

    			if (((LA24_0>=TIMES && LA24_0<=DIVIDE)))
    			{
    				alt24=1;
    			}


    			} finally { DebugExitDecision(24); }
    			switch ( alt24 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:218:14: ( TIMES | DIVIDE ) unary
    				{
    				DebugLocation(218, 14);
    				// Evil.g:218:14: ( TIMES | DIVIDE )
    				int alt23=2;
    				try { DebugEnterSubRule(23);
    				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
    				int LA23_0 = input.LA(1);

    				if ((LA23_0==TIMES))
    				{
    					alt23=1;
    				}
    				else if ((LA23_0==DIVIDE))
    				{
    					alt23=2;
    				}
    				else
    				{
    					if (state.backtracking>0) {state.failed=true; return retval;}
    					NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

    					DebugRecognitionException(nvae);
    					throw nvae;
    				}
    				} finally { DebugExitDecision(23); }
    				switch (alt23)
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Evil.g:218:15: TIMES
    					{
    					DebugLocation(218, 20);
    					TIMES91=(IToken)Match(input,TIMES,Follow._TIMES_in_term2124); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					TIMES91_tree = (object)adaptor.Create(TIMES91);
    					root_0 = (object)adaptor.BecomeRoot(TIMES91_tree, root_0);
    					}

    					}
    					break;
    				case 2:
    					DebugEnterAlt(2);
    					// Evil.g:218:24: DIVIDE
    					{
    					DebugLocation(218, 30);
    					DIVIDE92=(IToken)Match(input,DIVIDE,Follow._DIVIDE_in_term2129); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					DIVIDE92_tree = (object)adaptor.Create(DIVIDE92);
    					root_0 = (object)adaptor.BecomeRoot(DIVIDE92_tree, root_0);
    					}

    					}
    					break;

    				}
    				} finally { DebugExitSubRule(23); }

    				DebugLocation(218, 33);
    				PushFollow(Follow._unary_in_term2133);
    				unary93=unary();
    				PopFollow();
    				if (state.failed) return retval;
    				if ( (state.backtracking==0) ) adaptor.AddChild(root_0, unary93.Tree);

    				}
    				break;

    			default:
    				goto loop24;
    			}
    		}

    		loop24:
    			;

    		} finally { DebugExitSubRule(24); }


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(219, 3);
    	} finally { DebugExitRule(GrammarFileName, "term"); }
    	return retval;

    }
    // $ANTLR end "term"

    public class unary_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_unary() {}
    protected virtual void Leave_unary() {}

    // $ANTLR start "unary"
    // Evil.g:220:1: unary : ( NOT odd_not | MINUS odd_neg | selector );
    [GrammarRule("unary")]
    private EvilParser.unary_return unary()
    {

        EvilParser.unary_return retval = new EvilParser.unary_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken NOT94=null;
        IToken MINUS96=null;
        EvilParser.odd_not_return odd_not95 = default(EvilParser.odd_not_return);
        EvilParser.odd_neg_return odd_neg97 = default(EvilParser.odd_neg_return);
        EvilParser.selector_return selector98 = default(EvilParser.selector_return);

        object NOT94_tree=null;
        object MINUS96_tree=null;

    	try { DebugEnterRule(GrammarFileName, "unary");
    	DebugLocation(220, 3);
    	try
    	{
    		// Evil.g:221:4: ( NOT odd_not | MINUS odd_neg | selector )
    		int alt25=3;
    		try { DebugEnterDecision(25, decisionCanBacktrack[25]);
    		switch (input.LA(1))
    		{
    		case NOT:
    			{
    			alt25=1;
    			}
    			break;
    		case MINUS:
    			{
    			alt25=2;
    			}
    			break;
    		case TRUE:
    		case FALSE:
    		case NEW:
    		case NULL:
    		case LPAREN:
    		case ID:
    		case INTEGER:
    			{
    			alt25=3;
    			}
    			break;
    		default:
    			{
    				if (state.backtracking>0) {state.failed=true; return retval;}
    				NoViableAltException nvae = new NoViableAltException("", 25, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(25); }
    		switch (alt25)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:221:7: NOT odd_not
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(221, 10);
    			NOT94=(IToken)Match(input,NOT,Follow._NOT_in_unary2150); if (state.failed) return retval;
    			DebugLocation(221, 12);
    			PushFollow(Follow._odd_not_in_unary2153);
    			odd_not95=odd_not();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, odd_not95.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:222:7: MINUS odd_neg
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(222, 12);
    			MINUS96=(IToken)Match(input,MINUS,Follow._MINUS_in_unary2161); if (state.failed) return retval;
    			DebugLocation(222, 14);
    			PushFollow(Follow._odd_neg_in_unary2164);
    			odd_neg97=odd_neg();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, odd_neg97.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Evil.g:223:7: selector
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(223, 7);
    			PushFollow(Follow._selector_in_unary2172);
    			selector98=selector();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, selector98.Tree);

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(224, 3);
    	} finally { DebugExitRule(GrammarFileName, "unary"); }
    	return retval;

    }
    // $ANTLR end "unary"

    public class odd_not_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_odd_not() {}
    protected virtual void Leave_odd_not() {}

    // $ANTLR start "odd_not"
    // Evil.g:225:1: odd_not : ( NOT even_not | s= selector -> ^( NOT $s) );
    [GrammarRule("odd_not")]
    private EvilParser.odd_not_return odd_not()
    {

        EvilParser.odd_not_return retval = new EvilParser.odd_not_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken NOT99=null;
        EvilParser.selector_return s = default(EvilParser.selector_return);
        EvilParser.even_not_return even_not100 = default(EvilParser.even_not_return);

        object NOT99_tree=null;
        RewriteRuleSubtreeStream stream_selector=new RewriteRuleSubtreeStream(adaptor,"rule selector");
    	try { DebugEnterRule(GrammarFileName, "odd_not");
    	DebugLocation(225, 3);
    	try
    	{
    		// Evil.g:226:4: ( NOT even_not | s= selector -> ^( NOT $s) )
    		int alt26=2;
    		try { DebugEnterDecision(26, decisionCanBacktrack[26]);
    		int LA26_0 = input.LA(1);

    		if ((LA26_0==NOT))
    		{
    			alt26=1;
    		}
    		else if (((LA26_0>=TRUE && LA26_0<=NULL)||LA26_0==LPAREN||(LA26_0>=ID && LA26_0<=INTEGER)))
    		{
    			alt26=2;
    		}
    		else
    		{
    			if (state.backtracking>0) {state.failed=true; return retval;}
    			NoViableAltException nvae = new NoViableAltException("", 26, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(26); }
    		switch (alt26)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:226:7: NOT even_not
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(226, 10);
    			NOT99=(IToken)Match(input,NOT,Follow._NOT_in_odd_not2187); if (state.failed) return retval;
    			DebugLocation(226, 12);
    			PushFollow(Follow._even_not_in_odd_not2190);
    			even_not100=even_not();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, even_not100.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:227:7: s= selector
    			{
    			DebugLocation(227, 8);
    			PushFollow(Follow._selector_in_odd_not2200);
    			s=selector();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) stream_selector.Add(s.Tree);


    			{
    			// AST REWRITE
    			// elements: s
    			// token labels: 
    			// rule labels: retval, s
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			if ( (state.backtracking==0) ) {
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    			RewriteRuleSubtreeStream stream_s=new RewriteRuleSubtreeStream(adaptor,"rule s",s!=null?s.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 228:7: -> ^( NOT $s)
    			{
    				DebugLocation(228, 10);
    				// Evil.g:228:10: ^( NOT $s)
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(228, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NOT, "NOT"), root_1);

    				DebugLocation(228, 16);
    				adaptor.AddChild(root_1, stream_s.NextTree());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(229, 3);
    	} finally { DebugExitRule(GrammarFileName, "odd_not"); }
    	return retval;

    }
    // $ANTLR end "odd_not"

    public class even_not_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_even_not() {}
    protected virtual void Leave_even_not() {}

    // $ANTLR start "even_not"
    // Evil.g:230:1: even_not : ( NOT odd_not | selector );
    [GrammarRule("even_not")]
    private EvilParser.even_not_return even_not()
    {

        EvilParser.even_not_return retval = new EvilParser.even_not_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken NOT101=null;
        EvilParser.odd_not_return odd_not102 = default(EvilParser.odd_not_return);
        EvilParser.selector_return selector103 = default(EvilParser.selector_return);

        object NOT101_tree=null;

    	try { DebugEnterRule(GrammarFileName, "even_not");
    	DebugLocation(230, 3);
    	try
    	{
    		// Evil.g:231:4: ( NOT odd_not | selector )
    		int alt27=2;
    		try { DebugEnterDecision(27, decisionCanBacktrack[27]);
    		int LA27_0 = input.LA(1);

    		if ((LA27_0==NOT))
    		{
    			alt27=1;
    		}
    		else if (((LA27_0>=TRUE && LA27_0<=NULL)||LA27_0==LPAREN||(LA27_0>=ID && LA27_0<=INTEGER)))
    		{
    			alt27=2;
    		}
    		else
    		{
    			if (state.backtracking>0) {state.failed=true; return retval;}
    			NoViableAltException nvae = new NoViableAltException("", 27, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(27); }
    		switch (alt27)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:231:7: NOT odd_not
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(231, 10);
    			NOT101=(IToken)Match(input,NOT,Follow._NOT_in_even_not2230); if (state.failed) return retval;
    			DebugLocation(231, 12);
    			PushFollow(Follow._odd_not_in_even_not2233);
    			odd_not102=odd_not();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, odd_not102.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:232:7: selector
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(232, 7);
    			PushFollow(Follow._selector_in_even_not2241);
    			selector103=selector();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, selector103.Tree);

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(233, 3);
    	} finally { DebugExitRule(GrammarFileName, "even_not"); }
    	return retval;

    }
    // $ANTLR end "even_not"

    public class odd_neg_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_odd_neg() {}
    protected virtual void Leave_odd_neg() {}

    // $ANTLR start "odd_neg"
    // Evil.g:234:1: odd_neg : ( MINUS even_neg | s= selector -> ^( NEG $s) );
    [GrammarRule("odd_neg")]
    private EvilParser.odd_neg_return odd_neg()
    {

        EvilParser.odd_neg_return retval = new EvilParser.odd_neg_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken MINUS104=null;
        EvilParser.selector_return s = default(EvilParser.selector_return);
        EvilParser.even_neg_return even_neg105 = default(EvilParser.even_neg_return);

        object MINUS104_tree=null;
        RewriteRuleSubtreeStream stream_selector=new RewriteRuleSubtreeStream(adaptor,"rule selector");
    	try { DebugEnterRule(GrammarFileName, "odd_neg");
    	DebugLocation(234, 3);
    	try
    	{
    		// Evil.g:235:4: ( MINUS even_neg | s= selector -> ^( NEG $s) )
    		int alt28=2;
    		try { DebugEnterDecision(28, decisionCanBacktrack[28]);
    		int LA28_0 = input.LA(1);

    		if ((LA28_0==MINUS))
    		{
    			alt28=1;
    		}
    		else if (((LA28_0>=TRUE && LA28_0<=NULL)||LA28_0==LPAREN||(LA28_0>=ID && LA28_0<=INTEGER)))
    		{
    			alt28=2;
    		}
    		else
    		{
    			if (state.backtracking>0) {state.failed=true; return retval;}
    			NoViableAltException nvae = new NoViableAltException("", 28, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(28); }
    		switch (alt28)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:235:7: MINUS even_neg
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(235, 12);
    			MINUS104=(IToken)Match(input,MINUS,Follow._MINUS_in_odd_neg2256); if (state.failed) return retval;
    			DebugLocation(235, 14);
    			PushFollow(Follow._even_neg_in_odd_neg2259);
    			even_neg105=even_neg();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, even_neg105.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:236:7: s= selector
    			{
    			DebugLocation(236, 8);
    			PushFollow(Follow._selector_in_odd_neg2269);
    			s=selector();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) stream_selector.Add(s.Tree);


    			{
    			// AST REWRITE
    			// elements: s
    			// token labels: 
    			// rule labels: retval, s
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			if ( (state.backtracking==0) ) {
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    			RewriteRuleSubtreeStream stream_s=new RewriteRuleSubtreeStream(adaptor,"rule s",s!=null?s.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 237:7: -> ^( NEG $s)
    			{
    				DebugLocation(237, 10);
    				// Evil.g:237:10: ^( NEG $s)
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(237, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEG, "NEG"), root_1);

    				DebugLocation(237, 16);
    				adaptor.AddChild(root_1, stream_s.NextTree());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(238, 3);
    	} finally { DebugExitRule(GrammarFileName, "odd_neg"); }
    	return retval;

    }
    // $ANTLR end "odd_neg"

    public class even_neg_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_even_neg() {}
    protected virtual void Leave_even_neg() {}

    // $ANTLR start "even_neg"
    // Evil.g:239:1: even_neg : ( MINUS odd_neg | selector );
    [GrammarRule("even_neg")]
    private EvilParser.even_neg_return even_neg()
    {

        EvilParser.even_neg_return retval = new EvilParser.even_neg_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken MINUS106=null;
        EvilParser.odd_neg_return odd_neg107 = default(EvilParser.odd_neg_return);
        EvilParser.selector_return selector108 = default(EvilParser.selector_return);

        object MINUS106_tree=null;

    	try { DebugEnterRule(GrammarFileName, "even_neg");
    	DebugLocation(239, 3);
    	try
    	{
    		// Evil.g:240:4: ( MINUS odd_neg | selector )
    		int alt29=2;
    		try { DebugEnterDecision(29, decisionCanBacktrack[29]);
    		int LA29_0 = input.LA(1);

    		if ((LA29_0==MINUS))
    		{
    			alt29=1;
    		}
    		else if (((LA29_0>=TRUE && LA29_0<=NULL)||LA29_0==LPAREN||(LA29_0>=ID && LA29_0<=INTEGER)))
    		{
    			alt29=2;
    		}
    		else
    		{
    			if (state.backtracking>0) {state.failed=true; return retval;}
    			NoViableAltException nvae = new NoViableAltException("", 29, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(29); }
    		switch (alt29)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:240:7: MINUS odd_neg
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(240, 12);
    			MINUS106=(IToken)Match(input,MINUS,Follow._MINUS_in_even_neg2299); if (state.failed) return retval;
    			DebugLocation(240, 14);
    			PushFollow(Follow._odd_neg_in_even_neg2302);
    			odd_neg107=odd_neg();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, odd_neg107.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:241:7: selector
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(241, 7);
    			PushFollow(Follow._selector_in_even_neg2310);
    			selector108=selector();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, selector108.Tree);

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(242, 3);
    	} finally { DebugExitRule(GrammarFileName, "even_neg"); }
    	return retval;

    }
    // $ANTLR end "even_neg"

    public class selector_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_selector() {}
    protected virtual void Leave_selector() {}

    // $ANTLR start "selector"
    // Evil.g:243:1: selector : factor ( DOT ID )* ;
    [GrammarRule("selector")]
    private EvilParser.selector_return selector()
    {

        EvilParser.selector_return retval = new EvilParser.selector_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken DOT110=null;
        IToken ID111=null;
        EvilParser.factor_return factor109 = default(EvilParser.factor_return);

        object DOT110_tree=null;
        object ID111_tree=null;

    	try { DebugEnterRule(GrammarFileName, "selector");
    	DebugLocation(243, 3);
    	try
    	{
    		// Evil.g:244:4: ( factor ( DOT ID )* )
    		DebugEnterAlt(1);
    		// Evil.g:244:7: factor ( DOT ID )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(244, 7);
    		PushFollow(Follow._factor_in_selector2325);
    		factor109=factor();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, factor109.Tree);
    		DebugLocation(244, 14);
    		// Evil.g:244:14: ( DOT ID )*
    		try { DebugEnterSubRule(30);
    		while (true)
    		{
    			int alt30=2;
    			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
    			int LA30_0 = input.LA(1);

    			if ((LA30_0==DOT))
    			{
    				alt30=1;
    			}


    			} finally { DebugExitDecision(30); }
    			switch ( alt30 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:244:15: DOT ID
    				{
    				DebugLocation(244, 18);
    				DOT110=(IToken)Match(input,DOT,Follow._DOT_in_selector2328); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				DOT110_tree = (object)adaptor.Create(DOT110);
    				root_0 = (object)adaptor.BecomeRoot(DOT110_tree, root_0);
    				}
    				DebugLocation(244, 20);
    				ID111=(IToken)Match(input,ID,Follow._ID_in_selector2331); if (state.failed) return retval;
    				if ( state.backtracking==0 ) {
    				ID111_tree = (object)adaptor.Create(ID111);
    				adaptor.AddChild(root_0, ID111_tree);
    				}

    				}
    				break;

    			default:
    				goto loop30;
    			}
    		}

    		loop30:
    			;

    		} finally { DebugExitSubRule(30); }


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(245, 3);
    	} finally { DebugExitRule(GrammarFileName, "selector"); }
    	return retval;

    }
    // $ANTLR end "selector"

    public class factor_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_factor() {}
    protected virtual void Leave_factor() {}

    // $ANTLR start "factor"
    // Evil.g:246:1: factor : ( LPAREN expression RPAREN | id= ID a= arguments -> ^( INVOKE $id $a) | ID | INTEGER | TRUE | FALSE | NEW ID | NULL );
    [GrammarRule("factor")]
    private EvilParser.factor_return factor()
    {

        EvilParser.factor_return retval = new EvilParser.factor_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken id=null;
        IToken LPAREN112=null;
        IToken RPAREN114=null;
        IToken ID115=null;
        IToken INTEGER116=null;
        IToken TRUE117=null;
        IToken FALSE118=null;
        IToken NEW119=null;
        IToken ID120=null;
        IToken NULL121=null;
        EvilParser.arguments_return a = default(EvilParser.arguments_return);
        EvilParser.expression_return expression113 = default(EvilParser.expression_return);

        object id_tree=null;
        object LPAREN112_tree=null;
        object RPAREN114_tree=null;
        object ID115_tree=null;
        object INTEGER116_tree=null;
        object TRUE117_tree=null;
        object FALSE118_tree=null;
        object NEW119_tree=null;
        object ID120_tree=null;
        object NULL121_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_arguments=new RewriteRuleSubtreeStream(adaptor,"rule arguments");
    	try { DebugEnterRule(GrammarFileName, "factor");
    	DebugLocation(246, 3);
    	try
    	{
    		// Evil.g:247:4: ( LPAREN expression RPAREN | id= ID a= arguments -> ^( INVOKE $id $a) | ID | INTEGER | TRUE | FALSE | NEW ID | NULL )
    		int alt31=8;
    		try { DebugEnterDecision(31, decisionCanBacktrack[31]);
    		try
    		{
    			alt31 = dfa31.Predict(input);
    		}
    		catch (NoViableAltException nvae)
    		{
    			DebugRecognitionException(nvae);
    			throw;
    		}
    		} finally { DebugExitDecision(31); }
    		switch (alt31)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:247:7: LPAREN expression RPAREN
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(247, 13);
    			LPAREN112=(IToken)Match(input,LPAREN,Follow._LPAREN_in_factor2348); if (state.failed) return retval;
    			DebugLocation(247, 15);
    			PushFollow(Follow._expression_in_factor2351);
    			expression113=expression();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, expression113.Tree);
    			DebugLocation(247, 32);
    			RPAREN114=(IToken)Match(input,RPAREN,Follow._RPAREN_in_factor2353); if (state.failed) return retval;

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:248:7: id= ID a= arguments
    			{
    			DebugLocation(248, 9);
    			id=(IToken)Match(input,ID,Follow._ID_in_factor2364); if (state.failed) return retval; 
    			if ( (state.backtracking==0) ) stream_ID.Add(id);

    			DebugLocation(248, 14);
    			PushFollow(Follow._arguments_in_factor2368);
    			a=arguments();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) stream_arguments.Add(a.Tree);


    			{
    			// AST REWRITE
    			// elements: a, id
    			// token labels: id
    			// rule labels: retval, a
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			if ( (state.backtracking==0) ) {
    			retval.Tree = root_0;
    			RewriteRuleITokenStream stream_id=new RewriteRuleITokenStream(adaptor,"token id",id);
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
    			RewriteRuleSubtreeStream stream_a=new RewriteRuleSubtreeStream(adaptor,"rule a",a!=null?a.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 249:7: -> ^( INVOKE $id $a)
    			{
    				DebugLocation(249, 10);
    				// Evil.g:249:10: ^( INVOKE $id $a)
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(249, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INVOKE, "INVOKE"), root_1);

    				DebugLocation(249, 19);
    				adaptor.AddChild(root_1, stream_id.NextNode());
    				DebugLocation(249, 23);
    				adaptor.AddChild(root_1, stream_a.NextTree());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}
    			}

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Evil.g:250:7: ID
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(250, 7);
    			ID115=(IToken)Match(input,ID,Follow._ID_in_factor2394); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			ID115_tree = (object)adaptor.Create(ID115);
    			adaptor.AddChild(root_0, ID115_tree);
    			}

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Evil.g:251:7: INTEGER
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(251, 7);
    			INTEGER116=(IToken)Match(input,INTEGER,Follow._INTEGER_in_factor2402); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			INTEGER116_tree = (object)adaptor.Create(INTEGER116);
    			adaptor.AddChild(root_0, INTEGER116_tree);
    			}

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Evil.g:252:7: TRUE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(252, 7);
    			TRUE117=(IToken)Match(input,TRUE,Follow._TRUE_in_factor2410); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			TRUE117_tree = (object)adaptor.Create(TRUE117);
    			adaptor.AddChild(root_0, TRUE117_tree);
    			}

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// Evil.g:253:7: FALSE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(253, 7);
    			FALSE118=(IToken)Match(input,FALSE,Follow._FALSE_in_factor2418); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			FALSE118_tree = (object)adaptor.Create(FALSE118);
    			adaptor.AddChild(root_0, FALSE118_tree);
    			}

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// Evil.g:254:7: NEW ID
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(254, 10);
    			NEW119=(IToken)Match(input,NEW,Follow._NEW_in_factor2426); if (state.failed) return retval;
    			if ( (state.backtracking==0) ) {
    			NEW119_tree = (object)adaptor.Create(NEW119);
    			root_0 = (object)adaptor.BecomeRoot(NEW119_tree, root_0);
    			}
    			DebugLocation(254, 12);
    			ID120=(IToken)Match(input,ID,Follow._ID_in_factor2429); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			ID120_tree = (object)adaptor.Create(ID120);
    			adaptor.AddChild(root_0, ID120_tree);
    			}

    			}
    			break;
    		case 8:
    			DebugEnterAlt(8);
    			// Evil.g:255:7: NULL
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(255, 7);
    			NULL121=(IToken)Match(input,NULL,Follow._NULL_in_factor2437); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			NULL121_tree = (object)adaptor.Create(NULL121);
    			adaptor.AddChild(root_0, NULL121_tree);
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(256, 3);
    	} finally { DebugExitRule(GrammarFileName, "factor"); }
    	return retval;

    }
    // $ANTLR end "factor"

    public class arguments_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_arguments() {}
    protected virtual void Leave_arguments() {}

    // $ANTLR start "arguments"
    // Evil.g:257:1: arguments : LPAREN arg_list RPAREN ;
    [GrammarRule("arguments")]
    private EvilParser.arguments_return arguments()
    {

        EvilParser.arguments_return retval = new EvilParser.arguments_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken LPAREN122=null;
        IToken RPAREN124=null;
        EvilParser.arg_list_return arg_list123 = default(EvilParser.arg_list_return);

        object LPAREN122_tree=null;
        object RPAREN124_tree=null;

    	try { DebugEnterRule(GrammarFileName, "arguments");
    	DebugLocation(257, 3);
    	try
    	{
    		// Evil.g:258:4: ( LPAREN arg_list RPAREN )
    		DebugEnterAlt(1);
    		// Evil.g:258:7: LPAREN arg_list RPAREN
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(258, 13);
    		LPAREN122=(IToken)Match(input,LPAREN,Follow._LPAREN_in_arguments2452); if (state.failed) return retval;
    		DebugLocation(258, 15);
    		PushFollow(Follow._arg_list_in_arguments2455);
    		arg_list123=arg_list();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, arg_list123.Tree);
    		DebugLocation(258, 30);
    		RPAREN124=(IToken)Match(input,RPAREN,Follow._RPAREN_in_arguments2457); if (state.failed) return retval;

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(259, 3);
    	} finally { DebugExitRule(GrammarFileName, "arguments"); }
    	return retval;

    }
    // $ANTLR end "arguments"

    public class arg_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_arg_list() {}
    protected virtual void Leave_arg_list() {}

    // $ANTLR start "arg_list"
    // Evil.g:260:1: arg_list : ( expression ( COMMA expression )* -> ^( ARGS ( expression )+ ) | -> ARGS );
    [GrammarRule("arg_list")]
    private EvilParser.arg_list_return arg_list()
    {

        EvilParser.arg_list_return retval = new EvilParser.arg_list_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken COMMA126=null;
        EvilParser.expression_return expression125 = default(EvilParser.expression_return);
        EvilParser.expression_return expression127 = default(EvilParser.expression_return);

        object COMMA126_tree=null;
        RewriteRuleITokenStream stream_COMMA=new RewriteRuleITokenStream(adaptor,"token COMMA");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
    	try { DebugEnterRule(GrammarFileName, "arg_list");
    	DebugLocation(260, 3);
    	try
    	{
    		// Evil.g:261:4: ( expression ( COMMA expression )* -> ^( ARGS ( expression )+ ) | -> ARGS )
    		int alt33=2;
    		try { DebugEnterDecision(33, decisionCanBacktrack[33]);
    		int LA33_0 = input.LA(1);

    		if (((LA33_0>=TRUE && LA33_0<=NULL)||LA33_0==LPAREN||LA33_0==MINUS||(LA33_0>=NOT && LA33_0<=INTEGER)))
    		{
    			alt33=1;
    		}
    		else if ((LA33_0==RPAREN))
    		{
    			alt33=2;
    		}
    		else
    		{
    			if (state.backtracking>0) {state.failed=true; return retval;}
    			NoViableAltException nvae = new NoViableAltException("", 33, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(33); }
    		switch (alt33)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Evil.g:261:7: expression ( COMMA expression )*
    			{
    			DebugLocation(261, 7);
    			PushFollow(Follow._expression_in_arg_list2473);
    			expression125=expression();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) stream_expression.Add(expression125.Tree);
    			DebugLocation(261, 18);
    			// Evil.g:261:18: ( COMMA expression )*
    			try { DebugEnterSubRule(32);
    			while (true)
    			{
    				int alt32=2;
    				try { DebugEnterDecision(32, decisionCanBacktrack[32]);
    				int LA32_0 = input.LA(1);

    				if ((LA32_0==COMMA))
    				{
    					alt32=1;
    				}


    				} finally { DebugExitDecision(32); }
    				switch ( alt32 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Evil.g:261:19: COMMA expression
    					{
    					DebugLocation(261, 19);
    					COMMA126=(IToken)Match(input,COMMA,Follow._COMMA_in_arg_list2476); if (state.failed) return retval; 
    					if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA126);

    					DebugLocation(261, 25);
    					PushFollow(Follow._expression_in_arg_list2478);
    					expression127=expression();
    					PopFollow();
    					if (state.failed) return retval;
    					if ( (state.backtracking==0) ) stream_expression.Add(expression127.Tree);

    					}
    					break;

    				default:
    					goto loop32;
    				}
    			}

    			loop32:
    				;

    			} finally { DebugExitSubRule(32); }



    			{
    			// AST REWRITE
    			// elements: expression
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			if ( (state.backtracking==0) ) {
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 262:7: -> ^( ARGS ( expression )+ )
    			{
    				DebugLocation(262, 10);
    				// Evil.g:262:10: ^( ARGS ( expression )+ )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(262, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARGS, "ARGS"), root_1);

    				DebugLocation(262, 17);
    				if ( !(stream_expression.HasNext) )
    				{
    					throw new RewriteEarlyExitException();
    				}
    				while ( stream_expression.HasNext )
    				{
    					DebugLocation(262, 17);
    					adaptor.AddChild(root_1, stream_expression.NextTree());

    				}
    				stream_expression.Reset();

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:264:7: 
    			{

    			{
    			// AST REWRITE
    			// elements: 
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			if ( (state.backtracking==0) ) {
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 264:7: -> ARGS
    			{
    				DebugLocation(264, 10);
    				adaptor.AddChild(root_0, (object)adaptor.Create(ARGS, "ARGS"));

    			}

    			retval.Tree = root_0;
    			}
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		if ( (state.backtracking==0) ) {

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
    		}
    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(265, 3);
    	} finally { DebugExitRule(GrammarFileName, "arg_list"); }
    	return retval;

    }
    // $ANTLR end "arg_list"

    protected virtual void Enter_synpred1_Evil_fragment() {}
    protected virtual void Leave_synpred1_Evil_fragment() {}

    // $ANTLR start synpred1_Evil
    public void synpred1_Evil_fragment()
    {
    	// Evil.g:113:7: ( STRUCT ID LBRACE )
    	DebugEnterAlt(1);
    	// Evil.g:113:8: STRUCT ID LBRACE
    	{
    	DebugLocation(113, 8);
    	Match(input,STRUCT,Follow._STRUCT_in_synpred1_Evil1113); if (state.failed) return;
    	DebugLocation(113, 15);
    	Match(input,ID,Follow._ID_in_synpred1_Evil1115); if (state.failed) return;
    	DebugLocation(113, 18);
    	Match(input,LBRACE,Follow._LBRACE_in_synpred1_Evil1117); if (state.failed) return;

    	}
    }
    // $ANTLR end synpred1_Evil

    protected virtual void Enter_synpred2_Evil_fragment() {}
    protected virtual void Leave_synpred2_Evil_fragment() {}

    // $ANTLR start synpred2_Evil
    public void synpred2_Evil_fragment()
    {
    	// Evil.g:117:7: ( STRUCT ID LBRACE )
    	DebugEnterAlt(1);
    	// Evil.g:117:8: STRUCT ID LBRACE
    	{
    	DebugLocation(117, 8);
    	Match(input,STRUCT,Follow._STRUCT_in_synpred2_Evil1156); if (state.failed) return;
    	DebugLocation(117, 15);
    	Match(input,ID,Follow._ID_in_synpred2_Evil1158); if (state.failed) return;
    	DebugLocation(117, 18);
    	Match(input,LBRACE,Follow._LBRACE_in_synpred2_Evil1160); if (state.failed) return;

    	}
    }
    // $ANTLR end synpred2_Evil

    protected virtual void Enter_synpred3_Evil_fragment() {}
    protected virtual void Leave_synpred3_Evil_fragment() {}

    // $ANTLR start synpred3_Evil
    public void synpred3_Evil_fragment()
    {
    	// Evil.g:162:7: ( lvalue ASSIGN )
    	DebugEnterAlt(1);
    	// Evil.g:162:8: lvalue ASSIGN
    	{
    	DebugLocation(162, 8);
    	PushFollow(Follow._lvalue_in_synpred3_Evil1580);
    	lvalue();
    	PopFollow();
    	if (state.failed) return;
    	DebugLocation(162, 15);
    	Match(input,ASSIGN,Follow._ASSIGN_in_synpred3_Evil1582); if (state.failed) return;

    	}
    }
    // $ANTLR end synpred3_Evil

    protected virtual void Enter_synpred4_Evil_fragment() {}
    protected virtual void Leave_synpred4_Evil_fragment() {}

    // $ANTLR start synpred4_Evil
    public void synpred4_Evil_fragment()
    {
    	// Evil.g:169:7: ( ID LPAREN )
    	DebugEnterAlt(1);
    	// Evil.g:169:8: ID LPAREN
    	{
    	DebugLocation(169, 8);
    	Match(input,ID,Follow._ID_in_synpred4_Evil1644); if (state.failed) return;
    	DebugLocation(169, 11);
    	Match(input,LPAREN,Follow._LPAREN_in_synpred4_Evil1646); if (state.failed) return;

    	}
    }
    // $ANTLR end synpred4_Evil
	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA11 dfa11;
	DFA31 dfa31;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa11 = new DFA11( this, SpecialStateTransition11 );
		dfa31 = new DFA31( this );
	}

	private class DFA11 : DFA
	{
		private const string DFA11_eotS =
			"\x0c\uffff";
		private const string DFA11_eofS =
			"\x0c\uffff";
		private const string DFA11_minS =
			"\x01\x09\x01\uffff\x01\x27\x09\uffff";
		private const string DFA11_maxS =
			"\x01\x38\x01\uffff\x01\x2a\x09\uffff";
		private const string DFA11_acceptS =
			"\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07"+
			"\x01\x08\x02\x02\x01\x09";
		private const string DFA11_specialS =
			"\x02\uffff\x01\x00\x09\uffff}>";
		private static readonly string[] DFA11_transitionS =
			{
				"\x01\x03\x01\uffff\x01\x04\x01\x05\x01\uffff\x01\x06\x01\x07\x01\x08"+
				"\x12\uffff\x01\x01\x14\uffff\x01\x02",
				"",
				"\x01\x0b\x01\uffff\x01\x0a\x01\x09",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
		private static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
		private static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
		private static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
		private static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
		private static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
		private static readonly short[][] DFA11_transition;

		static DFA11()
		{
			int numStates = DFA11_transitionS.Length;
			DFA11_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA11_transition[i] = DFA.UnpackEncodedString(DFA11_transitionS[i]);
			}
		}

		public DFA11( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 11;
			this.eot = DFA11_eot;
			this.eof = DFA11_eof;
			this.min = DFA11_min;
			this.max = DFA11_max;
			this.accept = DFA11_accept;
			this.special = DFA11_special;
			this.transition = DFA11_transition;
		}

		public override string Description { get { return "160:1: statement : ( block | ( lvalue ASSIGN )=> assignment | print | read | conditional | loop | delete | ret | ( ID LPAREN )=> invocation );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition11(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA11_2 = input.LA(1);


				int index11_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (LA11_2==DOT) && (EvaluatePredicate(synpred3_Evil_fragment))) {s = 9;}

				else if ( (LA11_2==ASSIGN) && (EvaluatePredicate(synpred3_Evil_fragment))) {s = 10;}

				else if ( (LA11_2==LPAREN) && (EvaluatePredicate(synpred4_Evil_fragment))) {s = 11;}


				input.Seek(index11_2);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 11, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA31 : DFA
	{
		private const string DFA31_eotS =
			"\x0a\uffff";
		private const string DFA31_eofS =
			"\x0a\uffff";
		private const string DFA31_minS =
			"\x01\x11\x01\uffff\x01\x0a\x07\uffff";
		private const string DFA31_maxS =
			"\x01\x39\x01\uffff\x01\x36\x07\uffff";
		private const string DFA31_acceptS =
			"\x01\uffff\x01\x01\x01\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08"+
			"\x01\x02\x01\x03";
		private const string DFA31_specialS =
			"\x0a\uffff}>";
		private static readonly string[] DFA31_transitionS =
			{
				"\x01\x04\x01\x05\x01\x06\x01\x07\x12\uffff\x01\x01\x10\uffff\x01\x02"+
				"\x01\x03",
				"",
				"\x01\x09\x1a\uffff\x02\x09\x01\x08\x01\x09\x01\uffff\x0d\x09",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA31_eot = DFA.UnpackEncodedString(DFA31_eotS);
		private static readonly short[] DFA31_eof = DFA.UnpackEncodedString(DFA31_eofS);
		private static readonly char[] DFA31_min = DFA.UnpackEncodedStringToUnsignedChars(DFA31_minS);
		private static readonly char[] DFA31_max = DFA.UnpackEncodedStringToUnsignedChars(DFA31_maxS);
		private static readonly short[] DFA31_accept = DFA.UnpackEncodedString(DFA31_acceptS);
		private static readonly short[] DFA31_special = DFA.UnpackEncodedString(DFA31_specialS);
		private static readonly short[][] DFA31_transition;

		static DFA31()
		{
			int numStates = DFA31_transitionS.Length;
			DFA31_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA31_transition[i] = DFA.UnpackEncodedString(DFA31_transitionS[i]);
			}
		}

		public DFA31( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 31;
			this.eot = DFA31_eot;
			this.eof = DFA31_eof;
			this.min = DFA31_min;
			this.max = DFA31_max;
			this.accept = DFA31_accept;
			this.special = DFA31_special;
			this.transition = DFA31_transition;
		}

		public override string Description { get { return "246:1: factor : ( LPAREN expression RPAREN | id= ID a= arguments -> ^( INVOKE $id $a) | ID | INTEGER | TRUE | FALSE | NEW ID | NULL );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _types_in_program1066 = new BitSet(new ulong[]{0x00000000000000F0UL});
		public static readonly BitSet _declarations_in_program1070 = new BitSet(new ulong[]{0x0000000000000080UL});
		public static readonly BitSet _functions_in_program1074 = new BitSet(new ulong[]{0x0000000000000000UL});
		public static readonly BitSet _EOF_in_program1076 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _types_sub_in_types1122 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _type_declaration_in_types_sub1165 = new BitSet(new ulong[]{0x0000000000000010UL});
		public static readonly BitSet _types_sub_in_types_sub1167 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRUCT_in_type_declaration1187 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_type_declaration1190 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _LBRACE_in_type_declaration1192 = new BitSet(new ulong[]{0x0000000000000070UL});
		public static readonly BitSet _nested_decl_in_type_declaration1195 = new BitSet(new ulong[]{0x0000001000000000UL});
		public static readonly BitSet _RBRACE_in_type_declaration1197 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_type_declaration1200 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _decl_in_nested_decl1217 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_nested_decl1219 = new BitSet(new ulong[]{0x0000000000000072UL});
		public static readonly BitSet _type_in_decl1239 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_decl1243 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INT_in_type1280 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BOOL_in_type1288 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRUCT_in_type1296 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_type1299 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _declaration_in_declarations1315 = new BitSet(new ulong[]{0x0000000000000072UL});
		public static readonly BitSet _type_in_declaration1343 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _id_list_in_declaration1347 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_declaration1349 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_id_list1386 = new BitSet(new ulong[]{0x0000004000000002UL});
		public static readonly BitSet _COMMA_in_id_list1389 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_id_list1392 = new BitSet(new ulong[]{0x0000004000000002UL});
		public static readonly BitSet _function_in_functions1409 = new BitSet(new ulong[]{0x0000000000000082UL});
		public static readonly BitSet _FUN_in_function1434 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_function1438 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _parameters_in_function1442 = new BitSet(new ulong[]{0x0000000000000170UL});
		public static readonly BitSet _return_type_in_function1446 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _LBRACE_in_function1448 = new BitSet(new ulong[]{0x010000180001DA70UL});
		public static readonly BitSet _declarations_in_function1452 = new BitSet(new ulong[]{0x010000180001DA00UL});
		public static readonly BitSet _statement_list_in_function1456 = new BitSet(new ulong[]{0x0000001000000000UL});
		public static readonly BitSet _RBRACE_in_function1458 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _LPAREN_in_parameters1504 = new BitSet(new ulong[]{0x0000010000000070UL});
		public static readonly BitSet _decl_in_parameters1507 = new BitSet(new ulong[]{0x0000014000000000UL});
		public static readonly BitSet _COMMA_in_parameters1510 = new BitSet(new ulong[]{0x0000000000000070UL});
		public static readonly BitSet _decl_in_parameters1512 = new BitSet(new ulong[]{0x0000014000000000UL});
		public static readonly BitSet _RPAREN_in_parameters1518 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _type_in_return_type1548 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VOID_in_return_type1556 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _block_in_statement1571 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assignment_in_statement1587 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _print_in_statement1595 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _read_in_statement1603 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _conditional_in_statement1611 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _loop_in_statement1619 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _delete_in_statement1627 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ret_in_statement1635 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _invocation_in_statement1651 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _LBRACE_in_block1666 = new BitSet(new ulong[]{0x010000180001DA00UL});
		public static readonly BitSet _statement_list_in_block1670 = new BitSet(new ulong[]{0x0000001000000000UL});
		public static readonly BitSet _RBRACE_in_block1672 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _statement_in_statement_list1703 = new BitSet(new ulong[]{0x010000080001DA02UL});
		public static readonly BitSet _lvalue_in_assignment1731 = new BitSet(new ulong[]{0x0000020000000000UL});
		public static readonly BitSet _ASSIGN_in_assignment1733 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_assignment1737 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_assignment1739 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PRINT_in_print1772 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_print1775 = new BitSet(new ulong[]{0x0000002000000400UL});
		public static readonly BitSet _ENDL_in_print1778 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_print1782 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _READ_in_read1798 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _lvalue_in_read1801 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_read1803 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _IF_in_conditional1819 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _LPAREN_in_conditional1822 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_conditional1825 = new BitSet(new ulong[]{0x0000010000000000UL});
		public static readonly BitSet _RPAREN_in_conditional1827 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _block_in_conditional1830 = new BitSet(new ulong[]{0x0000000000002002UL});
		public static readonly BitSet _ELSE_in_conditional1833 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _block_in_conditional1836 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _WHILE_in_loop1853 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _LPAREN_in_loop1855 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_loop1859 = new BitSet(new ulong[]{0x0000010000000000UL});
		public static readonly BitSet _RPAREN_in_loop1861 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _block_in_loop1865 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _DELETE_in_delete1901 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_delete1904 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_delete1906 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _RETURN_in_ret1922 = new BitSet(new ulong[]{0x039000A0001E0000UL});
		public static readonly BitSet _expression_in_ret1926 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_ret1930 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_invocation1948 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _arguments_in_invocation1952 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_invocation1954 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_lvalue1987 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _DOT_in_lvalue1990 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_lvalue1993 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _boolterm_in_expression2010 = new BitSet(new ulong[]{0x0000180000000002UL});
		public static readonly BitSet _AND_in_expression2014 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _OR_in_expression2019 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _boolterm_in_expression2023 = new BitSet(new ulong[]{0x0000180000000002UL});
		public static readonly BitSet _simple_in_boolterm2040 = new BitSet(new ulong[]{0x0007E00000000002UL});
		public static readonly BitSet _EQ_in_boolterm2044 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _LT_in_boolterm2049 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _GT_in_boolterm2054 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _NE_in_boolterm2059 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _LE_in_boolterm2064 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _GE_in_boolterm2069 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _simple_in_boolterm2073 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _term_in_simple2090 = new BitSet(new ulong[]{0x0018000000000002UL});
		public static readonly BitSet _PLUS_in_simple2094 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _MINUS_in_simple2099 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _term_in_simple2103 = new BitSet(new ulong[]{0x0018000000000002UL});
		public static readonly BitSet _unary_in_term2120 = new BitSet(new ulong[]{0x0060000000000002UL});
		public static readonly BitSet _TIMES_in_term2124 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _DIVIDE_in_term2129 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _unary_in_term2133 = new BitSet(new ulong[]{0x0060000000000002UL});
		public static readonly BitSet _NOT_in_unary2150 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _odd_not_in_unary2153 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _MINUS_in_unary2161 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _odd_neg_in_unary2164 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _selector_in_unary2172 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NOT_in_odd_not2187 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _even_not_in_odd_not2190 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _selector_in_odd_not2200 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NOT_in_even_not2230 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _odd_not_in_even_not2233 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _selector_in_even_not2241 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _MINUS_in_odd_neg2256 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _even_neg_in_odd_neg2259 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _selector_in_odd_neg2269 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _MINUS_in_even_neg2299 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _odd_neg_in_even_neg2302 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _selector_in_even_neg2310 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _factor_in_selector2325 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _DOT_in_selector2328 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_selector2331 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _LPAREN_in_factor2348 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_factor2351 = new BitSet(new ulong[]{0x0000010000000000UL});
		public static readonly BitSet _RPAREN_in_factor2353 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_factor2364 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _arguments_in_factor2368 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_factor2394 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INTEGER_in_factor2402 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _TRUE_in_factor2410 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FALSE_in_factor2418 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NEW_in_factor2426 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_factor2429 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NULL_in_factor2437 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _LPAREN_in_arguments2452 = new BitSet(new ulong[]{0x03900180001E0000UL});
		public static readonly BitSet _arg_list_in_arguments2455 = new BitSet(new ulong[]{0x0000010000000000UL});
		public static readonly BitSet _RPAREN_in_arguments2457 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expression_in_arg_list2473 = new BitSet(new ulong[]{0x0000004000000002UL});
		public static readonly BitSet _COMMA_in_arg_list2476 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_arg_list2478 = new BitSet(new ulong[]{0x0000004000000002UL});
		public static readonly BitSet _STRUCT_in_synpred1_Evil1113 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_synpred1_Evil1115 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _LBRACE_in_synpred1_Evil1117 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRUCT_in_synpred2_Evil1156 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_synpred2_Evil1158 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _LBRACE_in_synpred2_Evil1160 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _lvalue_in_synpred3_Evil1580 = new BitSet(new ulong[]{0x0000020000000000UL});
		public static readonly BitSet _ASSIGN_in_synpred3_Evil1582 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_synpred4_Evil1644 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _LPAREN_in_synpred4_Evil1646 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}