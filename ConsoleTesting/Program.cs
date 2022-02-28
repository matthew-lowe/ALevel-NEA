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
            var interpreter = new Interpreter();

            while (true)
            {
                Console.Write("> ");
                var input = Console.ReadLine();

                Console.Write("x = ");
                var input_x = Console.ReadLine();

                var x = interpreter.Interpret(input_x);
                var exp = interpreter.ToTree(input);
                exp.Print();
                Console.WriteLine(interpreter.Interpret(input, x));
            }
        }
    }
}