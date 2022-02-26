using System;
using MathsLibrary.Interpreter;

namespace MathsLibrary 
{
    public static class Differentiation
    {
        private static readonly double _h = 10e-7;
        public static double Differentiate(INode root, double x) {
            // By multiplying by x^2 and sqrting the entire expression,
            // the value will not become too small for the double type to
            // accurately store
            root.Print();
            System.Console.WriteLine("X:", x);
            Console.WriteLine("h = " + _h.ToString());

            double fx = Executor.Evaluate(root, x);
            Console.WriteLine("fx = " + fx.ToString());

            double fxph = Executor.Evaluate(root, x + _h);
            Console.WriteLine("fxph = " + fxph.ToString());

            System.Console.WriteLine("F(x):", fx);
            
            return (fxph - fx) / _h;
        }
    }
}