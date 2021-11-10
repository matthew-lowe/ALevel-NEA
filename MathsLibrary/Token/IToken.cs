namespace MathsLibrary.Token
{
    public interface IToken
    {
        public TokenType Type { get; set; }
    }
    
    public interface IToken<T> : IToken
    {
        public T Value { get; set; }
    }
}