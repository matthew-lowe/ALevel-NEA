using MathsLibrary.Token;

namespace MathsLibrary
{
    public interface INode : IToken
    {
        INode Left { get; set; }
        INode Right { get; set; }

        void Print();
        void Print(string side);
    }
}