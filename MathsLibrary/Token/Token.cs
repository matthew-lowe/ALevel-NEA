using System;

namespace MathsLibrary.Token
{
    public class Token : IToken
    {
        public TokenType Type { get; set; }

        public Token(TokenType type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }

    public class Token<TValue> : Token, IToken<TValue>
    {
        public TValue Value { get; set; }

        public Token(TokenType type, TValue value) : base(type)
        {
            Value = value;
        }

        public override string ToString()
        {
            return "[" + base.ToString() + " " + Value.ToString() + "]";
        }
    }
}
