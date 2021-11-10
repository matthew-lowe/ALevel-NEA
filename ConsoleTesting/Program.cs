using System;
using System.Collections.Generic;
using MathsLibrary.Token;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IToken> myList = new List<IToken>
            {
                new Token(TokenType.Add),
                new Token<double>(TokenType.Num, 420.69)
            };
        }
    }
}