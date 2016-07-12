using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class PermutationsGenerator
    {
        public IEnumerable<string> Generate(string input)
        {
            var used = new bool[input.Length];
            var current = new StringBuilder();
            var permutations = new HashSet<string>();
            return Generate(input, current, permutations, used);
        }

        private IEnumerable<string> Generate(string input, StringBuilder current, ISet<string> permuations,
            IList<bool> used)
        {
            if (current.Length == input.Length)
            {
                permuations.Add(current.ToString());
            }

            for (var i = 0; i < input.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }

                current.Append(input[i]);
                used[i] = true;

                Generate(input, current, permuations, used);

                current.Remove(current.Length - 1, 1);
                used[i] = false;
            }
            return permuations;
        }
    }
}