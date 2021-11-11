using MathsLibrary.Token;

namespace MathsLibrary
{
    public interface INode
    {
        INode Left { get; set; }
        INode Right { get; set; }
        TokenType Type { get; }

        void Print();
        void Print(string side);
    }
}