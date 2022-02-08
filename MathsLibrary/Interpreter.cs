namespace MathsLibrary
{
    public class Interpreter
    {
        private readonly Lexer _lexer;
        private readonly Parser _parser;

        public Interpreter()
        {
            _lexer = new Lexer();
            _parser = new Parser();
        }

        public double Interpret(string input, double x = 0)
        {
            var tokens = _lexer.Tokenize(input);
            var tree = _parser.Next(tokens);
            var result = Executor.Evaluate(tree, x);

            return result;
        }
    }
}