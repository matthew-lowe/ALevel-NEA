
   
using System.Collections.Generic;
using System.Linq;
using System;
using MathsLibrary.Token;

namespace MathsLibrary {
	public class Parser {
		public INode Next(List<IToken> input) {
			if (!VerifyBrackets(input))
				throw new Exception("fucking moron");

			return TokensToAst(input);
		}

		private static readonly TokenType[] tokenPriority = {TokenType.Add, TokenType.Sub, TokenType.Mul, TokenType.Div, TokenType.Exp, TokenType.Num};

		private static INode TokensToAst(List<IToken> input) {
			// Sometimes with functions, funky stuff happens
			// Could come up with a fix, but deadlines :c
			if (input.Count == 0)
				return null;

			List<IToken> tokens = RemoveOuterBrackets(input);

			int? rootIndexNullable = FindRoot(tokens);
			if (rootIndexNullable == null) {
				System.Console.WriteLine("Could not find token! Fuck!");
				return null;
			}

			int rootIndex = (int) rootIndexNullable;
			var root = NodeFactory.FromToken(tokens[rootIndex]);

			// If the root is a digit, just return it. A number has no children
			if (root.Type.Equals(TokenType.Num))
				return root;

			INode right = TokensToAst(tokens.Skip(rootIndex + 1).Take(tokens.Count - rootIndex).ToList());
			INode left = TokensToAst(tokens.Skip(0).Take(rootIndex).ToList());

			root.Left = left;
			root.Right = right;

			return root;
		}

		private static int? FindRoot(List<IToken> tokens) {
			for (int i = 0; i < tokenPriority.Length; i++) {
				TokenType type = tokenPriority[i];

				for (int j = 0; j < tokens.Count; j++) 
					if (tokens[j].Type.Equals(type) && !IsInBrackets(tokens, j))
						return j;
			}

			// There is no root that we can find :(
			return null;
		}

		private static bool IsInBrackets(List<IToken> tokens, int index) {
			int lCount = 0;
			int rCount = 0;

			// If the token is not inside a bracket pair, the number of left brackets and right brackets before the token
			// should be equal. 
			for (int i = 0; i < index; i++) {
				if (tokens[i].Type.Equals(TokenType.LBracket))
					lCount += 1;
				if (tokens[i].Type.Equals(TokenType.RBracket))
					rCount += 1;
			}

			return lCount != rCount;
		}

		private static bool VerifyBrackets(List<IToken> tokens) {
			int count = 0;

			foreach (IToken token in tokens) {
				if (token.Type.Equals(TokenType.LBracket))
					count += 1;
				else if (token.Type.Equals(TokenType.RBracket))
					count -= 1;
			}

			return count == 0;
		}
		
		private static bool ShouldRemoveBrackets(List<IToken> tokens) {
			int count = 1;

			for (int i = 1; i < tokens.Count; i++) {
				if (tokens[i].Type.Equals(TokenType.RBracket))
					count -= 1;
				else if (tokens[i].Type.Equals(TokenType.RBracket))
					count += 1;
				
				if (count == 0 && i != tokens.Count - 1) return false;
			}

			return true;
		}

		private static List<IToken> RemoveOuterBrackets(List<IToken> tokens) {
			tokens = RemoveWhitespace(tokens);
			if (tokens[0].Type.Equals(TokenType.LBracket) && tokens[tokens.Count - 1].Type.Equals(TokenType.RBracket) && ShouldRemoveBrackets(tokens))
				return tokens.Skip(1).Take(tokens.Count - 2).ToList();
			return tokens;
		}

		/// <summary>
		/// Remove all whitespace tokens
		/// </summary>
		/// <param name="tokens">The input list of tokens</param>
		/// <returns>The input list with any whitespace tokens removed</returns>
		private static List<IToken> RemoveWhitespace(List<IToken> tokens) {
			var newList = new List<IToken>();

			foreach (IToken t in tokens)
				if (t.Type != TokenType.Nil)
					newList.Add(t);

			return newList;
		}

		/// Print a list of tokens (useful for debugging)
		public static void PrintList(List<IToken> list) {
			Console.Write("[");
			foreach(IToken t in list)
				System.Console.Write(t.ToString() + ", ");
			Console.Write("]\n");
		}
	}
}