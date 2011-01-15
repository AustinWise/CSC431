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

namespace CSC431
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class EvilLexer : Antlr.Runtime.Lexer
{
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

	public EvilLexer()
	{
		OnCreated();
	}

	public EvilLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public EvilLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "Evil.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];

 
	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    protected virtual void Enter_STRUCT() {}
    protected virtual void Leave_STRUCT() {}

    // $ANTLR start "STRUCT"
    [GrammarRule("STRUCT")]
    private void mSTRUCT()
    {

    		try
    		{
    		int _type = STRUCT;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:13:8: ( 'struct' )
    		DebugEnterAlt(1);
    		// Evil.g:13:10: 'struct'
    		{
    		DebugLocation(13, 10);
    		Match("struct"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "STRUCT"

    protected virtual void Enter_INT() {}
    protected virtual void Leave_INT() {}

    // $ANTLR start "INT"
    [GrammarRule("INT")]
    private void mINT()
    {

    		try
    		{
    		int _type = INT;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:14:5: ( 'int' )
    		DebugEnterAlt(1);
    		// Evil.g:14:7: 'int'
    		{
    		DebugLocation(14, 7);
    		Match("int"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "INT"

    protected virtual void Enter_BOOL() {}
    protected virtual void Leave_BOOL() {}

    // $ANTLR start "BOOL"
    [GrammarRule("BOOL")]
    private void mBOOL()
    {

    		try
    		{
    		int _type = BOOL;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:15:6: ( 'bool' )
    		DebugEnterAlt(1);
    		// Evil.g:15:8: 'bool'
    		{
    		DebugLocation(15, 8);
    		Match("bool"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "BOOL"

    protected virtual void Enter_FUN() {}
    protected virtual void Leave_FUN() {}

    // $ANTLR start "FUN"
    [GrammarRule("FUN")]
    private void mFUN()
    {

    		try
    		{
    		int _type = FUN;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:16:5: ( 'fun' )
    		DebugEnterAlt(1);
    		// Evil.g:16:7: 'fun'
    		{
    		DebugLocation(16, 7);
    		Match("fun"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "FUN"

    protected virtual void Enter_VOID() {}
    protected virtual void Leave_VOID() {}

    // $ANTLR start "VOID"
    [GrammarRule("VOID")]
    private void mVOID()
    {

    		try
    		{
    		int _type = VOID;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:17:6: ( 'void' )
    		DebugEnterAlt(1);
    		// Evil.g:17:8: 'void'
    		{
    		DebugLocation(17, 8);
    		Match("void"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "VOID"

    protected virtual void Enter_PRINT() {}
    protected virtual void Leave_PRINT() {}

    // $ANTLR start "PRINT"
    [GrammarRule("PRINT")]
    private void mPRINT()
    {

    		try
    		{
    		int _type = PRINT;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:18:7: ( 'print' )
    		DebugEnterAlt(1);
    		// Evil.g:18:9: 'print'
    		{
    		DebugLocation(18, 9);
    		Match("print"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "PRINT"

    protected virtual void Enter_ENDL() {}
    protected virtual void Leave_ENDL() {}

    // $ANTLR start "ENDL"
    [GrammarRule("ENDL")]
    private void mENDL()
    {

    		try
    		{
    		int _type = ENDL;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:19:6: ( 'endl' )
    		DebugEnterAlt(1);
    		// Evil.g:19:8: 'endl'
    		{
    		DebugLocation(19, 8);
    		Match("endl"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ENDL"

    protected virtual void Enter_READ() {}
    protected virtual void Leave_READ() {}

    // $ANTLR start "READ"
    [GrammarRule("READ")]
    private void mREAD()
    {

    		try
    		{
    		int _type = READ;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:20:6: ( 'read' )
    		DebugEnterAlt(1);
    		// Evil.g:20:8: 'read'
    		{
    		DebugLocation(20, 8);
    		Match("read"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "READ"

    protected virtual void Enter_IF() {}
    protected virtual void Leave_IF() {}

    // $ANTLR start "IF"
    [GrammarRule("IF")]
    private void mIF()
    {

    		try
    		{
    		int _type = IF;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:21:4: ( 'if' )
    		DebugEnterAlt(1);
    		// Evil.g:21:6: 'if'
    		{
    		DebugLocation(21, 6);
    		Match("if"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "IF"

    protected virtual void Enter_ELSE() {}
    protected virtual void Leave_ELSE() {}

    // $ANTLR start "ELSE"
    [GrammarRule("ELSE")]
    private void mELSE()
    {

    		try
    		{
    		int _type = ELSE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:22:6: ( 'else' )
    		DebugEnterAlt(1);
    		// Evil.g:22:8: 'else'
    		{
    		DebugLocation(22, 8);
    		Match("else"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ELSE"

    protected virtual void Enter_WHILE() {}
    protected virtual void Leave_WHILE() {}

    // $ANTLR start "WHILE"
    [GrammarRule("WHILE")]
    private void mWHILE()
    {

    		try
    		{
    		int _type = WHILE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:23:7: ( 'while' )
    		DebugEnterAlt(1);
    		// Evil.g:23:9: 'while'
    		{
    		DebugLocation(23, 9);
    		Match("while"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "WHILE"

    protected virtual void Enter_DELETE() {}
    protected virtual void Leave_DELETE() {}

    // $ANTLR start "DELETE"
    [GrammarRule("DELETE")]
    private void mDELETE()
    {

    		try
    		{
    		int _type = DELETE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:24:8: ( 'delete' )
    		DebugEnterAlt(1);
    		// Evil.g:24:10: 'delete'
    		{
    		DebugLocation(24, 10);
    		Match("delete"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "DELETE"

    protected virtual void Enter_RETURN() {}
    protected virtual void Leave_RETURN() {}

    // $ANTLR start "RETURN"
    [GrammarRule("RETURN")]
    private void mRETURN()
    {

    		try
    		{
    		int _type = RETURN;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:25:8: ( 'return' )
    		DebugEnterAlt(1);
    		// Evil.g:25:10: 'return'
    		{
    		DebugLocation(25, 10);
    		Match("return"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "RETURN"

    protected virtual void Enter_TRUE() {}
    protected virtual void Leave_TRUE() {}

    // $ANTLR start "TRUE"
    [GrammarRule("TRUE")]
    private void mTRUE()
    {

    		try
    		{
    		int _type = TRUE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:26:6: ( 'true' )
    		DebugEnterAlt(1);
    		// Evil.g:26:8: 'true'
    		{
    		DebugLocation(26, 8);
    		Match("true"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "TRUE"

    protected virtual void Enter_FALSE() {}
    protected virtual void Leave_FALSE() {}

    // $ANTLR start "FALSE"
    [GrammarRule("FALSE")]
    private void mFALSE()
    {

    		try
    		{
    		int _type = FALSE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:27:7: ( 'false' )
    		DebugEnterAlt(1);
    		// Evil.g:27:9: 'false'
    		{
    		DebugLocation(27, 9);
    		Match("false"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "FALSE"

    protected virtual void Enter_NEW() {}
    protected virtual void Leave_NEW() {}

    // $ANTLR start "NEW"
    [GrammarRule("NEW")]
    private void mNEW()
    {

    		try
    		{
    		int _type = NEW;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:28:5: ( 'new' )
    		DebugEnterAlt(1);
    		// Evil.g:28:7: 'new'
    		{
    		DebugLocation(28, 7);
    		Match("new"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "NEW"

    protected virtual void Enter_NULL() {}
    protected virtual void Leave_NULL() {}

    // $ANTLR start "NULL"
    [GrammarRule("NULL")]
    private void mNULL()
    {

    		try
    		{
    		int _type = NULL;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:29:6: ( 'null' )
    		DebugEnterAlt(1);
    		// Evil.g:29:8: 'null'
    		{
    		DebugLocation(29, 8);
    		Match("null"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "NULL"

    protected virtual void Enter_LBRACE() {}
    protected virtual void Leave_LBRACE() {}

    // $ANTLR start "LBRACE"
    [GrammarRule("LBRACE")]
    private void mLBRACE()
    {

    		try
    		{
    		int _type = LBRACE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:64:10: ( '{' )
    		DebugEnterAlt(1);
    		// Evil.g:64:13: '{'
    		{
    		DebugLocation(64, 13);
    		Match('{'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "LBRACE"

    protected virtual void Enter_RBRACE() {}
    protected virtual void Leave_RBRACE() {}

    // $ANTLR start "RBRACE"
    [GrammarRule("RBRACE")]
    private void mRBRACE()
    {

    		try
    		{
    		int _type = RBRACE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:65:10: ( '}' )
    		DebugEnterAlt(1);
    		// Evil.g:65:13: '}'
    		{
    		DebugLocation(65, 13);
    		Match('}'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "RBRACE"

    protected virtual void Enter_SEMI() {}
    protected virtual void Leave_SEMI() {}

    // $ANTLR start "SEMI"
    [GrammarRule("SEMI")]
    private void mSEMI()
    {

    		try
    		{
    		int _type = SEMI;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:66:10: ( ';' )
    		DebugEnterAlt(1);
    		// Evil.g:66:13: ';'
    		{
    		DebugLocation(66, 13);
    		Match(';'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "SEMI"

    protected virtual void Enter_COMMA() {}
    protected virtual void Leave_COMMA() {}

    // $ANTLR start "COMMA"
    [GrammarRule("COMMA")]
    private void mCOMMA()
    {

    		try
    		{
    		int _type = COMMA;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:67:10: ( ',' )
    		DebugEnterAlt(1);
    		// Evil.g:67:13: ','
    		{
    		DebugLocation(67, 13);
    		Match(','); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "COMMA"

    protected virtual void Enter_LPAREN() {}
    protected virtual void Leave_LPAREN() {}

    // $ANTLR start "LPAREN"
    [GrammarRule("LPAREN")]
    private void mLPAREN()
    {

    		try
    		{
    		int _type = LPAREN;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:68:10: ( '(' )
    		DebugEnterAlt(1);
    		// Evil.g:68:13: '('
    		{
    		DebugLocation(68, 13);
    		Match('('); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "LPAREN"

    protected virtual void Enter_RPAREN() {}
    protected virtual void Leave_RPAREN() {}

    // $ANTLR start "RPAREN"
    [GrammarRule("RPAREN")]
    private void mRPAREN()
    {

    		try
    		{
    		int _type = RPAREN;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:69:10: ( ')' )
    		DebugEnterAlt(1);
    		// Evil.g:69:13: ')'
    		{
    		DebugLocation(69, 13);
    		Match(')'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "RPAREN"

    protected virtual void Enter_ASSIGN() {}
    protected virtual void Leave_ASSIGN() {}

    // $ANTLR start "ASSIGN"
    [GrammarRule("ASSIGN")]
    private void mASSIGN()
    {

    		try
    		{
    		int _type = ASSIGN;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:70:10: ( '=' )
    		DebugEnterAlt(1);
    		// Evil.g:70:13: '='
    		{
    		DebugLocation(70, 13);
    		Match('='); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ASSIGN"

    protected virtual void Enter_DOT() {}
    protected virtual void Leave_DOT() {}

    // $ANTLR start "DOT"
    [GrammarRule("DOT")]
    private void mDOT()
    {

    		try
    		{
    		int _type = DOT;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:71:10: ( '.' )
    		DebugEnterAlt(1);
    		// Evil.g:71:13: '.'
    		{
    		DebugLocation(71, 13);
    		Match('.'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "DOT"

    protected virtual void Enter_AND() {}
    protected virtual void Leave_AND() {}

    // $ANTLR start "AND"
    [GrammarRule("AND")]
    private void mAND()
    {

    		try
    		{
    		int _type = AND;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:72:10: ( '&&' )
    		DebugEnterAlt(1);
    		// Evil.g:72:13: '&&'
    		{
    		DebugLocation(72, 13);
    		Match("&&"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "AND"

    protected virtual void Enter_OR() {}
    protected virtual void Leave_OR() {}

    // $ANTLR start "OR"
    [GrammarRule("OR")]
    private void mOR()
    {

    		try
    		{
    		int _type = OR;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:73:10: ( '||' )
    		DebugEnterAlt(1);
    		// Evil.g:73:13: '||'
    		{
    		DebugLocation(73, 13);
    		Match("||"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "OR"

    protected virtual void Enter_EQ() {}
    protected virtual void Leave_EQ() {}

    // $ANTLR start "EQ"
    [GrammarRule("EQ")]
    private void mEQ()
    {

    		try
    		{
    		int _type = EQ;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:74:10: ( '==' )
    		DebugEnterAlt(1);
    		// Evil.g:74:13: '=='
    		{
    		DebugLocation(74, 13);
    		Match("=="); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "EQ"

    protected virtual void Enter_LT() {}
    protected virtual void Leave_LT() {}

    // $ANTLR start "LT"
    [GrammarRule("LT")]
    private void mLT()
    {

    		try
    		{
    		int _type = LT;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:75:10: ( '<' )
    		DebugEnterAlt(1);
    		// Evil.g:75:13: '<'
    		{
    		DebugLocation(75, 13);
    		Match('<'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "LT"

    protected virtual void Enter_GT() {}
    protected virtual void Leave_GT() {}

    // $ANTLR start "GT"
    [GrammarRule("GT")]
    private void mGT()
    {

    		try
    		{
    		int _type = GT;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:76:10: ( '>' )
    		DebugEnterAlt(1);
    		// Evil.g:76:13: '>'
    		{
    		DebugLocation(76, 13);
    		Match('>'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "GT"

    protected virtual void Enter_NE() {}
    protected virtual void Leave_NE() {}

    // $ANTLR start "NE"
    [GrammarRule("NE")]
    private void mNE()
    {

    		try
    		{
    		int _type = NE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:77:10: ( '!=' )
    		DebugEnterAlt(1);
    		// Evil.g:77:13: '!='
    		{
    		DebugLocation(77, 13);
    		Match("!="); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "NE"

    protected virtual void Enter_LE() {}
    protected virtual void Leave_LE() {}

    // $ANTLR start "LE"
    [GrammarRule("LE")]
    private void mLE()
    {

    		try
    		{
    		int _type = LE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:78:10: ( '<=' )
    		DebugEnterAlt(1);
    		// Evil.g:78:13: '<='
    		{
    		DebugLocation(78, 13);
    		Match("<="); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "LE"

    protected virtual void Enter_GE() {}
    protected virtual void Leave_GE() {}

    // $ANTLR start "GE"
    [GrammarRule("GE")]
    private void mGE()
    {

    		try
    		{
    		int _type = GE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:79:10: ( '>=' )
    		DebugEnterAlt(1);
    		// Evil.g:79:13: '>='
    		{
    		DebugLocation(79, 13);
    		Match(">="); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "GE"

    protected virtual void Enter_PLUS() {}
    protected virtual void Leave_PLUS() {}

    // $ANTLR start "PLUS"
    [GrammarRule("PLUS")]
    private void mPLUS()
    {

    		try
    		{
    		int _type = PLUS;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:80:10: ( '+' )
    		DebugEnterAlt(1);
    		// Evil.g:80:13: '+'
    		{
    		DebugLocation(80, 13);
    		Match('+'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "PLUS"

    protected virtual void Enter_MINUS() {}
    protected virtual void Leave_MINUS() {}

    // $ANTLR start "MINUS"
    [GrammarRule("MINUS")]
    private void mMINUS()
    {

    		try
    		{
    		int _type = MINUS;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:81:10: ( '-' )
    		DebugEnterAlt(1);
    		// Evil.g:81:13: '-'
    		{
    		DebugLocation(81, 13);
    		Match('-'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "MINUS"

    protected virtual void Enter_TIMES() {}
    protected virtual void Leave_TIMES() {}

    // $ANTLR start "TIMES"
    [GrammarRule("TIMES")]
    private void mTIMES()
    {

    		try
    		{
    		int _type = TIMES;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:82:10: ( '*' )
    		DebugEnterAlt(1);
    		// Evil.g:82:13: '*'
    		{
    		DebugLocation(82, 13);
    		Match('*'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "TIMES"

    protected virtual void Enter_DIVIDE() {}
    protected virtual void Leave_DIVIDE() {}

    // $ANTLR start "DIVIDE"
    [GrammarRule("DIVIDE")]
    private void mDIVIDE()
    {

    		try
    		{
    		int _type = DIVIDE;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:83:10: ( '/' )
    		DebugEnterAlt(1);
    		// Evil.g:83:13: '/'
    		{
    		DebugLocation(83, 13);
    		Match('/'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "DIVIDE"

    protected virtual void Enter_NOT() {}
    protected virtual void Leave_NOT() {}

    // $ANTLR start "NOT"
    [GrammarRule("NOT")]
    private void mNOT()
    {

    		try
    		{
    		int _type = NOT;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:84:10: ( '!' )
    		DebugEnterAlt(1);
    		// Evil.g:84:13: '!'
    		{
    		DebugLocation(84, 13);
    		Match('!'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "NOT"

    protected virtual void Enter_ID() {}
    protected virtual void Leave_ID() {}

    // $ANTLR start "ID"
    [GrammarRule("ID")]
    private void mID()
    {

    		try
    		{
    		int _type = ID;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:86:10: ( ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )* )
    		DebugEnterAlt(1);
    		// Evil.g:86:13: ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
    		{
    		DebugLocation(86, 13);
    		if ((input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
    		{
    			input.Consume();

    		}
    		else
    		{
    			MismatchedSetException mse = new MismatchedSetException(null,input);
    			DebugRecognitionException(mse);
    			Recover(mse);
    			throw mse;}

    		DebugLocation(86, 34);
    		// Evil.g:86:34: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
    		try { DebugEnterSubRule(1);
    		while (true)
    		{
    			int alt1=2;
    			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    			int LA1_0 = input.LA(1);

    			if (((LA1_0>='0' && LA1_0<='9')||(LA1_0>='A' && LA1_0<='Z')||(LA1_0>='a' && LA1_0<='z')))
    			{
    				alt1=1;
    			}


    			} finally { DebugExitDecision(1); }
    			switch ( alt1 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:
    				{
    				DebugLocation(86, 34);
    				if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
    				{
    					input.Consume();

    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					Recover(mse);
    					throw mse;}


    				}
    				break;

    			default:
    				goto loop1;
    			}
    		}

    		loop1:
    			;

    		} finally { DebugExitSubRule(1); }


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ID"

    protected virtual void Enter_INTEGER() {}
    protected virtual void Leave_INTEGER() {}

    // $ANTLR start "INTEGER"
    [GrammarRule("INTEGER")]
    private void mINTEGER()
    {

    		try
    		{
    		int _type = INTEGER;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:88:10: ( '0' | ( '1' .. '9' ) ( '0' .. '9' )* )
    		int alt3=2;
    		try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    		int LA3_0 = input.LA(1);

    		if ((LA3_0=='0'))
    		{
    			alt3=1;
    		}
    		else if (((LA3_0>='1' && LA3_0<='9')))
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
    			// Evil.g:88:13: '0'
    			{
    			DebugLocation(88, 13);
    			Match('0'); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Evil.g:88:19: ( '1' .. '9' ) ( '0' .. '9' )*
    			{
    			DebugLocation(88, 19);
    			// Evil.g:88:19: ( '1' .. '9' )
    			DebugEnterAlt(1);
    			// Evil.g:88:20: '1' .. '9'
    			{
    			DebugLocation(88, 20);
    			MatchRange('1','9'); 

    			}

    			DebugLocation(88, 30);
    			// Evil.g:88:30: ( '0' .. '9' )*
    			try { DebugEnterSubRule(2);
    			while (true)
    			{
    				int alt2=2;
    				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    				int LA2_0 = input.LA(1);

    				if (((LA2_0>='0' && LA2_0<='9')))
    				{
    					alt2=1;
    				}


    				} finally { DebugExitDecision(2); }
    				switch ( alt2 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Evil.g:88:31: '0' .. '9'
    					{
    					DebugLocation(88, 31);
    					MatchRange('0','9'); 

    					}
    					break;

    				default:
    					goto loop2;
    				}
    			}

    			loop2:
    				;

    			} finally { DebugExitSubRule(2); }


    			}
    			break;

    		}
    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "INTEGER"

    protected virtual void Enter_WS() {}
    protected virtual void Leave_WS() {}

    // $ANTLR start "WS"
    [GrammarRule("WS")]
    private void mWS()
    {

    		try
    		{
    		int _type = WS;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:90:10: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
    		DebugEnterAlt(1);
    		// Evil.g:90:13: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
    		{
    		DebugLocation(90, 13);
    		// Evil.g:90:13: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
    		int cnt4=0;
    		try { DebugEnterSubRule(4);
    		while (true)
    		{
    			int alt4=2;
    			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    			int LA4_0 = input.LA(1);

    			if (((LA4_0>='\t' && LA4_0<='\n')||(LA4_0>='\f' && LA4_0<='\r')||LA4_0==' '))
    			{
    				alt4=1;
    			}


    			} finally { DebugExitDecision(4); }
    			switch (alt4)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:
    				{
    				DebugLocation(90, 13);
    				if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
    				{
    					input.Consume();

    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					Recover(mse);
    					throw mse;}


    				}
    				break;

    			default:
    				if (cnt4 >= 1)
    					goto loop4;

    				EarlyExitException eee4 = new EarlyExitException( 4, input );
    				DebugRecognitionException(eee4);
    				throw eee4;
    			}
    			cnt4++;
    		}
    		loop4:
    			;

    		} finally { DebugExitSubRule(4); }

    		DebugLocation(96, 13);
    		 Skip(); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "WS"

    protected virtual void Enter_COMMENT() {}
    protected virtual void Leave_COMMENT() {}

    // $ANTLR start "COMMENT"
    [GrammarRule("COMMENT")]
    private void mCOMMENT()
    {

    		try
    		{
    		int _type = COMMENT;
    		int _channel = DefaultTokenChannel;
    		// Evil.g:99:10: ( '#' (~ '\\n' )* '\\n' )
    		DebugEnterAlt(1);
    		// Evil.g:99:13: '#' (~ '\\n' )* '\\n'
    		{
    		DebugLocation(99, 13);
    		Match('#'); 
    		DebugLocation(99, 17);
    		// Evil.g:99:17: (~ '\\n' )*
    		try { DebugEnterSubRule(5);
    		while (true)
    		{
    			int alt5=2;
    			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    			int LA5_0 = input.LA(1);

    			if (((LA5_0>='\u0000' && LA5_0<='\t')||(LA5_0>='\u000B' && LA5_0<='\uFFFF')))
    			{
    				alt5=1;
    			}


    			} finally { DebugExitDecision(5); }
    			switch ( alt5 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Evil.g:99:18: ~ '\\n'
    				{
    				DebugLocation(99, 18);
    				if ((input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\uFFFF'))
    				{
    					input.Consume();

    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					Recover(mse);
    					throw mse;}


    				}
    				break;

    			default:
    				goto loop5;
    			}
    		}

    		loop5:
    			;

    		} finally { DebugExitSubRule(5); }

    		DebugLocation(99, 26);
    		Match('\n'); 
    		DebugLocation(100, 13);
    		 Skip(); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "COMMENT"

    public override void mTokens()
    {
    	// Evil.g:1:8: ( STRUCT | INT | BOOL | FUN | VOID | PRINT | ENDL | READ | IF | ELSE | WHILE | DELETE | RETURN | TRUE | FALSE | NEW | NULL | LBRACE | RBRACE | SEMI | COMMA | LPAREN | RPAREN | ASSIGN | DOT | AND | OR | EQ | LT | GT | NE | LE | GE | PLUS | MINUS | TIMES | DIVIDE | NOT | ID | INTEGER | WS | COMMENT )
    	int alt6=42;
    	try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    	try
    	{
    		alt6 = dfa6.Predict(input);
    	}
    	catch (NoViableAltException nvae)
    	{
    		DebugRecognitionException(nvae);
    		throw;
    	}
    	} finally { DebugExitDecision(6); }
    	switch (alt6)
    	{
    	case 1:
    		DebugEnterAlt(1);
    		// Evil.g:1:10: STRUCT
    		{
    		DebugLocation(1, 10);
    		mSTRUCT(); 

    		}
    		break;
    	case 2:
    		DebugEnterAlt(2);
    		// Evil.g:1:17: INT
    		{
    		DebugLocation(1, 17);
    		mINT(); 

    		}
    		break;
    	case 3:
    		DebugEnterAlt(3);
    		// Evil.g:1:21: BOOL
    		{
    		DebugLocation(1, 21);
    		mBOOL(); 

    		}
    		break;
    	case 4:
    		DebugEnterAlt(4);
    		// Evil.g:1:26: FUN
    		{
    		DebugLocation(1, 26);
    		mFUN(); 

    		}
    		break;
    	case 5:
    		DebugEnterAlt(5);
    		// Evil.g:1:30: VOID
    		{
    		DebugLocation(1, 30);
    		mVOID(); 

    		}
    		break;
    	case 6:
    		DebugEnterAlt(6);
    		// Evil.g:1:35: PRINT
    		{
    		DebugLocation(1, 35);
    		mPRINT(); 

    		}
    		break;
    	case 7:
    		DebugEnterAlt(7);
    		// Evil.g:1:41: ENDL
    		{
    		DebugLocation(1, 41);
    		mENDL(); 

    		}
    		break;
    	case 8:
    		DebugEnterAlt(8);
    		// Evil.g:1:46: READ
    		{
    		DebugLocation(1, 46);
    		mREAD(); 

    		}
    		break;
    	case 9:
    		DebugEnterAlt(9);
    		// Evil.g:1:51: IF
    		{
    		DebugLocation(1, 51);
    		mIF(); 

    		}
    		break;
    	case 10:
    		DebugEnterAlt(10);
    		// Evil.g:1:54: ELSE
    		{
    		DebugLocation(1, 54);
    		mELSE(); 

    		}
    		break;
    	case 11:
    		DebugEnterAlt(11);
    		// Evil.g:1:59: WHILE
    		{
    		DebugLocation(1, 59);
    		mWHILE(); 

    		}
    		break;
    	case 12:
    		DebugEnterAlt(12);
    		// Evil.g:1:65: DELETE
    		{
    		DebugLocation(1, 65);
    		mDELETE(); 

    		}
    		break;
    	case 13:
    		DebugEnterAlt(13);
    		// Evil.g:1:72: RETURN
    		{
    		DebugLocation(1, 72);
    		mRETURN(); 

    		}
    		break;
    	case 14:
    		DebugEnterAlt(14);
    		// Evil.g:1:79: TRUE
    		{
    		DebugLocation(1, 79);
    		mTRUE(); 

    		}
    		break;
    	case 15:
    		DebugEnterAlt(15);
    		// Evil.g:1:84: FALSE
    		{
    		DebugLocation(1, 84);
    		mFALSE(); 

    		}
    		break;
    	case 16:
    		DebugEnterAlt(16);
    		// Evil.g:1:90: NEW
    		{
    		DebugLocation(1, 90);
    		mNEW(); 

    		}
    		break;
    	case 17:
    		DebugEnterAlt(17);
    		// Evil.g:1:94: NULL
    		{
    		DebugLocation(1, 94);
    		mNULL(); 

    		}
    		break;
    	case 18:
    		DebugEnterAlt(18);
    		// Evil.g:1:99: LBRACE
    		{
    		DebugLocation(1, 99);
    		mLBRACE(); 

    		}
    		break;
    	case 19:
    		DebugEnterAlt(19);
    		// Evil.g:1:106: RBRACE
    		{
    		DebugLocation(1, 106);
    		mRBRACE(); 

    		}
    		break;
    	case 20:
    		DebugEnterAlt(20);
    		// Evil.g:1:113: SEMI
    		{
    		DebugLocation(1, 113);
    		mSEMI(); 

    		}
    		break;
    	case 21:
    		DebugEnterAlt(21);
    		// Evil.g:1:118: COMMA
    		{
    		DebugLocation(1, 118);
    		mCOMMA(); 

    		}
    		break;
    	case 22:
    		DebugEnterAlt(22);
    		// Evil.g:1:124: LPAREN
    		{
    		DebugLocation(1, 124);
    		mLPAREN(); 

    		}
    		break;
    	case 23:
    		DebugEnterAlt(23);
    		// Evil.g:1:131: RPAREN
    		{
    		DebugLocation(1, 131);
    		mRPAREN(); 

    		}
    		break;
    	case 24:
    		DebugEnterAlt(24);
    		// Evil.g:1:138: ASSIGN
    		{
    		DebugLocation(1, 138);
    		mASSIGN(); 

    		}
    		break;
    	case 25:
    		DebugEnterAlt(25);
    		// Evil.g:1:145: DOT
    		{
    		DebugLocation(1, 145);
    		mDOT(); 

    		}
    		break;
    	case 26:
    		DebugEnterAlt(26);
    		// Evil.g:1:149: AND
    		{
    		DebugLocation(1, 149);
    		mAND(); 

    		}
    		break;
    	case 27:
    		DebugEnterAlt(27);
    		// Evil.g:1:153: OR
    		{
    		DebugLocation(1, 153);
    		mOR(); 

    		}
    		break;
    	case 28:
    		DebugEnterAlt(28);
    		// Evil.g:1:156: EQ
    		{
    		DebugLocation(1, 156);
    		mEQ(); 

    		}
    		break;
    	case 29:
    		DebugEnterAlt(29);
    		// Evil.g:1:159: LT
    		{
    		DebugLocation(1, 159);
    		mLT(); 

    		}
    		break;
    	case 30:
    		DebugEnterAlt(30);
    		// Evil.g:1:162: GT
    		{
    		DebugLocation(1, 162);
    		mGT(); 

    		}
    		break;
    	case 31:
    		DebugEnterAlt(31);
    		// Evil.g:1:165: NE
    		{
    		DebugLocation(1, 165);
    		mNE(); 

    		}
    		break;
    	case 32:
    		DebugEnterAlt(32);
    		// Evil.g:1:168: LE
    		{
    		DebugLocation(1, 168);
    		mLE(); 

    		}
    		break;
    	case 33:
    		DebugEnterAlt(33);
    		// Evil.g:1:171: GE
    		{
    		DebugLocation(1, 171);
    		mGE(); 

    		}
    		break;
    	case 34:
    		DebugEnterAlt(34);
    		// Evil.g:1:174: PLUS
    		{
    		DebugLocation(1, 174);
    		mPLUS(); 

    		}
    		break;
    	case 35:
    		DebugEnterAlt(35);
    		// Evil.g:1:179: MINUS
    		{
    		DebugLocation(1, 179);
    		mMINUS(); 

    		}
    		break;
    	case 36:
    		DebugEnterAlt(36);
    		// Evil.g:1:185: TIMES
    		{
    		DebugLocation(1, 185);
    		mTIMES(); 

    		}
    		break;
    	case 37:
    		DebugEnterAlt(37);
    		// Evil.g:1:191: DIVIDE
    		{
    		DebugLocation(1, 191);
    		mDIVIDE(); 

    		}
    		break;
    	case 38:
    		DebugEnterAlt(38);
    		// Evil.g:1:198: NOT
    		{
    		DebugLocation(1, 198);
    		mNOT(); 

    		}
    		break;
    	case 39:
    		DebugEnterAlt(39);
    		// Evil.g:1:202: ID
    		{
    		DebugLocation(1, 202);
    		mID(); 

    		}
    		break;
    	case 40:
    		DebugEnterAlt(40);
    		// Evil.g:1:205: INTEGER
    		{
    		DebugLocation(1, 205);
    		mINTEGER(); 

    		}
    		break;
    	case 41:
    		DebugEnterAlt(41);
    		// Evil.g:1:213: WS
    		{
    		DebugLocation(1, 213);
    		mWS(); 

    		}
    		break;
    	case 42:
    		DebugEnterAlt(42);
    		// Evil.g:1:216: COMMENT
    		{
    		DebugLocation(1, 216);
    		mCOMMENT(); 

    		}
    		break;

    	}

    }


	#region DFA
	DFA6 dfa6;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa6 = new DFA6(this);
	}

	private class DFA6 : DFA
	{
		private const string DFA6_eotS =
			"\x01\uffff\x0c\x1e\x06\uffff\x01\x33\x03\uffff\x01\x35\x01\x37\x01\x39"+
			"\x08\uffff\x02\x1e\x01\x3c\x0d\x1e\x08\uffff\x01\x1e\x01\x4c\x01\uffff"+
			"\x01\x1e\x01\x4e\x0a\x1e\x01\x59\x02\x1e\x01\uffff\x01\x5c\x01\uffff"+
			"\x01\x1e\x01\x5e\x01\x1e\x01\x60\x01\x61\x01\x62\x03\x1e\x01\x66\x01"+
			"\uffff\x01\x67\x01\x1e\x01\uffff\x01\x69\x01\uffff\x01\x6a\x03\uffff"+
			"\x01\x1e\x01\x6c\x01\x1e\x02\uffff\x01\x6e\x02\uffff\x01\x6f\x01\uffff"+
			"\x01\x70\x03\uffff";
		private const string DFA6_eofS =
			"\x71\uffff";
		private const string DFA6_minS =
			"\x01\x09\x01\x74\x01\x66\x01\x6f\x01\x61\x01\x6f\x01\x72\x01\x6c\x01"+
			"\x65\x01\x68\x01\x65\x01\x72\x01\x65\x06\uffff\x01\x3d\x03\uffff\x03"+
			"\x3d\x08\uffff\x01\x72\x01\x74\x01\x30\x01\x6f\x01\x6e\x01\x6c\x02\x69"+
			"\x01\x64\x01\x73\x01\x61\x01\x69\x01\x6c\x01\x75\x01\x77\x01\x6c\x08"+
			"\uffff\x01\x75\x01\x30\x01\uffff\x01\x6c\x01\x30\x01\x73\x01\x64\x01"+
			"\x6e\x01\x6c\x01\x65\x01\x64\x01\x75\x01\x6c\x02\x65\x01\x30\x01\x6c"+
			"\x01\x63\x01\uffff\x01\x30\x01\uffff\x01\x65\x01\x30\x01\x74\x03\x30"+
			"\x01\x72\x01\x65\x01\x74\x01\x30\x01\uffff\x01\x30\x01\x74\x01\uffff"+
			"\x01\x30\x01\uffff\x01\x30\x03\uffff\x01\x6e\x01\x30\x01\x65\x02\uffff"+
			"\x01\x30\x02\uffff\x01\x30\x01\uffff\x01\x30\x03\uffff";
		private const string DFA6_maxS =
			"\x01\x7d\x01\x74\x01\x6e\x01\x6f\x01\x75\x01\x6f\x01\x72\x01\x6e\x01"+
			"\x65\x01\x68\x01\x65\x01\x72\x01\x75\x06\uffff\x01\x3d\x03\uffff\x03"+
			"\x3d\x08\uffff\x01\x72\x01\x74\x01\x7a\x01\x6f\x01\x6e\x01\x6c\x02\x69"+
			"\x01\x64\x01\x73\x01\x74\x01\x69\x01\x6c\x01\x75\x01\x77\x01\x6c\x08"+
			"\uffff\x01\x75\x01\x7a\x01\uffff\x01\x6c\x01\x7a\x01\x73\x01\x64\x01"+
			"\x6e\x01\x6c\x01\x65\x01\x64\x01\x75\x01\x6c\x02\x65\x01\x7a\x01\x6c"+
			"\x01\x63\x01\uffff\x01\x7a\x01\uffff\x01\x65\x01\x7a\x01\x74\x03\x7a"+
			"\x01\x72\x01\x65\x01\x74\x01\x7a\x01\uffff\x01\x7a\x01\x74\x01\uffff"+
			"\x01\x7a\x01\uffff\x01\x7a\x03\uffff\x01\x6e\x01\x7a\x01\x65\x02\uffff"+
			"\x01\x7a\x02\uffff\x01\x7a\x01\uffff\x01\x7a\x03\uffff";
		private const string DFA6_acceptS =
			"\x0d\uffff\x01\x12\x01\x13\x01\x14\x01\x15\x01\x16\x01\x17\x01\uffff"+
			"\x01\x19\x01\x1a\x01\x1b\x03\uffff\x01\x22\x01\x23\x01\x24\x01\x25\x01"+
			"\x27\x01\x28\x01\x29\x01\x2a\x10\uffff\x01\x1c\x01\x18\x01\x20\x01\x1d"+
			"\x01\x21\x01\x1e\x01\x1f\x01\x26\x02\uffff\x01\x09\x0f\uffff\x01\x02"+
			"\x01\uffff\x01\x04\x0a\uffff\x01\x10\x02\uffff\x01\x03\x01\uffff\x01"+
			"\x05\x01\uffff\x01\x07\x01\x0a\x01\x08\x03\uffff\x01\x0e\x01\x11\x01"+
			"\uffff\x01\x0f\x01\x06\x01\uffff\x01\x0b\x01\uffff\x01\x01\x01\x0d\x01"+
			"\x0c";
		private const string DFA6_specialS =
			"\x71\uffff}>";
		private static readonly string[] DFA6_transitionS =
			{
				"\x02\x20\x01\uffff\x02\x20\x12\uffff\x01\x20\x01\x19\x01\uffff\x01"+
				"\x21\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x12\x01\x1c\x01\x1a\x01"+
				"\x10\x01\x1b\x01\x14\x01\x1d\x0a\x1f\x01\uffff\x01\x0f\x01\x17\x01\x13"+
				"\x01\x18\x02\uffff\x1a\x1e\x06\uffff\x01\x1e\x01\x03\x01\x1e\x01\x0a"+
				"\x01\x07\x01\x04\x02\x1e\x01\x02\x04\x1e\x01\x0c\x01\x1e\x01\x06\x01"+
				"\x1e\x01\x08\x01\x01\x01\x0b\x01\x1e\x01\x05\x01\x09\x03\x1e\x01\x0d"+
				"\x01\x16\x01\x0e",
				"\x01\x22",
				"\x01\x24\x07\uffff\x01\x23",
				"\x01\x25",
				"\x01\x27\x13\uffff\x01\x26",
				"\x01\x28",
				"\x01\x29",
				"\x01\x2b\x01\uffff\x01\x2a",
				"\x01\x2c",
				"\x01\x2d",
				"\x01\x2e",
				"\x01\x2f",
				"\x01\x30\x0f\uffff\x01\x31",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x01\x32",
				"",
				"",
				"",
				"\x01\x34",
				"\x01\x36",
				"\x01\x38",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x01\x3a",
				"\x01\x3b",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"\x01\x3d",
				"\x01\x3e",
				"\x01\x3f",
				"\x01\x40",
				"\x01\x41",
				"\x01\x42",
				"\x01\x43",
				"\x01\x44\x12\uffff\x01\x45",
				"\x01\x46",
				"\x01\x47",
				"\x01\x48",
				"\x01\x49",
				"\x01\x4a",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x01\x4b",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"",
				"\x01\x4d",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"\x01\x4f",
				"\x01\x50",
				"\x01\x51",
				"\x01\x52",
				"\x01\x53",
				"\x01\x54",
				"\x01\x55",
				"\x01\x56",
				"\x01\x57",
				"\x01\x58",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"\x01\x5a",
				"\x01\x5b",
				"",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"",
				"\x01\x5d",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"\x01\x5f",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"\x01\x63",
				"\x01\x64",
				"\x01\x65",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"\x01\x68",
				"",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"",
				"",
				"",
				"\x01\x6b",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"\x01\x6d",
				"",
				"",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"",
				"",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"",
				"\x0a\x1e\x07\uffff\x1a\x1e\x06\uffff\x1a\x1e",
				"",
				"",
				""
			};

		private static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
		private static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
		private static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
		private static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
		private static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
		private static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
		private static readonly short[][] DFA6_transition;

		static DFA6()
		{
			int numStates = DFA6_transitionS.Length;
			DFA6_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA6_transition[i] = DFA.UnpackEncodedString(DFA6_transitionS[i]);
			}
		}

		public DFA6( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 6;
			this.eot = DFA6_eot;
			this.eof = DFA6_eof;
			this.min = DFA6_min;
			this.max = DFA6_max;
			this.accept = DFA6_accept;
			this.special = DFA6_special;
			this.transition = DFA6_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( STRUCT | INT | BOOL | FUN | VOID | PRINT | ENDL | READ | IF | ELSE | WHILE | DELETE | RETURN | TRUE | FALSE | NEW | NULL | LBRACE | RBRACE | SEMI | COMMA | LPAREN | RPAREN | ASSIGN | DOT | AND | OR | EQ | LT | GT | NE | LE | GE | PLUS | MINUS | TIMES | DIVIDE | NOT | ID | INTEGER | WS | COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}
}