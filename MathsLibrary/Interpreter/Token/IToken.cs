namespace MathsLibrary.Interpreter.Token
{
    /// <summary>
    /// Common interface for all tokens
    /// </summary>
    public interface IToken
    {
        public TokenType Type { get; set; }
    }
    
    /// <summary>
    /// Token with an associated value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IToken<T> : IToken
    {
        public T Value { get; set; }
    }
}
