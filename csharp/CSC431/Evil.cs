using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.IO;

public class Evil
{
    private static void printError(string msg)
    {
        Console.WriteLine(msg);
    }

    public static void Main(String[] args)
    {
        parseParameters(args);

        CommonTokenStream tokens = new CommonTokenStream(createLexer());
        EvilParser parser = new EvilParser(tokens);
        EvilParser.program_return ret = null;

        try
        {
            ret = parser.Program();
        }
        catch (RecognitionException e)
        {
            error(e.ToString());
            return;
        }

        CommonTree t = (CommonTree)ret.Tree;
        if (_displayAST && t != null)
        {
            DotTreeGenerator gen = new DotTreeGenerator();
            var st = gen.ToDot(t);
            Console.WriteLine(st);
        }

        /*
           create and invoke a tree parser
      */
        try
        {
            CommonTreeNodeStream nodes = new CommonTreeNodeStream(t);
            nodes.TokenStream = tokens;
            GenericEvilTreeParser tparser = new GenericEvilTreeParser(nodes);

            StructTypes stypes = new StructTypes();
            SymbolTable stable = new SymbolTable();

            tparser.Program(stypes, stable);
        }
        catch (RecognitionException e)
        {
            error(e.ToString());
        }
    }

    private const String DISPLAYAST = "-displayAST";

    private static String _inputFile = null;
    private static bool _displayAST = false;

    private static void parseParameters(String[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].Equals(DISPLAYAST))
            {
                _displayAST = true;
            }
            else if (args[i][0] == '-')
            {
                printError("unexpected option: " + args[i]);
                Environment.Exit(1);
            }
            else if (_inputFile != null)
            {
                printError("too many files specified");
                Environment.Exit(1);
            }
            else
            {
                _inputFile = args[i];
            }
        }
    }


    private static void error(String msg)
    {
        printError(msg);
        Environment.Exit(1);
    }

    private static EvilLexer createLexer()
    {
        try
        {
            ANTLRInputStream input;
            if (_inputFile == null)
            {
                input = new ANTLRInputStream(Console.OpenStandardInput());
            }
            else
            {
                input = new ANTLRInputStream(new FileStream(_inputFile, FileMode.Open));
            }
            return new EvilLexer(input);
        }
        catch (System.IO.IOException e)
        {
            Console.WriteLine("file not found: " + _inputFile);
            Environment.Exit(1);
            return null;
        }
    }
}