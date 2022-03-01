using MathsLibrary.Interpreter.Token;

namespace MathsLibrary.Interpreter
{
    /// <summary>
    /// Common interface for all nodes on the syntax tree
    /// </summary>
    public interface INode : IToken
    {
        INode Left { get; set; }
        INode Right { get; set; }

        void Print();
        void Print(string side);
    }
}