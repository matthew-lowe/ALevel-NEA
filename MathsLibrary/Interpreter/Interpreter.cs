namespace MathsLibrary.Interpreter
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
            var result = Executor.Evaluate(ToTree(input), x);

            return result;
        }

        public INode ToTree(string input)
        {
            var tokens = _lexer.Tokenize(input);
            var tree = _parser.Next(tokens);

            return tree;
        }
        
    }
}