using System.Collections.Generic;

namespace LeetCode.Algorithms.Stack
{
    public class ParenthesisValidator
    {
        private readonly Dictionary<char, char> validSymbols;

        public ParenthesisValidator(Dictionary<char, char> validSymbolsDictionary)
        {
            validSymbols = validSymbolsDictionary;
        }

        public bool IsValid(string input)
        {
            var stack = new Stack<char>();
            foreach (var character in input)
            {
                if (validSymbols.ContainsKey(character))
                {
                    stack.Push(character);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var symbol = stack.Pop();
                    if (validSymbols[symbol] != character)
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}