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
                    if (left is not null)
                        return NodeCalculator.Sub(left, right);
                    else
                        return NodeCalculator.Sub(NodeFactory.FromValue<double>(TokenType.Num, 0), right);
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

                    Node<double> asNode = null;
                    if (funcHandler is not null)
                        asNode = NodeCalculator.Func(right, funcHandler);
                    else if (constant is not null)
                        asNode = NodeFactory.FromValue(TokenType.Num, (double) constant);
                    else if (rootValue == "x")
                        asNode = NodeFactory.FromValue(TokenType.Num, value);

                    if (asNode is not null)
                        return left is null ? asNode : NodeCalculator.Mul(left, asNode);
                    else
                        return null;
                case TokenType.Num:
                    return left is null ? root : NodeCalculator.Mul(left, NodeFactory.FromValue<double>(TokenType.Num, ((Node<double>) root).Value));
                default:
                    return root;
            }
        }
    }
}