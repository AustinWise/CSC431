// $ANTLR 3.3 Nov 30, 2010 12:50:56 Evil.g 2011-01-16 01:54:26

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
    // Evil.g:113:1: program : t= types d= declarations f= functions EOF -> ^( PROGRAM $t $d $f) ;
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
    	DebugLocation(113, 3);
    	try
    	{
    		// Evil.g:114:4: (t= types d= declarations f= functions EOF -> ^( PROGRAM $t $d $f) )
    		DebugEnterAlt(1);
    		// Evil.g:114:7: t= types d= declarations f= functions EOF
    		{
    		DebugLocation(114, 8);
    		PushFollow(Follow._types_in_program1072);
    		t=types();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_types.Add(t.Tree);
    		DebugLocation(114, 16);
    		PushFollow(Follow._declarations_in_program1076);
    		d=declarations();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_declarations.Add(d.Tree);
    		DebugLocation(114, 31);
    		PushFollow(Follow._functions_in_program1080);
    		f=functions();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_functions.Add(f.Tree);
    		DebugLocation(114, 42);
    		EOF1=(IToken)Match(input,EOF,Follow._EOF_in_program1082); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_EOF.Add(EOF1);



    		{
    		// AST REWRITE
    		// elements: f, d, t
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
    		// 115:7: -> ^( PROGRAM $t $d $f)
    		{
    			DebugLocation(115, 10);
    			// Evil.g:115:10: ^( PROGRAM $t $d $f)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(115, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

    			DebugLocation(115, 20);
    			adaptor.AddChild(root_1, stream_t.NextTree());
    			DebugLocation(115, 23);
    			adaptor.AddChild(root_1, stream_d.NextTree());
    			DebugLocation(115, 26);
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
     	DebugLocation(116, 3);
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
    // Evil.g:117:1: types : ( ( STRUCT ID LBRACE )=> types_sub -> ^( TYPES types_sub ) | -> TYPES );
    [GrammarRule("types")]
    private EvilParser.types_return types()
    {

        EvilParser.types_return retval = new EvilParser.types_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.types_sub_return types_sub2 = default(EvilParser.types_sub_return);

        RewriteRuleSubtreeStream stream_types_sub=new RewriteRuleSubtreeStream(adaptor,"rule types_sub");
    	try { DebugEnterRule(GrammarFileName, "types");
    	DebugLocation(117, 3);
    	try
    	{
    		// Evil.g:118:4: ( ( STRUCT ID LBRACE )=> types_sub -> ^( TYPES types_sub ) | -> TYPES )
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
    			// Evil.g:118:7: ( STRUCT ID LBRACE )=> types_sub
    			{
    			DebugLocation(118, 29);
    			PushFollow(Follow._types_sub_in_types1128);
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
    			// 118:39: -> ^( TYPES types_sub )
    			{
    				DebugLocation(118, 42);
    				// Evil.g:118:42: ^( TYPES types_sub )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(118, 44);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPES, "TYPES"), root_1);

    				DebugLocation(118, 50);
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
    			// Evil.g:119:7: 
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
    			// 119:7: -> TYPES
    			{
    				DebugLocation(119, 10);
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
     	DebugLocation(120, 3);
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
    // Evil.g:121:1: types_sub : ( ( STRUCT ID LBRACE )=> type_declaration types_sub | );
    [GrammarRule("types_sub")]
    private EvilParser.types_sub_return types_sub()
    {

        EvilParser.types_sub_return retval = new EvilParser.types_sub_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.type_declaration_return type_declaration3 = default(EvilParser.type_declaration_return);
        EvilParser.types_sub_return types_sub4 = default(EvilParser.types_sub_return);


    	try { DebugEnterRule(GrammarFileName, "types_sub");
    	DebugLocation(121, 3);
    	try
    	{
    		// Evil.g:122:4: ( ( STRUCT ID LBRACE )=> type_declaration types_sub | )
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
    			// Evil.g:122:7: ( STRUCT ID LBRACE )=> type_declaration types_sub
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(122, 29);
    			PushFollow(Follow._type_declaration_in_types_sub1171);
    			type_declaration3=type_declaration();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, type_declaration3.Tree);
    			DebugLocation(122, 46);
    			PushFollow(Follow._types_sub_in_types_sub1173);
    			types_sub4=types_sub();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, types_sub4.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:124:4: 
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
     	DebugLocation(124, 3);
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
    // Evil.g:125:1: type_declaration : STRUCT ID LBRACE nested_decl RBRACE SEMI ;
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
    	DebugLocation(125, 3);
    	try
    	{
    		// Evil.g:126:4: ( STRUCT ID LBRACE nested_decl RBRACE SEMI )
    		DebugEnterAlt(1);
    		// Evil.g:126:7: STRUCT ID LBRACE nested_decl RBRACE SEMI
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(126, 13);
    		STRUCT5=(IToken)Match(input,STRUCT,Follow._STRUCT_in_type_declaration1193); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		STRUCT5_tree = (object)adaptor.Create(STRUCT5);
    		root_0 = (object)adaptor.BecomeRoot(STRUCT5_tree, root_0);
    		}
    		DebugLocation(126, 15);
    		ID6=(IToken)Match(input,ID,Follow._ID_in_type_declaration1196); if (state.failed) return retval;
    		if ( state.backtracking==0 ) {
    		ID6_tree = (object)adaptor.Create(ID6);
    		adaptor.AddChild(root_0, ID6_tree);
    		}
    		DebugLocation(126, 24);
    		LBRACE7=(IToken)Match(input,LBRACE,Follow._LBRACE_in_type_declaration1198); if (state.failed) return retval;
    		DebugLocation(126, 26);
    		PushFollow(Follow._nested_decl_in_type_declaration1201);
    		nested_decl8=nested_decl();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, nested_decl8.Tree);
    		DebugLocation(126, 44);
    		RBRACE9=(IToken)Match(input,RBRACE,Follow._RBRACE_in_type_declaration1203); if (state.failed) return retval;
    		DebugLocation(126, 50);
    		SEMI10=(IToken)Match(input,SEMI,Follow._SEMI_in_type_declaration1206); if (state.failed) return retval;

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
     	DebugLocation(127, 3);
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
    // Evil.g:128:1: nested_decl : ( decl SEMI )+ ;
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
    	DebugLocation(128, 3);
    	try
    	{
    		// Evil.g:129:4: ( ( decl SEMI )+ )
    		DebugEnterAlt(1);
    		// Evil.g:129:7: ( decl SEMI )+
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(129, 7);
    		// Evil.g:129:7: ( decl SEMI )+
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
    				// Evil.g:129:8: decl SEMI
    				{
    				DebugLocation(129, 8);
    				PushFollow(Follow._decl_in_nested_decl1223);
    				decl11=decl();
    				PopFollow();
    				if (state.failed) return retval;
    				if ( (state.backtracking==0) ) adaptor.AddChild(root_0, decl11.Tree);
    				DebugLocation(129, 17);
    				SEMI12=(IToken)Match(input,SEMI,Follow._SEMI_in_nested_decl1225); if (state.failed) return retval;

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
     	DebugLocation(130, 3);
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
    // Evil.g:131:1: decl : t= type i= ID -> ^( DECL ^( TYPE $t) $i) ;
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
    	DebugLocation(131, 3);
    	try
    	{
    		// Evil.g:132:4: (t= type i= ID -> ^( DECL ^( TYPE $t) $i) )
    		DebugEnterAlt(1);
    		// Evil.g:132:7: t= type i= ID
    		{
    		DebugLocation(132, 8);
    		PushFollow(Follow._type_in_decl1245);
    		t=type();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_type.Add(t.Tree);
    		DebugLocation(132, 15);
    		i=(IToken)Match(input,ID,Follow._ID_in_decl1249); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_ID.Add(i);



    		{
    		// AST REWRITE
    		// elements: t, i
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
    		// 133:7: -> ^( DECL ^( TYPE $t) $i)
    		{
    			DebugLocation(133, 10);
    			// Evil.g:133:10: ^( DECL ^( TYPE $t) $i)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(133, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECL, "DECL"), root_1);

    			DebugLocation(133, 17);
    			// Evil.g:133:17: ^( TYPE $t)
    			{
    			object root_2 = (object)adaptor.Nil();
    			DebugLocation(133, 19);
    			root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE, "TYPE"), root_2);

    			DebugLocation(133, 24);
    			adaptor.AddChild(root_2, stream_t.NextTree());

    			adaptor.AddChild(root_1, root_2);
    			}
    			DebugLocation(133, 28);
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
     	DebugLocation(134, 3);
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
    // Evil.g:135:1: type : ( INT | BOOL | STRUCT ID );
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
    	DebugLocation(135, 3);
    	try
    	{
    		// Evil.g:136:4: ( INT | BOOL | STRUCT ID )
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
    			// Evil.g:136:7: INT
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(136, 7);
    			INT13=(IToken)Match(input,INT,Follow._INT_in_type1286); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			INT13_tree = (object)adaptor.Create(INT13);
    			adaptor.AddChild(root_0, INT13_tree);
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:137:7: BOOL
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(137, 7);
    			BOOL14=(IToken)Match(input,BOOL,Follow._BOOL_in_type1294); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			BOOL14_tree = (object)adaptor.Create(BOOL14);
    			adaptor.AddChild(root_0, BOOL14_tree);
    			}

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Evil.g:138:7: STRUCT ID
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(138, 13);
    			STRUCT15=(IToken)Match(input,STRUCT,Follow._STRUCT_in_type1302); if (state.failed) return retval;
    			if ( (state.backtracking==0) ) {
    			STRUCT15_tree = (object)adaptor.Create(STRUCT15);
    			root_0 = (object)adaptor.BecomeRoot(STRUCT15_tree, root_0);
    			}
    			DebugLocation(138, 15);
    			ID16=(IToken)Match(input,ID,Follow._ID_in_type1305); if (state.failed) return retval;
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
     	DebugLocation(139, 3);
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
    // Evil.g:140:1: declarations : ( declaration )* -> ^( DECLS ( declaration )* ) ;
    [GrammarRule("declarations")]
    private EvilParser.declarations_return declarations()
    {

        EvilParser.declarations_return retval = new EvilParser.declarations_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.declaration_return declaration17 = default(EvilParser.declaration_return);

        RewriteRuleSubtreeStream stream_declaration=new RewriteRuleSubtreeStream(adaptor,"rule declaration");
    	try { DebugEnterRule(GrammarFileName, "declarations");
    	DebugLocation(140, 3);
    	try
    	{
    		// Evil.g:141:4: ( ( declaration )* -> ^( DECLS ( declaration )* ) )
    		DebugEnterAlt(1);
    		// Evil.g:141:7: ( declaration )*
    		{
    		DebugLocation(141, 7);
    		// Evil.g:141:7: ( declaration )*
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
    				// Evil.g:141:8: declaration
    				{
    				DebugLocation(141, 8);
    				PushFollow(Follow._declaration_in_declarations1321);
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
    		// 141:22: -> ^( DECLS ( declaration )* )
    		{
    			DebugLocation(141, 25);
    			// Evil.g:141:25: ^( DECLS ( declaration )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(141, 27);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECLS, "DECLS"), root_1);

    			DebugLocation(141, 33);
    			// Evil.g:141:33: ( declaration )*
    			while ( stream_declaration.HasNext )
    			{
    				DebugLocation(141, 33);
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
     	DebugLocation(142, 3);
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
    // Evil.g:143:1: declaration : t= type ilist= id_list SEMI -> ^( DECLLIST ^( TYPE $t) $ilist) ;
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
    	DebugLocation(143, 3);
    	try
    	{
    		// Evil.g:144:4: (t= type ilist= id_list SEMI -> ^( DECLLIST ^( TYPE $t) $ilist) )
    		DebugEnterAlt(1);
    		// Evil.g:144:7: t= type ilist= id_list SEMI
    		{
    		DebugLocation(144, 8);
    		PushFollow(Follow._type_in_declaration1349);
    		t=type();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_type.Add(t.Tree);
    		DebugLocation(144, 19);
    		PushFollow(Follow._id_list_in_declaration1353);
    		ilist=id_list();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_id_list.Add(ilist.Tree);
    		DebugLocation(144, 28);
    		SEMI18=(IToken)Match(input,SEMI,Follow._SEMI_in_declaration1355); if (state.failed) return retval; 
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
    		// 145:7: -> ^( DECLLIST ^( TYPE $t) $ilist)
    		{
    			DebugLocation(145, 10);
    			// Evil.g:145:10: ^( DECLLIST ^( TYPE $t) $ilist)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(145, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECLLIST, "DECLLIST"), root_1);

    			DebugLocation(145, 21);
    			// Evil.g:145:21: ^( TYPE $t)
    			{
    			object root_2 = (object)adaptor.Nil();
    			DebugLocation(145, 23);
    			root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE, "TYPE"), root_2);

    			DebugLocation(145, 28);
    			adaptor.AddChild(root_2, stream_t.NextTree());

    			adaptor.AddChild(root_1, root_2);
    			}
    			DebugLocation(145, 32);
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
     	DebugLocation(146, 3);
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
    // Evil.g:147:1: id_list : ID ( COMMA ID )* ;
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
    	DebugLocation(147, 3);
    	try
    	{
    		// Evil.g:148:4: ( ID ( COMMA ID )* )
    		DebugEnterAlt(1);
    		// Evil.g:148:7: ID ( COMMA ID )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(148, 7);
    		ID19=(IToken)Match(input,ID,Follow._ID_in_id_list1392); if (state.failed) return retval;
    		if ( state.backtracking==0 ) {
    		ID19_tree = (object)adaptor.Create(ID19);
    		adaptor.AddChild(root_0, ID19_tree);
    		}
    		DebugLocation(148, 10);
    		// Evil.g:148:10: ( COMMA ID )*
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
    				// Evil.g:148:11: COMMA ID
    				{
    				DebugLocation(148, 16);
    				COMMA20=(IToken)Match(input,COMMA,Follow._COMMA_in_id_list1395); if (state.failed) return retval;
    				DebugLocation(148, 18);
    				ID21=(IToken)Match(input,ID,Follow._ID_in_id_list1398); if (state.failed) return retval;
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
     	DebugLocation(149, 3);
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
    // Evil.g:150:1: functions : ( function )* -> ^( FUNCS ( function )* ) ;
    [GrammarRule("functions")]
    private EvilParser.functions_return functions()
    {

        EvilParser.functions_return retval = new EvilParser.functions_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.function_return function22 = default(EvilParser.function_return);

        RewriteRuleSubtreeStream stream_function=new RewriteRuleSubtreeStream(adaptor,"rule function");
    	try { DebugEnterRule(GrammarFileName, "functions");
    	DebugLocation(150, 3);
    	try
    	{
    		// Evil.g:151:4: ( ( function )* -> ^( FUNCS ( function )* ) )
    		DebugEnterAlt(1);
    		// Evil.g:151:7: ( function )*
    		{
    		DebugLocation(151, 7);
    		// Evil.g:151:7: ( function )*
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
    				// Evil.g:151:7: function
    				{
    				DebugLocation(151, 7);
    				PushFollow(Follow._function_in_functions1415);
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
    		// 151:17: -> ^( FUNCS ( function )* )
    		{
    			DebugLocation(151, 20);
    			// Evil.g:151:20: ^( FUNCS ( function )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(151, 22);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCS, "FUNCS"), root_1);

    			DebugLocation(151, 28);
    			// Evil.g:151:28: ( function )*
    			while ( stream_function.HasNext )
    			{
    				DebugLocation(151, 28);
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
     	DebugLocation(152, 3);
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
    // Evil.g:153:1: function : FUN id= ID p= parameters r= return_type LBRACE d= declarations s= statement_list RBRACE -> ^( FUN $id $p ^( RETTYPE $r) $d $s) ;
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
    	DebugLocation(153, 3);
    	try
    	{
    		// Evil.g:154:4: ( FUN id= ID p= parameters r= return_type LBRACE d= declarations s= statement_list RBRACE -> ^( FUN $id $p ^( RETTYPE $r) $d $s) )
    		DebugEnterAlt(1);
    		// Evil.g:154:7: FUN id= ID p= parameters r= return_type LBRACE d= declarations s= statement_list RBRACE
    		{
    		DebugLocation(154, 7);
    		FUN23=(IToken)Match(input,FUN,Follow._FUN_in_function1440); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_FUN.Add(FUN23);

    		DebugLocation(154, 13);
    		id=(IToken)Match(input,ID,Follow._ID_in_function1444); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_ID.Add(id);

    		DebugLocation(154, 18);
    		PushFollow(Follow._parameters_in_function1448);
    		p=parameters();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_parameters.Add(p.Tree);
    		DebugLocation(154, 31);
    		PushFollow(Follow._return_type_in_function1452);
    		r=return_type();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_return_type.Add(r.Tree);
    		DebugLocation(154, 44);
    		LBRACE24=(IToken)Match(input,LBRACE,Follow._LBRACE_in_function1454); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_LBRACE.Add(LBRACE24);

    		DebugLocation(154, 52);
    		PushFollow(Follow._declarations_in_function1458);
    		d=declarations();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_declarations.Add(d.Tree);
    		DebugLocation(154, 67);
    		PushFollow(Follow._statement_list_in_function1462);
    		s=statement_list();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_statement_list.Add(s.Tree);
    		DebugLocation(154, 83);
    		RBRACE25=(IToken)Match(input,RBRACE,Follow._RBRACE_in_function1464); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_RBRACE.Add(RBRACE25);



    		{
    		// AST REWRITE
    		// elements: s, FUN, p, r, id, d
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
    		// 155:7: -> ^( FUN $id $p ^( RETTYPE $r) $d $s)
    		{
    			DebugLocation(155, 10);
    			// Evil.g:155:10: ^( FUN $id $p ^( RETTYPE $r) $d $s)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(155, 12);
    			root_1 = (object)adaptor.BecomeRoot(stream_FUN.NextNode(), root_1);

    			DebugLocation(155, 16);
    			adaptor.AddChild(root_1, stream_id.NextNode());
    			DebugLocation(155, 20);
    			adaptor.AddChild(root_1, stream_p.NextTree());
    			DebugLocation(155, 23);
    			// Evil.g:155:23: ^( RETTYPE $r)
    			{
    			object root_2 = (object)adaptor.Nil();
    			DebugLocation(155, 25);
    			root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETTYPE, "RETTYPE"), root_2);

    			DebugLocation(155, 33);
    			adaptor.AddChild(root_2, stream_r.NextTree());

    			adaptor.AddChild(root_1, root_2);
    			}
    			DebugLocation(155, 37);
    			adaptor.AddChild(root_1, stream_d.NextTree());
    			DebugLocation(155, 40);
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
     	DebugLocation(156, 3);
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
    // Evil.g:157:1: parameters : LPAREN ( decl ( COMMA decl )* )? RPAREN -> ^( PARAMS ( decl )* ) ;
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
    	DebugLocation(157, 3);
    	try
    	{
    		// Evil.g:158:4: ( LPAREN ( decl ( COMMA decl )* )? RPAREN -> ^( PARAMS ( decl )* ) )
    		DebugEnterAlt(1);
    		// Evil.g:158:7: LPAREN ( decl ( COMMA decl )* )? RPAREN
    		{
    		DebugLocation(158, 7);
    		LPAREN26=(IToken)Match(input,LPAREN,Follow._LPAREN_in_parameters1510); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN26);

    		DebugLocation(158, 14);
    		// Evil.g:158:14: ( decl ( COMMA decl )* )?
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
    			// Evil.g:158:15: decl ( COMMA decl )*
    			{
    			DebugLocation(158, 15);
    			PushFollow(Follow._decl_in_parameters1513);
    			decl27=decl();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) stream_decl.Add(decl27.Tree);
    			DebugLocation(158, 20);
    			// Evil.g:158:20: ( COMMA decl )*
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
    					// Evil.g:158:21: COMMA decl
    					{
    					DebugLocation(158, 21);
    					COMMA28=(IToken)Match(input,COMMA,Follow._COMMA_in_parameters1516); if (state.failed) return retval; 
    					if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA28);

    					DebugLocation(158, 27);
    					PushFollow(Follow._decl_in_parameters1518);
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

    		DebugLocation(158, 36);
    		RPAREN30=(IToken)Match(input,RPAREN,Follow._RPAREN_in_parameters1524); if (state.failed) return retval; 
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
    		// 159:7: -> ^( PARAMS ( decl )* )
    		{
    			DebugLocation(159, 10);
    			// Evil.g:159:10: ^( PARAMS ( decl )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(159, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_1);

    			DebugLocation(159, 19);
    			// Evil.g:159:19: ( decl )*
    			while ( stream_decl.HasNext )
    			{
    				DebugLocation(159, 19);
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
     	DebugLocation(160, 3);
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
    // Evil.g:161:1: return_type : ( type | VOID );
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
    	DebugLocation(161, 3);
    	try
    	{
    		// Evil.g:162:4: ( type | VOID )
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
    			// Evil.g:162:7: type
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(162, 7);
    			PushFollow(Follow._type_in_return_type1554);
    			type31=type();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, type31.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:163:7: VOID
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(163, 7);
    			VOID32=(IToken)Match(input,VOID,Follow._VOID_in_return_type1562); if (state.failed) return retval;
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
     	DebugLocation(164, 3);
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
    // Evil.g:165:1: statement : ( block | ( lvalue ASSIGN )=> assignment | print | read | conditional | loop | delete | ret | ( ID LPAREN )=> invocation );
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
    	DebugLocation(165, 3);
    	try
    	{
    		// Evil.g:166:4: ( block | ( lvalue ASSIGN )=> assignment | print | read | conditional | loop | delete | ret | ( ID LPAREN )=> invocation )
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
    			// Evil.g:166:7: block
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(166, 7);
    			PushFollow(Follow._block_in_statement1577);
    			block33=block();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, block33.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:167:7: ( lvalue ASSIGN )=> assignment
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(167, 26);
    			PushFollow(Follow._assignment_in_statement1593);
    			assignment34=assignment();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, assignment34.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Evil.g:168:7: print
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(168, 7);
    			PushFollow(Follow._print_in_statement1601);
    			print35=print();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, print35.Tree);

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Evil.g:169:7: read
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(169, 7);
    			PushFollow(Follow._read_in_statement1609);
    			read36=read();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, read36.Tree);

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Evil.g:170:7: conditional
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(170, 7);
    			PushFollow(Follow._conditional_in_statement1617);
    			conditional37=conditional();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, conditional37.Tree);

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// Evil.g:171:7: loop
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(171, 7);
    			PushFollow(Follow._loop_in_statement1625);
    			loop38=loop();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, loop38.Tree);

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// Evil.g:172:7: delete
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(172, 7);
    			PushFollow(Follow._delete_in_statement1633);
    			delete39=delete();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, delete39.Tree);

    			}
    			break;
    		case 8:
    			DebugEnterAlt(8);
    			// Evil.g:173:7: ret
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(173, 7);
    			PushFollow(Follow._ret_in_statement1641);
    			ret40=ret();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, ret40.Tree);

    			}
    			break;
    		case 9:
    			DebugEnterAlt(9);
    			// Evil.g:174:7: ( ID LPAREN )=> invocation
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(174, 22);
    			PushFollow(Follow._invocation_in_statement1657);
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
     	DebugLocation(175, 3);
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
    // Evil.g:176:1: block : LBRACE s= statement_list RBRACE -> ^( BLOCK $s) ;
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
    	DebugLocation(176, 3);
    	try
    	{
    		// Evil.g:177:4: ( LBRACE s= statement_list RBRACE -> ^( BLOCK $s) )
    		DebugEnterAlt(1);
    		// Evil.g:177:7: LBRACE s= statement_list RBRACE
    		{
    		DebugLocation(177, 7);
    		LBRACE42=(IToken)Match(input,LBRACE,Follow._LBRACE_in_block1672); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_LBRACE.Add(LBRACE42);

    		DebugLocation(177, 15);
    		PushFollow(Follow._statement_list_in_block1676);
    		s=statement_list();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_statement_list.Add(s.Tree);
    		DebugLocation(177, 31);
    		RBRACE43=(IToken)Match(input,RBRACE,Follow._RBRACE_in_block1678); if (state.failed) return retval; 
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
    		// 178:7: -> ^( BLOCK $s)
    		{
    			DebugLocation(178, 10);
    			// Evil.g:178:10: ^( BLOCK $s)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(178, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

    			DebugLocation(178, 18);
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
     	DebugLocation(179, 3);
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
    // Evil.g:180:1: statement_list : ( statement )* -> ^( STMTS ( statement )* ) ;
    [GrammarRule("statement_list")]
    private EvilParser.statement_list_return statement_list()
    {

        EvilParser.statement_list_return retval = new EvilParser.statement_list_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        EvilParser.statement_return statement44 = default(EvilParser.statement_return);

        RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
    	try { DebugEnterRule(GrammarFileName, "statement_list");
    	DebugLocation(180, 3);
    	try
    	{
    		// Evil.g:181:4: ( ( statement )* -> ^( STMTS ( statement )* ) )
    		DebugEnterAlt(1);
    		// Evil.g:181:7: ( statement )*
    		{
    		DebugLocation(181, 7);
    		// Evil.g:181:7: ( statement )*
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
    				// Evil.g:181:8: statement
    				{
    				DebugLocation(181, 8);
    				PushFollow(Follow._statement_in_statement_list1709);
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
    		// 181:20: -> ^( STMTS ( statement )* )
    		{
    			DebugLocation(181, 23);
    			// Evil.g:181:23: ^( STMTS ( statement )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(181, 25);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STMTS, "STMTS"), root_1);

    			DebugLocation(181, 31);
    			// Evil.g:181:31: ( statement )*
    			while ( stream_statement.HasNext )
    			{
    				DebugLocation(181, 31);
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
     	DebugLocation(182, 3);
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
    // Evil.g:183:1: assignment : l= lvalue ASSIGN e= expression SEMI -> ^( ASSIGN $e $l) ;
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
    	DebugLocation(183, 3);
    	try
    	{
    		// Evil.g:184:4: (l= lvalue ASSIGN e= expression SEMI -> ^( ASSIGN $e $l) )
    		DebugEnterAlt(1);
    		// Evil.g:184:7: l= lvalue ASSIGN e= expression SEMI
    		{
    		DebugLocation(184, 8);
    		PushFollow(Follow._lvalue_in_assignment1737);
    		l=lvalue();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_lvalue.Add(l.Tree);
    		DebugLocation(184, 16);
    		ASSIGN45=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignment1739); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN45);

    		DebugLocation(184, 24);
    		PushFollow(Follow._expression_in_assignment1743);
    		e=expression();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_expression.Add(e.Tree);
    		DebugLocation(184, 36);
    		SEMI46=(IToken)Match(input,SEMI,Follow._SEMI_in_assignment1745); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_SEMI.Add(SEMI46);



    		{
    		// AST REWRITE
    		// elements: ASSIGN, e, l
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
    		// 185:7: -> ^( ASSIGN $e $l)
    		{
    			DebugLocation(185, 10);
    			// Evil.g:185:10: ^( ASSIGN $e $l)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(185, 12);
    			root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

    			DebugLocation(185, 19);
    			adaptor.AddChild(root_1, stream_e.NextTree());
    			DebugLocation(185, 22);
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
     	DebugLocation(186, 3);
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
    // Evil.g:187:1: print : PRINT expression ( ENDL )? SEMI ;
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
    	DebugLocation(187, 3);
    	try
    	{
    		// Evil.g:188:4: ( PRINT expression ( ENDL )? SEMI )
    		DebugEnterAlt(1);
    		// Evil.g:188:7: PRINT expression ( ENDL )? SEMI
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(188, 12);
    		PRINT47=(IToken)Match(input,PRINT,Follow._PRINT_in_print1778); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		PRINT47_tree = (object)adaptor.Create(PRINT47);
    		root_0 = (object)adaptor.BecomeRoot(PRINT47_tree, root_0);
    		}
    		DebugLocation(188, 14);
    		PushFollow(Follow._expression_in_print1781);
    		expression48=expression();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, expression48.Tree);
    		DebugLocation(188, 25);
    		// Evil.g:188:25: ( ENDL )?
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
    			// Evil.g:188:26: ENDL
    			{
    			DebugLocation(188, 26);
    			ENDL49=(IToken)Match(input,ENDL,Follow._ENDL_in_print1784); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			ENDL49_tree = (object)adaptor.Create(ENDL49);
    			adaptor.AddChild(root_0, ENDL49_tree);
    			}

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(13); }

    		DebugLocation(188, 37);
    		SEMI50=(IToken)Match(input,SEMI,Follow._SEMI_in_print1788); if (state.failed) return retval;

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
     	DebugLocation(189, 3);
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
    // Evil.g:190:1: read : READ lvalue SEMI ;
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
    	DebugLocation(190, 3);
    	try
    	{
    		// Evil.g:191:4: ( READ lvalue SEMI )
    		DebugEnterAlt(1);
    		// Evil.g:191:7: READ lvalue SEMI
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(191, 11);
    		READ51=(IToken)Match(input,READ,Follow._READ_in_read1804); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		READ51_tree = (object)adaptor.Create(READ51);
    		root_0 = (object)adaptor.BecomeRoot(READ51_tree, root_0);
    		}
    		DebugLocation(191, 13);
    		PushFollow(Follow._lvalue_in_read1807);
    		lvalue52=lvalue();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, lvalue52.Tree);
    		DebugLocation(191, 24);
    		SEMI53=(IToken)Match(input,SEMI,Follow._SEMI_in_read1809); if (state.failed) return retval;

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
     	DebugLocation(192, 3);
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
    // Evil.g:193:1: conditional : IF LPAREN expression RPAREN block ( ELSE block )? ;
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
    	DebugLocation(193, 3);
    	try
    	{
    		// Evil.g:194:4: ( IF LPAREN expression RPAREN block ( ELSE block )? )
    		DebugEnterAlt(1);
    		// Evil.g:194:7: IF LPAREN expression RPAREN block ( ELSE block )?
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(194, 9);
    		IF54=(IToken)Match(input,IF,Follow._IF_in_conditional1825); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		IF54_tree = (object)adaptor.Create(IF54);
    		root_0 = (object)adaptor.BecomeRoot(IF54_tree, root_0);
    		}
    		DebugLocation(194, 17);
    		LPAREN55=(IToken)Match(input,LPAREN,Follow._LPAREN_in_conditional1828); if (state.failed) return retval;
    		DebugLocation(194, 19);
    		PushFollow(Follow._expression_in_conditional1831);
    		expression56=expression();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, expression56.Tree);
    		DebugLocation(194, 36);
    		RPAREN57=(IToken)Match(input,RPAREN,Follow._RPAREN_in_conditional1833); if (state.failed) return retval;
    		DebugLocation(194, 38);
    		PushFollow(Follow._block_in_conditional1836);
    		block58=block();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, block58.Tree);
    		DebugLocation(194, 44);
    		// Evil.g:194:44: ( ELSE block )?
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
    			// Evil.g:194:45: ELSE block
    			{
    			DebugLocation(194, 49);
    			ELSE59=(IToken)Match(input,ELSE,Follow._ELSE_in_conditional1839); if (state.failed) return retval;
    			DebugLocation(194, 51);
    			PushFollow(Follow._block_in_conditional1842);
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
     	DebugLocation(195, 3);
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
    // Evil.g:196:1: loop : WHILE LPAREN e= expression RPAREN b= block -> ^( WHILE $e $b $e) ;
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
    	DebugLocation(196, 3);
    	try
    	{
    		// Evil.g:197:4: ( WHILE LPAREN e= expression RPAREN b= block -> ^( WHILE $e $b $e) )
    		DebugEnterAlt(1);
    		// Evil.g:197:7: WHILE LPAREN e= expression RPAREN b= block
    		{
    		DebugLocation(197, 7);
    		WHILE61=(IToken)Match(input,WHILE,Follow._WHILE_in_loop1859); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE61);

    		DebugLocation(197, 13);
    		LPAREN62=(IToken)Match(input,LPAREN,Follow._LPAREN_in_loop1861); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN62);

    		DebugLocation(197, 21);
    		PushFollow(Follow._expression_in_loop1865);
    		e=expression();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_expression.Add(e.Tree);
    		DebugLocation(197, 33);
    		RPAREN63=(IToken)Match(input,RPAREN,Follow._RPAREN_in_loop1867); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN63);

    		DebugLocation(197, 41);
    		PushFollow(Follow._block_in_loop1871);
    		b=block();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_block.Add(b.Tree);


    		{
    		// AST REWRITE
    		// elements: e, b, e, WHILE
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
    		// 198:7: -> ^( WHILE $e $b $e)
    		{
    			DebugLocation(198, 10);
    			// Evil.g:198:10: ^( WHILE $e $b $e)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(198, 12);
    			root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

    			DebugLocation(198, 18);
    			adaptor.AddChild(root_1, stream_e.NextTree());
    			DebugLocation(198, 21);
    			adaptor.AddChild(root_1, stream_b.NextTree());
    			DebugLocation(198, 24);
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
     	DebugLocation(199, 3);
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
    // Evil.g:200:1: delete : DELETE expression SEMI ;
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
    	DebugLocation(200, 3);
    	try
    	{
    		// Evil.g:201:4: ( DELETE expression SEMI )
    		DebugEnterAlt(1);
    		// Evil.g:201:7: DELETE expression SEMI
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(201, 13);
    		DELETE64=(IToken)Match(input,DELETE,Follow._DELETE_in_delete1907); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		DELETE64_tree = (object)adaptor.Create(DELETE64);
    		root_0 = (object)adaptor.BecomeRoot(DELETE64_tree, root_0);
    		}
    		DebugLocation(201, 15);
    		PushFollow(Follow._expression_in_delete1910);
    		expression65=expression();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, expression65.Tree);
    		DebugLocation(201, 30);
    		SEMI66=(IToken)Match(input,SEMI,Follow._SEMI_in_delete1912); if (state.failed) return retval;

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
     	DebugLocation(202, 3);
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
    // Evil.g:203:1: ret : RETURN ( expression )? SEMI ;
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
    	DebugLocation(203, 3);
    	try
    	{
    		// Evil.g:204:4: ( RETURN ( expression )? SEMI )
    		DebugEnterAlt(1);
    		// Evil.g:204:7: RETURN ( expression )? SEMI
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(204, 13);
    		RETURN67=(IToken)Match(input,RETURN,Follow._RETURN_in_ret1928); if (state.failed) return retval;
    		if ( (state.backtracking==0) ) {
    		RETURN67_tree = (object)adaptor.Create(RETURN67);
    		root_0 = (object)adaptor.BecomeRoot(RETURN67_tree, root_0);
    		}
    		DebugLocation(204, 15);
    		// Evil.g:204:15: ( expression )?
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
    			// Evil.g:204:16: expression
    			{
    			DebugLocation(204, 16);
    			PushFollow(Follow._expression_in_ret1932);
    			expression68=expression();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, expression68.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(15); }

    		DebugLocation(204, 33);
    		SEMI69=(IToken)Match(input,SEMI,Follow._SEMI_in_ret1936); if (state.failed) return retval;

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
     	DebugLocation(205, 3);
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
    // Evil.g:206:1: invocation : id= ID a= arguments SEMI -> ^( INVOKE $id $a) ;
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
    	DebugLocation(206, 3);
    	try
    	{
    		// Evil.g:207:4: (id= ID a= arguments SEMI -> ^( INVOKE $id $a) )
    		DebugEnterAlt(1);
    		// Evil.g:207:7: id= ID a= arguments SEMI
    		{
    		DebugLocation(207, 9);
    		id=(IToken)Match(input,ID,Follow._ID_in_invocation1954); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_ID.Add(id);

    		DebugLocation(207, 14);
    		PushFollow(Follow._arguments_in_invocation1958);
    		a=arguments();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) stream_arguments.Add(a.Tree);
    		DebugLocation(207, 25);
    		SEMI70=(IToken)Match(input,SEMI,Follow._SEMI_in_invocation1960); if (state.failed) return retval; 
    		if ( (state.backtracking==0) ) stream_SEMI.Add(SEMI70);



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
    		// 208:7: -> ^( INVOKE $id $a)
    		{
    			DebugLocation(208, 10);
    			// Evil.g:208:10: ^( INVOKE $id $a)
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(208, 12);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INVOKE, "INVOKE"), root_1);

    			DebugLocation(208, 19);
    			adaptor.AddChild(root_1, stream_id.NextNode());
    			DebugLocation(208, 23);
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
     	DebugLocation(209, 3);
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
    // Evil.g:210:1: lvalue : ID ( DOT ID )* ;
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
    	DebugLocation(210, 3);
    	try
    	{
    		// Evil.g:211:4: ( ID ( DOT ID )* )
    		DebugEnterAlt(1);
    		// Evil.g:211:7: ID ( DOT ID )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(211, 7);
    		ID71=(IToken)Match(input,ID,Follow._ID_in_lvalue1993); if (state.failed) return retval;
    		if ( state.backtracking==0 ) {
    		ID71_tree = (object)adaptor.Create(ID71);
    		adaptor.AddChild(root_0, ID71_tree);
    		}
    		DebugLocation(211, 10);
    		// Evil.g:211:10: ( DOT ID )*
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
    				// Evil.g:211:11: DOT ID
    				{
    				DebugLocation(211, 14);
    				DOT72=(IToken)Match(input,DOT,Follow._DOT_in_lvalue1996); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				DOT72_tree = (object)adaptor.Create(DOT72);
    				root_0 = (object)adaptor.BecomeRoot(DOT72_tree, root_0);
    				}
    				DebugLocation(211, 16);
    				ID73=(IToken)Match(input,ID,Follow._ID_in_lvalue1999); if (state.failed) return retval;
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
     	DebugLocation(212, 3);
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
    // Evil.g:213:1: expression : boolterm ( ( AND | OR ) boolterm )* ;
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
    	DebugLocation(213, 3);
    	try
    	{
    		// Evil.g:214:4: ( boolterm ( ( AND | OR ) boolterm )* )
    		DebugEnterAlt(1);
    		// Evil.g:214:7: boolterm ( ( AND | OR ) boolterm )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(214, 7);
    		PushFollow(Follow._boolterm_in_expression2016);
    		boolterm74=boolterm();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, boolterm74.Tree);
    		DebugLocation(214, 16);
    		// Evil.g:214:16: ( ( AND | OR ) boolterm )*
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
    				// Evil.g:214:17: ( AND | OR ) boolterm
    				{
    				DebugLocation(214, 17);
    				// Evil.g:214:17: ( AND | OR )
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
    					// Evil.g:214:18: AND
    					{
    					DebugLocation(214, 21);
    					AND75=(IToken)Match(input,AND,Follow._AND_in_expression2020); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					AND75_tree = (object)adaptor.Create(AND75);
    					root_0 = (object)adaptor.BecomeRoot(AND75_tree, root_0);
    					}

    					}
    					break;
    				case 2:
    					DebugEnterAlt(2);
    					// Evil.g:214:25: OR
    					{
    					DebugLocation(214, 27);
    					OR76=(IToken)Match(input,OR,Follow._OR_in_expression2025); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					OR76_tree = (object)adaptor.Create(OR76);
    					root_0 = (object)adaptor.BecomeRoot(OR76_tree, root_0);
    					}

    					}
    					break;

    				}
    				} finally { DebugExitSubRule(17); }

    				DebugLocation(214, 30);
    				PushFollow(Follow._boolterm_in_expression2029);
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
     	DebugLocation(215, 3);
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
    // Evil.g:216:1: boolterm : simple ( ( EQ | LT | GT | NE | LE | GE ) simple )? ;
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
    	DebugLocation(216, 3);
    	try
    	{
    		// Evil.g:217:4: ( simple ( ( EQ | LT | GT | NE | LE | GE ) simple )? )
    		DebugEnterAlt(1);
    		// Evil.g:217:7: simple ( ( EQ | LT | GT | NE | LE | GE ) simple )?
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(217, 7);
    		PushFollow(Follow._simple_in_boolterm2046);
    		simple78=simple();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, simple78.Tree);
    		DebugLocation(217, 14);
    		// Evil.g:217:14: ( ( EQ | LT | GT | NE | LE | GE ) simple )?
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
    			// Evil.g:217:15: ( EQ | LT | GT | NE | LE | GE ) simple
    			{
    			DebugLocation(217, 15);
    			// Evil.g:217:15: ( EQ | LT | GT | NE | LE | GE )
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
    				// Evil.g:217:16: EQ
    				{
    				DebugLocation(217, 18);
    				EQ79=(IToken)Match(input,EQ,Follow._EQ_in_boolterm2050); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				EQ79_tree = (object)adaptor.Create(EQ79);
    				root_0 = (object)adaptor.BecomeRoot(EQ79_tree, root_0);
    				}

    				}
    				break;
    			case 2:
    				DebugEnterAlt(2);
    				// Evil.g:217:22: LT
    				{
    				DebugLocation(217, 24);
    				LT80=(IToken)Match(input,LT,Follow._LT_in_boolterm2055); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				LT80_tree = (object)adaptor.Create(LT80);
    				root_0 = (object)adaptor.BecomeRoot(LT80_tree, root_0);
    				}

    				}
    				break;
    			case 3:
    				DebugEnterAlt(3);
    				// Evil.g:217:28: GT
    				{
    				DebugLocation(217, 30);
    				GT81=(IToken)Match(input,GT,Follow._GT_in_boolterm2060); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				GT81_tree = (object)adaptor.Create(GT81);
    				root_0 = (object)adaptor.BecomeRoot(GT81_tree, root_0);
    				}

    				}
    				break;
    			case 4:
    				DebugEnterAlt(4);
    				// Evil.g:217:34: NE
    				{
    				DebugLocation(217, 36);
    				NE82=(IToken)Match(input,NE,Follow._NE_in_boolterm2065); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				NE82_tree = (object)adaptor.Create(NE82);
    				root_0 = (object)adaptor.BecomeRoot(NE82_tree, root_0);
    				}

    				}
    				break;
    			case 5:
    				DebugEnterAlt(5);
    				// Evil.g:217:40: LE
    				{
    				DebugLocation(217, 42);
    				LE83=(IToken)Match(input,LE,Follow._LE_in_boolterm2070); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				LE83_tree = (object)adaptor.Create(LE83);
    				root_0 = (object)adaptor.BecomeRoot(LE83_tree, root_0);
    				}

    				}
    				break;
    			case 6:
    				DebugEnterAlt(6);
    				// Evil.g:217:46: GE
    				{
    				DebugLocation(217, 48);
    				GE84=(IToken)Match(input,GE,Follow._GE_in_boolterm2075); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				GE84_tree = (object)adaptor.Create(GE84);
    				root_0 = (object)adaptor.BecomeRoot(GE84_tree, root_0);
    				}

    				}
    				break;

    			}
    			} finally { DebugExitSubRule(19); }

    			DebugLocation(217, 51);
    			PushFollow(Follow._simple_in_boolterm2079);
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
     	DebugLocation(218, 3);
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
    // Evil.g:219:1: simple : term ( ( PLUS | MINUS ) term )* ;
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
    	DebugLocation(219, 3);
    	try
    	{
    		// Evil.g:220:4: ( term ( ( PLUS | MINUS ) term )* )
    		DebugEnterAlt(1);
    		// Evil.g:220:7: term ( ( PLUS | MINUS ) term )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(220, 7);
    		PushFollow(Follow._term_in_simple2096);
    		term86=term();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, term86.Tree);
    		DebugLocation(220, 12);
    		// Evil.g:220:12: ( ( PLUS | MINUS ) term )*
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
    				// Evil.g:220:13: ( PLUS | MINUS ) term
    				{
    				DebugLocation(220, 13);
    				// Evil.g:220:13: ( PLUS | MINUS )
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
    					// Evil.g:220:14: PLUS
    					{
    					DebugLocation(220, 18);
    					PLUS87=(IToken)Match(input,PLUS,Follow._PLUS_in_simple2100); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					PLUS87_tree = (object)adaptor.Create(PLUS87);
    					root_0 = (object)adaptor.BecomeRoot(PLUS87_tree, root_0);
    					}

    					}
    					break;
    				case 2:
    					DebugEnterAlt(2);
    					// Evil.g:220:22: MINUS
    					{
    					DebugLocation(220, 27);
    					MINUS88=(IToken)Match(input,MINUS,Follow._MINUS_in_simple2105); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					MINUS88_tree = (object)adaptor.Create(MINUS88);
    					root_0 = (object)adaptor.BecomeRoot(MINUS88_tree, root_0);
    					}

    					}
    					break;

    				}
    				} finally { DebugExitSubRule(21); }

    				DebugLocation(220, 30);
    				PushFollow(Follow._term_in_simple2109);
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
     	DebugLocation(221, 3);
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
    // Evil.g:222:1: term : unary ( ( TIMES | DIVIDE ) unary )* ;
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
    	DebugLocation(222, 3);
    	try
    	{
    		// Evil.g:223:4: ( unary ( ( TIMES | DIVIDE ) unary )* )
    		DebugEnterAlt(1);
    		// Evil.g:223:7: unary ( ( TIMES | DIVIDE ) unary )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(223, 7);
    		PushFollow(Follow._unary_in_term2126);
    		unary90=unary();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, unary90.Tree);
    		DebugLocation(223, 13);
    		// Evil.g:223:13: ( ( TIMES | DIVIDE ) unary )*
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
    				// Evil.g:223:14: ( TIMES | DIVIDE ) unary
    				{
    				DebugLocation(223, 14);
    				// Evil.g:223:14: ( TIMES | DIVIDE )
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
    					// Evil.g:223:15: TIMES
    					{
    					DebugLocation(223, 20);
    					TIMES91=(IToken)Match(input,TIMES,Follow._TIMES_in_term2130); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					TIMES91_tree = (object)adaptor.Create(TIMES91);
    					root_0 = (object)adaptor.BecomeRoot(TIMES91_tree, root_0);
    					}

    					}
    					break;
    				case 2:
    					DebugEnterAlt(2);
    					// Evil.g:223:24: DIVIDE
    					{
    					DebugLocation(223, 30);
    					DIVIDE92=(IToken)Match(input,DIVIDE,Follow._DIVIDE_in_term2135); if (state.failed) return retval;
    					if ( (state.backtracking==0) ) {
    					DIVIDE92_tree = (object)adaptor.Create(DIVIDE92);
    					root_0 = (object)adaptor.BecomeRoot(DIVIDE92_tree, root_0);
    					}

    					}
    					break;

    				}
    				} finally { DebugExitSubRule(23); }

    				DebugLocation(223, 33);
    				PushFollow(Follow._unary_in_term2139);
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
     	DebugLocation(224, 3);
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
    // Evil.g:225:1: unary : ( NOT odd_not | MINUS odd_neg | selector );
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
    	DebugLocation(225, 3);
    	try
    	{
    		// Evil.g:226:4: ( NOT odd_not | MINUS odd_neg | selector )
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
    			// Evil.g:226:7: NOT odd_not
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(226, 10);
    			NOT94=(IToken)Match(input,NOT,Follow._NOT_in_unary2156); if (state.failed) return retval;
    			DebugLocation(226, 12);
    			PushFollow(Follow._odd_not_in_unary2159);
    			odd_not95=odd_not();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, odd_not95.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:227:7: MINUS odd_neg
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(227, 12);
    			MINUS96=(IToken)Match(input,MINUS,Follow._MINUS_in_unary2167); if (state.failed) return retval;
    			DebugLocation(227, 14);
    			PushFollow(Follow._odd_neg_in_unary2170);
    			odd_neg97=odd_neg();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, odd_neg97.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Evil.g:228:7: selector
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(228, 7);
    			PushFollow(Follow._selector_in_unary2178);
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
     	DebugLocation(229, 3);
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
    // Evil.g:230:1: odd_not : ( NOT even_not | s= selector -> ^( NOT $s) );
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
    	DebugLocation(230, 3);
    	try
    	{
    		// Evil.g:231:4: ( NOT even_not | s= selector -> ^( NOT $s) )
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
    			// Evil.g:231:7: NOT even_not
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(231, 10);
    			NOT99=(IToken)Match(input,NOT,Follow._NOT_in_odd_not2193); if (state.failed) return retval;
    			DebugLocation(231, 12);
    			PushFollow(Follow._even_not_in_odd_not2196);
    			even_not100=even_not();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, even_not100.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:232:7: s= selector
    			{
    			DebugLocation(232, 8);
    			PushFollow(Follow._selector_in_odd_not2206);
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
    			// 233:7: -> ^( NOT $s)
    			{
    				DebugLocation(233, 10);
    				// Evil.g:233:10: ^( NOT $s)
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(233, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NOT, "NOT"), root_1);

    				DebugLocation(233, 16);
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
     	DebugLocation(234, 3);
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
    // Evil.g:235:1: even_not : ( NOT odd_not | selector );
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
    	DebugLocation(235, 3);
    	try
    	{
    		// Evil.g:236:4: ( NOT odd_not | selector )
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
    			// Evil.g:236:7: NOT odd_not
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(236, 10);
    			NOT101=(IToken)Match(input,NOT,Follow._NOT_in_even_not2236); if (state.failed) return retval;
    			DebugLocation(236, 12);
    			PushFollow(Follow._odd_not_in_even_not2239);
    			odd_not102=odd_not();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, odd_not102.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:237:7: selector
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(237, 7);
    			PushFollow(Follow._selector_in_even_not2247);
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
     	DebugLocation(238, 3);
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
    // Evil.g:239:1: odd_neg : ( MINUS even_neg | s= selector -> ^( NEG $s) );
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
    	DebugLocation(239, 3);
    	try
    	{
    		// Evil.g:240:4: ( MINUS even_neg | s= selector -> ^( NEG $s) )
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
    			// Evil.g:240:7: MINUS even_neg
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(240, 12);
    			MINUS104=(IToken)Match(input,MINUS,Follow._MINUS_in_odd_neg2262); if (state.failed) return retval;
    			DebugLocation(240, 14);
    			PushFollow(Follow._even_neg_in_odd_neg2265);
    			even_neg105=even_neg();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, even_neg105.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:241:7: s= selector
    			{
    			DebugLocation(241, 8);
    			PushFollow(Follow._selector_in_odd_neg2275);
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
    			// 242:7: -> ^( NEG $s)
    			{
    				DebugLocation(242, 10);
    				// Evil.g:242:10: ^( NEG $s)
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(242, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEG, "NEG"), root_1);

    				DebugLocation(242, 16);
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
     	DebugLocation(243, 3);
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
    // Evil.g:244:1: even_neg : ( MINUS odd_neg | selector );
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
    	DebugLocation(244, 3);
    	try
    	{
    		// Evil.g:245:4: ( MINUS odd_neg | selector )
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
    			// Evil.g:245:7: MINUS odd_neg
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(245, 12);
    			MINUS106=(IToken)Match(input,MINUS,Follow._MINUS_in_even_neg2305); if (state.failed) return retval;
    			DebugLocation(245, 14);
    			PushFollow(Follow._odd_neg_in_even_neg2308);
    			odd_neg107=odd_neg();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, odd_neg107.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:246:7: selector
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(246, 7);
    			PushFollow(Follow._selector_in_even_neg2316);
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
     	DebugLocation(247, 3);
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
    // Evil.g:248:1: selector : factor ( DOT ID )* ;
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
    	DebugLocation(248, 3);
    	try
    	{
    		// Evil.g:249:4: ( factor ( DOT ID )* )
    		DebugEnterAlt(1);
    		// Evil.g:249:7: factor ( DOT ID )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(249, 7);
    		PushFollow(Follow._factor_in_selector2331);
    		factor109=factor();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, factor109.Tree);
    		DebugLocation(249, 14);
    		// Evil.g:249:14: ( DOT ID )*
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
    				// Evil.g:249:15: DOT ID
    				{
    				DebugLocation(249, 18);
    				DOT110=(IToken)Match(input,DOT,Follow._DOT_in_selector2334); if (state.failed) return retval;
    				if ( (state.backtracking==0) ) {
    				DOT110_tree = (object)adaptor.Create(DOT110);
    				root_0 = (object)adaptor.BecomeRoot(DOT110_tree, root_0);
    				}
    				DebugLocation(249, 20);
    				ID111=(IToken)Match(input,ID,Follow._ID_in_selector2337); if (state.failed) return retval;
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
     	DebugLocation(250, 3);
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
    // Evil.g:251:1: factor : ( LPAREN expression RPAREN | id= ID a= arguments -> ^( INVOKE $id $a) | ID | INTEGER | TRUE | FALSE | NEW ID | NULL );
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
    	DebugLocation(251, 3);
    	try
    	{
    		// Evil.g:252:4: ( LPAREN expression RPAREN | id= ID a= arguments -> ^( INVOKE $id $a) | ID | INTEGER | TRUE | FALSE | NEW ID | NULL )
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
    			// Evil.g:252:7: LPAREN expression RPAREN
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(252, 13);
    			LPAREN112=(IToken)Match(input,LPAREN,Follow._LPAREN_in_factor2354); if (state.failed) return retval;
    			DebugLocation(252, 15);
    			PushFollow(Follow._expression_in_factor2357);
    			expression113=expression();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) adaptor.AddChild(root_0, expression113.Tree);
    			DebugLocation(252, 32);
    			RPAREN114=(IToken)Match(input,RPAREN,Follow._RPAREN_in_factor2359); if (state.failed) return retval;

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:253:7: id= ID a= arguments
    			{
    			DebugLocation(253, 9);
    			id=(IToken)Match(input,ID,Follow._ID_in_factor2370); if (state.failed) return retval; 
    			if ( (state.backtracking==0) ) stream_ID.Add(id);

    			DebugLocation(253, 14);
    			PushFollow(Follow._arguments_in_factor2374);
    			a=arguments();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) stream_arguments.Add(a.Tree);


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
    			// 254:7: -> ^( INVOKE $id $a)
    			{
    				DebugLocation(254, 10);
    				// Evil.g:254:10: ^( INVOKE $id $a)
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(254, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INVOKE, "INVOKE"), root_1);

    				DebugLocation(254, 19);
    				adaptor.AddChild(root_1, stream_id.NextNode());
    				DebugLocation(254, 23);
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
    			// Evil.g:255:7: ID
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(255, 7);
    			ID115=(IToken)Match(input,ID,Follow._ID_in_factor2400); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			ID115_tree = (object)adaptor.Create(ID115);
    			adaptor.AddChild(root_0, ID115_tree);
    			}

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Evil.g:256:7: INTEGER
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(256, 7);
    			INTEGER116=(IToken)Match(input,INTEGER,Follow._INTEGER_in_factor2408); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			INTEGER116_tree = (object)adaptor.Create(INTEGER116);
    			adaptor.AddChild(root_0, INTEGER116_tree);
    			}

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Evil.g:257:7: TRUE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(257, 7);
    			TRUE117=(IToken)Match(input,TRUE,Follow._TRUE_in_factor2416); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			TRUE117_tree = (object)adaptor.Create(TRUE117);
    			adaptor.AddChild(root_0, TRUE117_tree);
    			}

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// Evil.g:258:7: FALSE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(258, 7);
    			FALSE118=(IToken)Match(input,FALSE,Follow._FALSE_in_factor2424); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			FALSE118_tree = (object)adaptor.Create(FALSE118);
    			adaptor.AddChild(root_0, FALSE118_tree);
    			}

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// Evil.g:259:7: NEW ID
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(259, 10);
    			NEW119=(IToken)Match(input,NEW,Follow._NEW_in_factor2432); if (state.failed) return retval;
    			if ( (state.backtracking==0) ) {
    			NEW119_tree = (object)adaptor.Create(NEW119);
    			root_0 = (object)adaptor.BecomeRoot(NEW119_tree, root_0);
    			}
    			DebugLocation(259, 12);
    			ID120=(IToken)Match(input,ID,Follow._ID_in_factor2435); if (state.failed) return retval;
    			if ( state.backtracking==0 ) {
    			ID120_tree = (object)adaptor.Create(ID120);
    			adaptor.AddChild(root_0, ID120_tree);
    			}

    			}
    			break;
    		case 8:
    			DebugEnterAlt(8);
    			// Evil.g:260:7: NULL
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(260, 7);
    			NULL121=(IToken)Match(input,NULL,Follow._NULL_in_factor2443); if (state.failed) return retval;
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
     	DebugLocation(261, 3);
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
    // Evil.g:262:1: arguments : LPAREN arg_list RPAREN ;
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
    	DebugLocation(262, 3);
    	try
    	{
    		// Evil.g:263:4: ( LPAREN arg_list RPAREN )
    		DebugEnterAlt(1);
    		// Evil.g:263:7: LPAREN arg_list RPAREN
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(263, 13);
    		LPAREN122=(IToken)Match(input,LPAREN,Follow._LPAREN_in_arguments2458); if (state.failed) return retval;
    		DebugLocation(263, 15);
    		PushFollow(Follow._arg_list_in_arguments2461);
    		arg_list123=arg_list();
    		PopFollow();
    		if (state.failed) return retval;
    		if ( (state.backtracking==0) ) adaptor.AddChild(root_0, arg_list123.Tree);
    		DebugLocation(263, 30);
    		RPAREN124=(IToken)Match(input,RPAREN,Follow._RPAREN_in_arguments2463); if (state.failed) return retval;

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
     	DebugLocation(264, 3);
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
    // Evil.g:265:1: arg_list : ( expression ( COMMA expression )* -> ^( ARGS ( expression )+ ) | -> ARGS );
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
    	DebugLocation(265, 3);
    	try
    	{
    		// Evil.g:266:4: ( expression ( COMMA expression )* -> ^( ARGS ( expression )+ ) | -> ARGS )
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
    			// Evil.g:266:7: expression ( COMMA expression )*
    			{
    			DebugLocation(266, 7);
    			PushFollow(Follow._expression_in_arg_list2479);
    			expression125=expression();
    			PopFollow();
    			if (state.failed) return retval;
    			if ( (state.backtracking==0) ) stream_expression.Add(expression125.Tree);
    			DebugLocation(266, 18);
    			// Evil.g:266:18: ( COMMA expression )*
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
    					// Evil.g:266:19: COMMA expression
    					{
    					DebugLocation(266, 19);
    					COMMA126=(IToken)Match(input,COMMA,Follow._COMMA_in_arg_list2482); if (state.failed) return retval; 
    					if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA126);

    					DebugLocation(266, 25);
    					PushFollow(Follow._expression_in_arg_list2484);
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
    			// 267:7: -> ^( ARGS ( expression )+ )
    			{
    				DebugLocation(267, 10);
    				// Evil.g:267:10: ^( ARGS ( expression )+ )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(267, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARGS, "ARGS"), root_1);

    				DebugLocation(267, 17);
    				if ( !(stream_expression.HasNext) )
    				{
    					throw new RewriteEarlyExitException();
    				}
    				while ( stream_expression.HasNext )
    				{
    					DebugLocation(267, 17);
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
    			// Evil.g:269:7: 
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
    			// 269:7: -> ARGS
    			{
    				DebugLocation(269, 10);
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
     	DebugLocation(270, 3);
    	} finally { DebugExitRule(GrammarFileName, "arg_list"); }
    	return retval;

    }
    // $ANTLR end "arg_list"

    protected virtual void Enter_synpred1_Evil_fragment() {}
    protected virtual void Leave_synpred1_Evil_fragment() {}

    // $ANTLR start synpred1_Evil
    public void synpred1_Evil_fragment()
    {
    	// Evil.g:118:7: ( STRUCT ID LBRACE )
    	DebugEnterAlt(1);
    	// Evil.g:118:8: STRUCT ID LBRACE
    	{
    	DebugLocation(118, 8);
    	Match(input,STRUCT,Follow._STRUCT_in_synpred1_Evil1119); if (state.failed) return;
    	DebugLocation(118, 15);
    	Match(input,ID,Follow._ID_in_synpred1_Evil1121); if (state.failed) return;
    	DebugLocation(118, 18);
    	Match(input,LBRACE,Follow._LBRACE_in_synpred1_Evil1123); if (state.failed) return;

    	}
    }
    // $ANTLR end synpred1_Evil

    protected virtual void Enter_synpred2_Evil_fragment() {}
    protected virtual void Leave_synpred2_Evil_fragment() {}

    // $ANTLR start synpred2_Evil
    public void synpred2_Evil_fragment()
    {
    	// Evil.g:122:7: ( STRUCT ID LBRACE )
    	DebugEnterAlt(1);
    	// Evil.g:122:8: STRUCT ID LBRACE
    	{
    	DebugLocation(122, 8);
    	Match(input,STRUCT,Follow._STRUCT_in_synpred2_Evil1162); if (state.failed) return;
    	DebugLocation(122, 15);
    	Match(input,ID,Follow._ID_in_synpred2_Evil1164); if (state.failed) return;
    	DebugLocation(122, 18);
    	Match(input,LBRACE,Follow._LBRACE_in_synpred2_Evil1166); if (state.failed) return;

    	}
    }
    // $ANTLR end synpred2_Evil

    protected virtual void Enter_synpred3_Evil_fragment() {}
    protected virtual void Leave_synpred3_Evil_fragment() {}

    // $ANTLR start synpred3_Evil
    public void synpred3_Evil_fragment()
    {
    	// Evil.g:167:7: ( lvalue ASSIGN )
    	DebugEnterAlt(1);
    	// Evil.g:167:8: lvalue ASSIGN
    	{
    	DebugLocation(167, 8);
    	PushFollow(Follow._lvalue_in_synpred3_Evil1586);
    	lvalue();
    	PopFollow();
    	if (state.failed) return;
    	DebugLocation(167, 15);
    	Match(input,ASSIGN,Follow._ASSIGN_in_synpred3_Evil1588); if (state.failed) return;

    	}
    }
    // $ANTLR end synpred3_Evil

    protected virtual void Enter_synpred4_Evil_fragment() {}
    protected virtual void Leave_synpred4_Evil_fragment() {}

    // $ANTLR start synpred4_Evil
    public void synpred4_Evil_fragment()
    {
    	// Evil.g:174:7: ( ID LPAREN )
    	DebugEnterAlt(1);
    	// Evil.g:174:8: ID LPAREN
    	{
    	DebugLocation(174, 8);
    	Match(input,ID,Follow._ID_in_synpred4_Evil1650); if (state.failed) return;
    	DebugLocation(174, 11);
    	Match(input,LPAREN,Follow._LPAREN_in_synpred4_Evil1652); if (state.failed) return;

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

		public override string Description { get { return "165:1: statement : ( block | ( lvalue ASSIGN )=> assignment | print | read | conditional | loop | delete | ret | ( ID LPAREN )=> invocation );"; } }

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

		public override string Description { get { return "251:1: factor : ( LPAREN expression RPAREN | id= ID a= arguments -> ^( INVOKE $id $a) | ID | INTEGER | TRUE | FALSE | NEW ID | NULL );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _types_in_program1072 = new BitSet(new ulong[]{0x00000000000000F0UL});
		public static readonly BitSet _declarations_in_program1076 = new BitSet(new ulong[]{0x0000000000000080UL});
		public static readonly BitSet _functions_in_program1080 = new BitSet(new ulong[]{0x0000000000000000UL});
		public static readonly BitSet _EOF_in_program1082 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _types_sub_in_types1128 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _type_declaration_in_types_sub1171 = new BitSet(new ulong[]{0x0000000000000010UL});
		public static readonly BitSet _types_sub_in_types_sub1173 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRUCT_in_type_declaration1193 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_type_declaration1196 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _LBRACE_in_type_declaration1198 = new BitSet(new ulong[]{0x0000000000000070UL});
		public static readonly BitSet _nested_decl_in_type_declaration1201 = new BitSet(new ulong[]{0x0000001000000000UL});
		public static readonly BitSet _RBRACE_in_type_declaration1203 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_type_declaration1206 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _decl_in_nested_decl1223 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_nested_decl1225 = new BitSet(new ulong[]{0x0000000000000072UL});
		public static readonly BitSet _type_in_decl1245 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_decl1249 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INT_in_type1286 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BOOL_in_type1294 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRUCT_in_type1302 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_type1305 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _declaration_in_declarations1321 = new BitSet(new ulong[]{0x0000000000000072UL});
		public static readonly BitSet _type_in_declaration1349 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _id_list_in_declaration1353 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_declaration1355 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_id_list1392 = new BitSet(new ulong[]{0x0000004000000002UL});
		public static readonly BitSet _COMMA_in_id_list1395 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_id_list1398 = new BitSet(new ulong[]{0x0000004000000002UL});
		public static readonly BitSet _function_in_functions1415 = new BitSet(new ulong[]{0x0000000000000082UL});
		public static readonly BitSet _FUN_in_function1440 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_function1444 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _parameters_in_function1448 = new BitSet(new ulong[]{0x0000000000000170UL});
		public static readonly BitSet _return_type_in_function1452 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _LBRACE_in_function1454 = new BitSet(new ulong[]{0x010000180001DA70UL});
		public static readonly BitSet _declarations_in_function1458 = new BitSet(new ulong[]{0x010000180001DA00UL});
		public static readonly BitSet _statement_list_in_function1462 = new BitSet(new ulong[]{0x0000001000000000UL});
		public static readonly BitSet _RBRACE_in_function1464 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _LPAREN_in_parameters1510 = new BitSet(new ulong[]{0x0000010000000070UL});
		public static readonly BitSet _decl_in_parameters1513 = new BitSet(new ulong[]{0x0000014000000000UL});
		public static readonly BitSet _COMMA_in_parameters1516 = new BitSet(new ulong[]{0x0000000000000070UL});
		public static readonly BitSet _decl_in_parameters1518 = new BitSet(new ulong[]{0x0000014000000000UL});
		public static readonly BitSet _RPAREN_in_parameters1524 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _type_in_return_type1554 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VOID_in_return_type1562 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _block_in_statement1577 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assignment_in_statement1593 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _print_in_statement1601 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _read_in_statement1609 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _conditional_in_statement1617 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _loop_in_statement1625 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _delete_in_statement1633 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ret_in_statement1641 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _invocation_in_statement1657 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _LBRACE_in_block1672 = new BitSet(new ulong[]{0x010000180001DA00UL});
		public static readonly BitSet _statement_list_in_block1676 = new BitSet(new ulong[]{0x0000001000000000UL});
		public static readonly BitSet _RBRACE_in_block1678 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _statement_in_statement_list1709 = new BitSet(new ulong[]{0x010000080001DA02UL});
		public static readonly BitSet _lvalue_in_assignment1737 = new BitSet(new ulong[]{0x0000020000000000UL});
		public static readonly BitSet _ASSIGN_in_assignment1739 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_assignment1743 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_assignment1745 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PRINT_in_print1778 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_print1781 = new BitSet(new ulong[]{0x0000002000000400UL});
		public static readonly BitSet _ENDL_in_print1784 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_print1788 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _READ_in_read1804 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _lvalue_in_read1807 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_read1809 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _IF_in_conditional1825 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _LPAREN_in_conditional1828 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_conditional1831 = new BitSet(new ulong[]{0x0000010000000000UL});
		public static readonly BitSet _RPAREN_in_conditional1833 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _block_in_conditional1836 = new BitSet(new ulong[]{0x0000000000002002UL});
		public static readonly BitSet _ELSE_in_conditional1839 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _block_in_conditional1842 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _WHILE_in_loop1859 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _LPAREN_in_loop1861 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_loop1865 = new BitSet(new ulong[]{0x0000010000000000UL});
		public static readonly BitSet _RPAREN_in_loop1867 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _block_in_loop1871 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _DELETE_in_delete1907 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_delete1910 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_delete1912 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _RETURN_in_ret1928 = new BitSet(new ulong[]{0x039000A0001E0000UL});
		public static readonly BitSet _expression_in_ret1932 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_ret1936 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_invocation1954 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _arguments_in_invocation1958 = new BitSet(new ulong[]{0x0000002000000000UL});
		public static readonly BitSet _SEMI_in_invocation1960 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_lvalue1993 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _DOT_in_lvalue1996 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_lvalue1999 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _boolterm_in_expression2016 = new BitSet(new ulong[]{0x0000180000000002UL});
		public static readonly BitSet _AND_in_expression2020 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _OR_in_expression2025 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _boolterm_in_expression2029 = new BitSet(new ulong[]{0x0000180000000002UL});
		public static readonly BitSet _simple_in_boolterm2046 = new BitSet(new ulong[]{0x0007E00000000002UL});
		public static readonly BitSet _EQ_in_boolterm2050 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _LT_in_boolterm2055 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _GT_in_boolterm2060 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _NE_in_boolterm2065 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _LE_in_boolterm2070 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _GE_in_boolterm2075 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _simple_in_boolterm2079 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _term_in_simple2096 = new BitSet(new ulong[]{0x0018000000000002UL});
		public static readonly BitSet _PLUS_in_simple2100 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _MINUS_in_simple2105 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _term_in_simple2109 = new BitSet(new ulong[]{0x0018000000000002UL});
		public static readonly BitSet _unary_in_term2126 = new BitSet(new ulong[]{0x0060000000000002UL});
		public static readonly BitSet _TIMES_in_term2130 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _DIVIDE_in_term2135 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _unary_in_term2139 = new BitSet(new ulong[]{0x0060000000000002UL});
		public static readonly BitSet _NOT_in_unary2156 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _odd_not_in_unary2159 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _MINUS_in_unary2167 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _odd_neg_in_unary2170 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _selector_in_unary2178 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NOT_in_odd_not2193 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _even_not_in_odd_not2196 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _selector_in_odd_not2206 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NOT_in_even_not2236 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _odd_not_in_even_not2239 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _selector_in_even_not2247 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _MINUS_in_odd_neg2262 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _even_neg_in_odd_neg2265 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _selector_in_odd_neg2275 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _MINUS_in_even_neg2305 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _odd_neg_in_even_neg2308 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _selector_in_even_neg2316 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _factor_in_selector2331 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _DOT_in_selector2334 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_selector2337 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _LPAREN_in_factor2354 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_factor2357 = new BitSet(new ulong[]{0x0000010000000000UL});
		public static readonly BitSet _RPAREN_in_factor2359 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_factor2370 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _arguments_in_factor2374 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_factor2400 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INTEGER_in_factor2408 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _TRUE_in_factor2416 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FALSE_in_factor2424 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NEW_in_factor2432 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_factor2435 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NULL_in_factor2443 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _LPAREN_in_arguments2458 = new BitSet(new ulong[]{0x03900180001E0000UL});
		public static readonly BitSet _arg_list_in_arguments2461 = new BitSet(new ulong[]{0x0000010000000000UL});
		public static readonly BitSet _RPAREN_in_arguments2463 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expression_in_arg_list2479 = new BitSet(new ulong[]{0x0000004000000002UL});
		public static readonly BitSet _COMMA_in_arg_list2482 = new BitSet(new ulong[]{0x03900080001E0000UL});
		public static readonly BitSet _expression_in_arg_list2484 = new BitSet(new ulong[]{0x0000004000000002UL});
		public static readonly BitSet _STRUCT_in_synpred1_Evil1119 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_synpred1_Evil1121 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _LBRACE_in_synpred1_Evil1123 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRUCT_in_synpred2_Evil1162 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ID_in_synpred2_Evil1164 = new BitSet(new ulong[]{0x0000000800000000UL});
		public static readonly BitSet _LBRACE_in_synpred2_Evil1166 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _lvalue_in_synpred3_Evil1586 = new BitSet(new ulong[]{0x0000020000000000UL});
		public static readonly BitSet _ASSIGN_in_synpred3_Evil1588 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_synpred4_Evil1650 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _LPAREN_in_synpred4_Evil1652 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}