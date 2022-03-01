using MathsLibrary.Interpreter;

namespace MathsLibrary
{
    /// <summary>
    ///  Responsible for integrating various functions
    /// </summary>
    public static class Integration
    {
        /// <summary>
        /// Integrate function with the trapezium rule
        /// </summary>
        /// <param name="root">The root node of the syntax tree</param>
        /// <param name="a">The lower bound of the range</param>
        /// <param name="b">The upper bound of the range</param>
        /// <param name="n">The number of segments to use</param>
        /// <returns>An approximation for the integral of 'root' between 'a' and 'b'</returns>
        public static double Trapezium(INode root, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = 0;

            for (double i = a + h; i <= b - h; i += h)
                sum += Executor.Evaluate(root, i);
            
            sum *= 2;
            sum += Executor.Evaluate(root, a) + Executor.Evaluate(root, b);
            sum *= h / 2;

            return sum;
        }

        /// <summary>
        /// Integrate function with the mid-ordinate rule
        /// </summary>
        /// <param name="root">The root node of the syntax tree</param>
        /// <param name="a">The lower bound of the range</param>
        /// <param name="b">The upper bound of the range</param>
        /// <param name="n">The number of segments to use</param>
        /// <returns>An approximation for the integral of 'root' between 'a' and 'b'</returns>
        public static double MidOrdinate(INode root, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = 0;

            for (double i = a + h / 2; i <= b - h / 2; i += h)
                sum += Executor.Evaluate(root, i);

            return sum * h;
        }
        
        /// <summary>
        /// Integrate function with Simpson's rule
        /// </summary>
        /// <param name="root">The root node of the syntax tree</param>
        /// <param name="a">The lower bound of the range</param>
        /// <param name="b">The upper bound of the range</param>
        /// <param name="n">The number of segments to use</param>
        /// <returns>An approximation for the integral of 'root' between 'a' and 'b'</returns>
        public static double Simpsons(INode root, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = 0;

            for (double i = a + h; i <= b - h; i += 2*h)
                sum += Executor.Evaluate(root, i) * 4;
            
            for (double i = a + 2*h; i <= b - h * 2; i += 2*h)
                sum += Executor.Evaluate(root, i) * 2;

            sum += Executor.Evaluate(root, a) + Executor.Evaluate(root, b);
            return sum * (h / 3);
        }
    }
}