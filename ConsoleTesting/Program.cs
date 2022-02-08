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
            var lexer = new Lexer();
            var parser = new Parser();
            
            while (true) {
                Console.Write("> ");
                var input = Console.ReadLine();
                
                Console.Write("x = ");
                var x = Executor.Evaluate(parser.Next(lexer.Tokenize(Console.ReadLine())));
                
                var tokens = lexer.Tokenize(input);
                var tree = parser.Next(tokens);
                var result = Executor.Evaluate(tree, x);
                Console.WriteLine(Math.Round(result, 8));
            }
        }
    }
}