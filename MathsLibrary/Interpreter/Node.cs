using System;
using MathsLibrary.Interpreter.Token;

namespace MathsLibrary.Interpreter {
    /// <summary>
    /// A node on the syntax tree
    /// </summary>
    public class Node : INode {
        public INode Left { get; set; }
        public INode Right { get; set; }
        public TokenType Type { get; set; }

        public Node(TokenType type) {
            Type = type;
        }

        public override string ToString() {
            return Type.ToString();
        }

        public void Print() {
            Print("");
        }

        public void Print(string side) {
            Console.WriteLine(side + ": " + ToString());

            Left?.Print(side + "L");
            Right?.Print(side + "R");
        }
    }

    /// <summary>
    /// A node on the syntax tree, with an associated value
    /// </summary>
    /// <typeparam name="TValue">The type of the associated value</typeparam>
    public class Node<TValue> : Node, IToken<TValue> {
        public TValue Value { get; set; }

        public Node(TokenType type, TValue value) : base(type) {
            Value = value;
        }

        public override string ToString() {
            return "[" + base.ToString() + " " + Value + "]";
        }
    }

    /// <summary>
    /// Calculate arithmetic in terms of nodes
    /// </summary>
    public static class NodeCalculator {
        public static Node<TValue> Add<TValue>(Node<TValue> a, Node<TValue> b) =>
            NodeFactory.FromValue<TValue>(a.Type, (dynamic) a.Value + b.Value);
        public static Node<TValue> Sub<TValue>(Node<TValue> a, Node<TValue> b) =>
            NodeFactory.FromValue<TValue>(a.Type, (dynamic) a.Value - b.Value);
        public static Node<TValue> Mul<TValue>(Node<TValue> a, Node<TValue> b) =>
            NodeFactory.FromValue<TValue>(a.Type, (dynamic) a.Value * b.Value);
        public static Node<TValue> Div<TValue>(Node<TValue> a, Node<TValue> b) =>
            NodeFactory.FromValue<TValue>(a.Type, (dynamic) a.Value / b.Value);
        public static Node<double> Exp(Node<double> a, Node<double> b) =>
            NodeFactory.FromValue(a.Type, Math.Pow(a.Value,  b.Value));

        public static Node<double> Func(Node<double> a, FuncHandler handler) =>
            NodeFactory.FromValue(a.Type, handler(a.Value));
    }

    /// <summary>
    /// Helpful methods for creating nodes
    /// </summary>
    public static class NodeFactory {
        public static INode FromToken(IToken token)
        {
            return token.Type switch
            {
                TokenType.Num => new Node<double>(TokenType.Num, ((IToken<double>) token).Value),
                TokenType.Char => new Node<string>(TokenType.Char, ((IToken<string>) token).Value),
                _ => new Node(token.Type)
            };
        }

        public static Node<TValue> FromValue<TValue>(TokenType type, TValue value) {
            return new Node<TValue>(type, value);
        }
    }
}