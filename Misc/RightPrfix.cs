using System;

namespace LeetCode.Algorithms.Misc
{
    public class RightPrfix
    {
        public int GetCount(int[] input)
        {
            var max = int.MinValue;

            for (var i = 0; i < input.Length; i++)
            {
                var value = 0;
                for (var j = i; j < input.Length; j++)
                {
                    if (input[j] > input[i])
                    {
                        value++;
                    }
                }
                max = Math.Max(max, value);
            }

            return max;
        }
    }
}