using System;
using System.Collections.Generic;
using MathsLibrary.Interpreter;
using MathsLibrary.Interpreter.Token;

namespace ConsoleTesting {
    class Program {
        private static void PrintList(IEnumerable<IToken> tokens) {
            foreach (var t in tokens) {
                Console.Write(t.ToString() + " ");
            }
            Console.WriteLine();
        }

        private static void Main(string[] args) {
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