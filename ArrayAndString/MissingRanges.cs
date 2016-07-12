using System.Collections.Generic;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class MissingRanges
    {
        public List<string> Find(int[] values, int begin, int end)
        {
            var ranges = new List<string>();

            var previous = begin - 1;

            for (var i = 0; i <= values.Length; i++)
            {
                var current = i == values.Length ? end + 1 : values[i];
                if (current - previous >= 2)
                {
                    ranges.Add(GetRange(previous + 1, current - 1));
                }
                previous = current;
            }
            return ranges;
        }

        private string GetRange(int from, int to)
        {
            return from == to ? from.ToString() : from + "->" + to;
        }
    }
}