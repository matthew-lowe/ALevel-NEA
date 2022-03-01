using MathsLibrary.Interpreter;

namespace MathsLibrary 
{
    /// <summary>
    /// Responsible for turning a function into
    /// </summary>
    public static class Differentiation
    {
        private static readonly double _h = 10e-7;
        public static double Differentiate(INode root, double x) {
            double fx = Executor.Evaluate(root, x);
            double fxph = Executor.Evaluate(root, x + _h);
            
            return (fxph - fx) / _h;
        }
    }
}