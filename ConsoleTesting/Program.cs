using System;
using System.Collections.Generic;
using MathsLibrary;
using MathsLibrary.Token;

namespace ConsoleTesting
{
    class Program
    {
        static void PrintList(List<IToken> tokens)
        {
            foreach (IToken t in tokens)
            {
                Console.Write(t.ToString() + " ");
            }
        }

        static void Main(string[] args)
        {
            string input = "1 + 2 - 420.69";
            var lexer = new Lexer();
            var parser = new Parser();
            var tokens = lexer.Tokenize(input);
            var tree = parser.Next(tokens);
            tree.Print();
            PrintList(tokens);
        }
    }
}