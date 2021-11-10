using System;
using System.Collections.Generic;
using MathsLibrary.Token;

namespace MathsLibrary
{
    public class Lexer
    {
        public List<IToken> Tokenize(string input)
        {
            var tokens = new List<IToken>();

            foreach (char c in input)
            {
                AddToken(tokens, c);
            }

            tokens = MergeDecimals(tokens);

            return tokens;
        }

        private void AddToken(List<IToken> tokens, char c)
        {
            TokenType type = GetTokenType(c);

            switch (type)
            {
                case TokenType.Nil:
                    return;
                case TokenType.Num:
                    double value = char.GetNumericValue(c);

                    if (tokens.Count >= 1 && tokens[^1].Type == TokenType.Num)
                    {
                        ((IToken<double>) tokens[^1]).Value *= 10;
                        ((IToken<double>) tokens[^1]).Value += value;
                    }
                    else
                        tokens.Add(new Token<double>(TokenType.Num, value));
					
                    break;
                default:
                    tokens.Add(new Token.Token(type));
                    break;
            }
        }

        private List<IToken> MergeDecimals(List<IToken> tokens)
        {
            // Blank token is required at the start so fucky wucky stuff doesn't happen
            List<IToken> newList = new List<IToken> {new Token.Token(TokenType.Nil), tokens[0]};

            for (int i = 1; i < tokens.Count; i++) {
                if (tokens[i].Type.Equals(TokenType.Dot)) {
                    double oldValue = ((Token<double>) tokens[i - 1]).Value;
                    double nextValue = ((Token<double>) tokens[i + 1]).Value;
                    int numDigits = (int) Math.Floor(Math.Log10(nextValue) + 1);
                    newList[^1] = new Token<double>(TokenType.Num, oldValue + nextValue / Math.Pow(10, numDigits));
                    
                    i += 1;
                } else {
                    newList.Add(tokens[i]);
                }
            }
            
            // Remove the blank token added at the start
            newList.RemoveAt(0);

            return newList;
        }

        private TokenType GetTokenType(char c)
        {
            if (char.IsDigit(c))
                return TokenType.Num;

            return c switch
            {
                '+' => TokenType.Add,
                '-' => TokenType.Sub,
                '*' => TokenType.Mul,
                '/' => TokenType.Mul,
                '.' => TokenType.Dot,
                _ => TokenType.Nil
            };
        }
    }
}