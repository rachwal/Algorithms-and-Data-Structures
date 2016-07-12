using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms.Misc
{
    public class RomanConverter
    {
        private readonly Dictionary<char, int> map = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        private readonly string[] symbols = new[]
        {
            "M", "CM", "D", "CD",
            "C", "XC", "L", "XL",
            "X", "IX", "V", "IV",
            "I"
        };

        private readonly int[] values = new[]
        {
            1000, 900, 500, 400,
            100, 90, 50, 40,
            10, 9, 5, 4,
            1
        };

        public string Convert(int number)
        {
            var result = new StringBuilder();
            var i = 0;
            while (number > 0)
            {
                var k = number/values[i];
                for (var j = 0; j < k; j++)
                {
                    result.Append(symbols[i]);
                    number -= values[i];
                }
                i++;
            }
            return result.ToString();
        }

        public int Convert(string number)
        {
            var previous = 0;
            var total = 0;
            foreach (var character in number)
            {
                var current = map[character];
                total += current > previous ? current - 2*previous : current;
                previous = current;
            }
            return total;
        }
    }
}