using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using CSC431.Stack;
using CSC431.Steps;

namespace CSC431
{
    class StackSteps
    {
        public static InStep<Tuple<CommonTokenStream, CommonTree>> MakeClrExe()
        {
            return new InStep<Tuple<CommonTokenStream, CommonTree>>(t =>
            {
                CommonTreeNodeStream nodes = new CommonTreeNodeStream(t.Item2);
                nodes.TokenStream = t.Item1;
                StackGen tparser = new StackGen(nodes);
                tparser.TraceDestination = Console.Out;

                tparser.Program();

                if (tparser.NumberOfSyntaxErrors != 0)
                    throw new EvilException("make cfg syntax error");
            });
        }
    }
}
