using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSC431.Steps;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using CSC431.CFG;
using CSC431.IL;

namespace CSC431
{
    public static class IlSteps
    {

        public static InOutStep<Tuple<CommonTokenStream, CommonTree>, ProgramBlock<MilocInstruction>> MakeCFG()
        {
            return new InOutStep<Tuple<CommonTokenStream, CommonTree>, ProgramBlock<MilocInstruction>>(t =>
            {
                CommonTreeNodeStream nodes = new CommonTreeNodeStream(t.Item2);
                nodes.TokenStream = t.Item1;
                IlGenWalker tparser = new IlGenWalker(nodes);
                tparser.TraceDestination = Console.Out;

                var c = tparser.Program();

                if (tparser.NumberOfSyntaxErrors != 0)
                    throw new EvilException("make cfg syntax error");

                return c;
            });
        }

        public static TransformStep<ProgramBlock<MilocInstruction>> CleanUpCfg()
        {
            return new TransformStep<ProgramBlock<MilocInstruction>>(c =>
            {
                c.Visit(n =>
                {
                    if (!n.IsFixedUp)
                    {
                        throw new Exception("not all nodes are fixed up.");
                    }
                });

                return c;
            });
        }

        public static InStep<ProgramBlock<MilocInstruction>> PrintCFG()
        {
            return new InStep<ProgramBlock<MilocInstruction>>(c =>
            {
                c.Print(Console.Out, new MilocPrinter());
            });
        }

        public static TransformStep<ProgramBlock<MilocInstruction>> ConvertIdentity()
        {
            return new TransformStep<ProgramBlock<MilocInstruction>>(c =>
            {
                return c.Convert(new MilocConverter<MilocInstruction>(new MilocIdentityTranslator())) as ProgramBlock<MilocInstruction>;
            });
        }
    }
}
