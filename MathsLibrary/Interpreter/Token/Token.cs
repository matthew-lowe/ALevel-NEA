namespace MathsLibrary.Interpreter.Token
{
    /// <summary>
    /// Implementation of a token without a value
    /// </summary>
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

    /// <summary>
    /// Implementation of a token with a value
    /// </summary>
    /// <typeparam name="TValue">The type of the value</typeparam>
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
