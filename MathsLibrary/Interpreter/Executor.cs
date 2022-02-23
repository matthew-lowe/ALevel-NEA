using System;
using System.IO;
using MathsLibrary.Interpreter.Token;

namespace MathsLibrary.Interpreter {
    public static class Executor {
        public static double Evaluate(INode root) {
            return ((Node<double>) Reduce(root, 0)).Value;
        }

        public static double Evaluate(INode root, double value)
        {
            return ((Node<double>) Reduce(root, value)).Value;
        }

        public static INode Reduce(INode root, double value) {
            var left = root.Left is null ? null : (Node<double>) Reduce(root.Left, value);
            var right = root.Right is null ? null : (Node<double>) Reduce(root.Right, value);
            
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
                        return NodeFactory.FromValue(TokenType.Num, (double) constant);
                    else if (rootValue == "x")
                        return NodeFactory.FromValue(TokenType.Num, value);
                    else
                        throw new InvalidDataException("Function or constant not recognised!");
                default:
                    return root;
            }
        }
    }
}