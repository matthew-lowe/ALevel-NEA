using MathsLibrary.Token;

namespace MathsLibrary {
    public class Executor {
        public static double Evaluate(INode root) {
            return ((Node<double>) Executor.Reduce(root)).Value;
        } 

        public static INode Reduce(INode root) {
                var left = root.Left is null ? null : (Node<double>) Executor.Reduce(root.Left);
                var right = root.Right is null ? null : (Node<double>) Executor.Reduce(root.Right);
            switch (root.Type) {
                case TokenType.Add:
                    return NodeCalculator.Add(left, right);
                case TokenType.Sub:
                    return NodeCalculator.Sub(left, right);
                case TokenType.Mul:
                    return NodeCalculator.Mul(left, right);
                case TokenType.Div:
                    return NodeCalculator.Div(left, right);
                case TokenType.Exp:
                    return NodeCalculator.Exp(left, right);
                default:
                    return root;
            }
        }
    }
}