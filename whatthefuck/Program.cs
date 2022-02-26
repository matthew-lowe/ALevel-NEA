using System;
using MathsLibrary;
using MathsLibrary.Interpreter;

var interpreter = new Interpreter();

Console.Write("> ");
var input = Console.ReadLine();

Console.Write("x = ");
var input_x = Console.ReadLine();

var x = interpreter.Interpret(input_x);
var exp = interpreter.ToTree(input);

Console.WriteLine(Differentiation.Differentiate(exp, x));
