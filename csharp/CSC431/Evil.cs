using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.IO;
using CSC431.Steps;
using CSC431.CFG;

namespace CSC431
{
    public static class Evil
    {
        private static void printError(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Main(String[] args)
        {
            parseParameters(args);

            var pipe = CreateLexer
                .FollowWith(Parse);

            if (_displayAST)
                pipe.FollowWith(PrintAst);

            var flow = pipe.FollowWith(TypeCheck)
                .FollowWith(MakeCFG);

            flow.FollowWith(CleanUpCfg).FollowWith(PrintCFG);
            //flow.FollowWith(PrintCFG);
            


            Step.DoAll(pipe);
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

        // -----------------------
        // STEPS
        // -----------------------

        private static OutStep<EvilLexer> CreateLexer = new OutStep<EvilLexer>(() =>
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
            catch (IOException)
            {
                Console.WriteLine("file not found: " + _inputFile);
                Environment.Exit(1);
                return null;
            }
        });

        private static InOutStep<EvilLexer, Tuple<CommonTokenStream, CommonTree>> Parse = new InOutStep<EvilLexer, Tuple<CommonTokenStream, CommonTree>>((lexer) =>
        {
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            EvilParser parser = new EvilParser(tokens);
            EvilParser.program_return ret = null;
            parser.TraceDestination = Console.Out;

            try
            {
                ret = parser.Program();
            }
            catch (RecognitionException e)
            {
                error(e.ToString());
            }

            if (parser.NumberOfSyntaxErrors != 0)
                error("syntax errors");

            CommonTree t = (CommonTree)ret.Tree;

            return new Tuple<CommonTokenStream, CommonTree>(tokens, t);
        });

        private static TransformStep<Tuple<CommonTokenStream, CommonTree>> TypeCheck = new TransformStep<Tuple<CommonTokenStream, CommonTree>>(t =>
        {
            CommonTreeNodeStream nodes = new CommonTreeNodeStream(t.Item2);
            nodes.TokenStream = t.Item1;
            GenericEvilTreeParser tparser = new GenericEvilTreeParser(nodes);
            tparser.TraceDestination = Console.Out;

            StructTypes stypes = new StructTypes();
            SymbolTable stable = new SymbolTable();

            tparser.Program(stypes, stable);

            if (tparser.NumberOfSyntaxErrors != 0)
                error("make cfg syntax error");

            return t;
        });

        private static InStep<Tuple<CommonTokenStream, CommonTree>> PrintAst = new InStep<Tuple<CommonTokenStream, CommonTree>>(t =>
        {
            DotTreeGenerator gen = new DotTreeGenerator();
            var st = gen.ToDot(t.Item2);
            Console.WriteLine(st);
        });

        private static InOutStep<Tuple<CommonTokenStream, CommonTree>, ProgramBlock> MakeCFG = new InOutStep<Tuple<CommonTokenStream, CommonTree>, ProgramBlock>(t =>
        {
            CommonTreeNodeStream nodes = new CommonTreeNodeStream(t.Item2);
            nodes.TokenStream = t.Item1;
            IlGenWalker tparser = new IlGenWalker(nodes);
            tparser.TraceDestination = Console.Out;

            var c = tparser.Program() as CSC431.CFG.ProgramBlock;

            if (tparser.NumberOfSyntaxErrors != 0)
                error("make cfg syntax error");

            return c;
        });

        private static TransformStep<ProgramBlock> CleanUpCfg = new TransformStep<ProgramBlock>(c =>
        {
            c.Visit(n =>
                {
                    if (n is BasicBlock)
                    {
                        ((BasicBlock)n).Merge();
                    }
                });

            return c;
        });

        private static InStep<ProgramBlock> PrintCFG = new InStep<ProgramBlock>(c =>
        {
            c.Visit(n =>
            {
                if (n is ProgramBlock)
                {
                    Console.WriteLine("prog");
                }
                else if (n is BasicBlock)
                {
                    Console.WriteLine("bb");
                }
                else if (n is SeqBlock)
                {
                    Console.WriteLine("seq");
                }
                else if (n is IfBlock)
                {
                    Console.WriteLine("if");
                }
                else if (n is LoopBlock)
                {
                    Console.WriteLine("loop");
                }
                else if (n is FunctionBlock)
                {
                    Console.WriteLine("fun:" + (n as FunctionBlock).Name);
                }
                else if (n is MultiBlock)
                {
                    Console.WriteLine("mb");
                }
            });
        });
    }
}