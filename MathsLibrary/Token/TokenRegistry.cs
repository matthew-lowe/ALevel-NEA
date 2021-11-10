using System.Collections.Generic;

namespace MathsLibrary.Token
{
    public static class TokenRegistry
    {
        private static Dictionary<string, TokenType> _registeredTokens;

        static TokenRegistry()
        {
            _registeredTokens = new Dictionary<string, TokenType>
            {
                {@"\d+.\d?", TokenType.Num},
                {@"\+", TokenType.Add},
                {@"\-", TokenType.Sub},
                {@"\*", TokenType.Mul},
                {@"\/", TokenType.Div}
            };
        }
    }
}