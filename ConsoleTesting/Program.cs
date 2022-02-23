using System;
using System.Collections.Generic;
using MathsLibrary;
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
                
                Console.Write("a = ");
                var a = Executor.Evaluate(parser.Next(lexer.Tokenize(Console.ReadLine())));
                
                Console.Write("b = ");
                var b = Executor.Evaluate(parser.Next(lexer.Tokenize(Console.ReadLine())));
                
                Console.Write("n = ");
                var n = Executor.Evaluate(parser.Next(lexer.Tokenize(Console.ReadLine())));
                
                var tokens = lexer.Tokenize(input);
                var tree = parser.Next(tokens);
                var result = Integration.Simpsons(tree, a, b, (int) n);
                Console.WriteLine(Math.Round(result, 8));
            }
        }
    }
}