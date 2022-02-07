using System;
using System.Collections.Generic;
using MathsLibrary;
using MathsLibrary.Token;

namespace ConsoleTesting {
    class Program {
        static void PrintList(List<IToken> tokens) {
            foreach (IToken t in tokens) {
                Console.Write(t.ToString() + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args) {
            while (true) {
                Console.Write("> ");
                string input = Console.ReadLine();
                var lexer = new Lexer();
                var parser = new Parser();
                var tokens = lexer.Tokenize(input);
                var tree = parser.Next(tokens);
                var result = Executor.Evaluate(tree);
                Console.WriteLine(Math.Round(result, 8));
            }
        }
    }
}