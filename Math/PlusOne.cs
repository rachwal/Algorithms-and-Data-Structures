using System.Collections.Generic;

namespace LeetCode.Algorithms.Math
{
    public class PlusOne
    {
        public void AddOne(List<int> digits)
        {
            for (var i = digits.Count - 1; i >= 0; i--)
            {
                var digit = digits[i];
                if (digit < 9)
                {
                    digits[i]++;
                    return;
                }
                digits[i] = 0;
            }
            digits.Add(0);
            digits[0] = 1;
        }
    }
}