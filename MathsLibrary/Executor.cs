using System;
using MathsLibrary.Token;

namespace MathsLibrary {
    public class Executor {
        public static double Evaluate(INode root) {
            return ((Node<double>) Executor.Reduce(root)).Value;
        } 

        public static INode Reduce(INode root) {
                var left = root.Left is null ? null : (Node<double>) Executor.Reduce(root.Left);
                var right = root.Right is null ? null : (Node<double>) Executor.Reduce(root.Right);
            switch (root.Type) {
                case TokenType.Add:
                    return NodeCalculator.Add(left, right);
                case TokenType.Sub:
                    return NodeCalculator.Sub(left, right);
                case TokenType.Mul:
                    return NodeCalculator.Mul(left, right);
                case TokenType.Div:
                    return NodeCalculator.Div(left, right);
                case TokenType.Exp:
                    return NodeCalculator.Exp(left, right);
                case TokenType.Char:
                    var strRoot = (Node<string>) root;
                    var rootValue = strRoot.Value;
                    var funcHandler = FunctionRegistry.GetFunction(rootValue);
                    var constant = FunctionRegistry.GetConstant(rootValue);

                    if (funcHandler is not null)
                        return NodeCalculator.Func(right, funcHandler);
                    else if (constant is not null)
                        return NodeFactory.FromValue<double>(TokenType.Num, (double) constant);
                    else
                        throw new Exception("Fuckwit");
                default:
                    return root;
            }
        }
    }
}