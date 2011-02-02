using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.Steps;
using Antlr.Runtime;
using System.IO;
using Antlr.Runtime.Tree;
using CSC431.FrontEnd;

namespace CSC431
{
    public static class FrontEndSteps
    {
        public static readonly OutStep<EvilLexer> CreateLexer = new OutStep<EvilLexer>(() =>
        {
            try
            {
                ANTLRInputStream input;
                if (Options.InputFile == null)
                {
                    input = new ANTLRInputStream(Console.OpenStandardInput());
                }
                else
                {
                    input = new ANTLRInputStream(new FileStream(Options.InputFile, FileMode.Open));
                }
                return new EvilLexer(input);
            }
            catch (IOException)
            {
                throw new EvilException("file not found: " + (Options.InputFile ?? "<stdin>"));
            }
        });

        public static readonly InOutStep<EvilLexer, Tuple<CommonTokenStream, CommonTree>> Parse = new InOutStep<EvilLexer, Tuple<CommonTokenStream, CommonTree>>((lexer) =>
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
                throw new EvilException("Error parsing.", e);
            }

            if (parser.NumberOfSyntaxErrors != 0)
                throw new EvilException("syntax errors");

            CommonTree t = (CommonTree)ret.Tree;

            return new Tuple<CommonTokenStream, CommonTree>(tokens, t);
        });

        public static readonly TransformStep<Tuple<CommonTokenStream, CommonTree>> TypeCheck = new TransformStep<Tuple<CommonTokenStream, CommonTree>>(t =>
        {
            CommonTreeNodeStream nodes = new CommonTreeNodeStream(t.Item2);
            nodes.TokenStream = t.Item1;
            TypeChecker tparser = new TypeChecker(nodes);
            tparser.TraceDestination = Console.Out;

            StructTypes stypes = new StructTypes();
            SymbolTable stable = new SymbolTable();

            tparser.Program(stypes, stable);

            if (tparser.NumberOfSyntaxErrors != 0)
                throw new EvilException("type check error");

            return t;
        });

        public static InStep<Tuple<CommonTokenStream, CommonTree>> PrintAst = new InStep<Tuple<CommonTokenStream, CommonTree>>(t =>
        {
            DotTreeGenerator gen = new DotTreeGenerator();
            var st = gen.ToDot(t.Item2);
            Console.WriteLine(st);
        });
    }
}
