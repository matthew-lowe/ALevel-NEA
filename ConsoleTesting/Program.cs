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
                Console.WriteLine("Input:", input);
                
                Console.Write("x = ");
                var input_x = Console.ReadLine();
                System.Console.WriteLine("x=", input_x);
                var x = Executor.Evaluate(parser.Next(lexer.Tokenize(input_x)));

                var tokens = lexer.Tokenize(input);
                var tree = parser.Next(tokens);
                var result = Differentiation.Differentiate(tree, 4);
                Console.WriteLine(Math.Round(result, 8));
            }
        }
    }
}