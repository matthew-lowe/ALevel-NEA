using MathsLibrary.Interpreter;

namespace MathsLibrary
{
    public static class Integration
    {
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

        public static double MidOrdinate(INode root, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = 0;

            for (double i = a + h / 2; i <= b - h / 2; i += h)
                sum += Executor.Evaluate(root, i);

            return sum * h;
        }

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