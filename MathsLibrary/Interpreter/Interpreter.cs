namespace MathsLibrary.Interpreter
{
    /// <summary>
    /// Container for a lexer and a parser, as well as running the executor
    /// </summary>
    public class Interpreter
    {
        private readonly Lexer _lexer;
        private readonly Parser _parser;

        public Interpreter()
        {
            _lexer = new Lexer();
            _parser = new Parser();
        }
        
        /// <summary>
        /// Turn an input string into a numerical value
        /// </summary>
        /// <param name="input">The string to parse</param>
        /// <param name="x">The value of x to sub in</param>
        /// <returns>The numerical value of the input expression</returns>
        public double Interpret(string input, double x = 0)
        {
            var result = Executor.Evaluate(ToTree(input), x);

            return result;
        }

        /// <summary>
        /// Convert an input to a syntax tree without computing the value
        /// </summary>
        /// <param name="input">The input expression</param>
        /// <returns>The tree based off the input</returns>
        public INode ToTree(string input)
        {
            var tokens = _lexer.Tokenize(input);
            var tree = _parser.Parse(tokens);

            return tree;
        }
    }
}