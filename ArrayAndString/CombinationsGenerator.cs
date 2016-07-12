using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class CombinationsGenerator
    {
        public IList<string> GenerateBit(string input)
        {
            var combinations = new List<string>();
            var combination = new StringBuilder();

            var size = Math.Pow(2, input.Length);

            for (var candidate = 1; candidate < size; candidate++)
            {
                combination.Clear();
                for (var element = 0; element < input.Length; element++)
                {
                    if ((candidate & (1 << element)) != 0)
                    {
                        combination.Append(input[element]);
                    }
                }
                combinations.Add(combination.ToString());
            }
            return combinations;
        }

        public IEnumerable<string> Generate(string input)
        {
            var used = new HashSet<char>();
            var current = new StringBuilder();
            var combinations = new HashSet<string>();

            for (var size = 1; size < input.Length + 1; size++)
            {
                Generate(input, size, current, combinations, used);
            }
            return combinations;
        }

        private void Generate(string input, int size, StringBuilder current, ISet<string> combinations, ISet<char> used)
        {
            if (current.Length == size)
            {
                combinations.Add(current.ToString());
            }

            for (var i = 0; i < input.Length; i++)
            {
                if (used.Contains(input[i]))
                {
                    return;
                }

                current.Append(input[i]);
                used.Add(input[i]);

                Generate(input, size, current, combinations, used);

                current.Remove(current.Length - 1, 1);
                used.Remove(input[i]);
            }
        }
    }
}