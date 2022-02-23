using MathsLibrary.Interpreter.Token;

namespace MathsLibrary.Interpreter
{
    public interface INode : IToken
    {
        INode Left { get; set; }
        INode Right { get; set; }

        void Print();
        void Print(string side);
    }
}