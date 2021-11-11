using MathsLibrary.Token;

namespace MathsLibrary
{
    public class Node : INode, IToken
    {
        public INode Left { get; set; }
        public INode Right { get; set; }
        public TokenType Type { get; set; }

        public Node(TokenType type)
        {
            Type = type;
        }
    }

    public class Node<TValue> : Node, IToken<TValue>
    {
        public TValue Value { get; set; }

        public Node(TokenType type, TValue value) : base(type)
        {
            Value = value;
        }
    }

    public static class NodeFactory
    {
        public static INode FromToken(IToken token)
        {
            if (token.Type == TokenType.Num)
                return new Node<double>(TokenType.Num, ((IToken<double>) token).Value);
            else
                return new Node(token.Type);
        }
        
    }
}