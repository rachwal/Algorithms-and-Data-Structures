using System.Collections.Generic;

namespace LeetCode.Algorithms.DynamicProgramming
{
    public class ClimbingStairs
    {
        private readonly Dictionary<int, int> cache = new Dictionary<int, int>();

        public int GetDistinctWaysNumber(int numberOfSteps)
        {
            var p = 1;
            var q = 1;

            for (var i = 2; i <= numberOfSteps; i++)
            {
                var temp = q;
                q += p;
                p = temp;
            }

            return q;
        }

        public int GetDistinctWays(int numberOfSteps)
        {
            if (cache.ContainsKey(numberOfSteps))
            {
                return cache[numberOfSteps];
            }

            var numberOfWays = GetDistinctWaysNumber(numberOfSteps);
            cache.Add(numberOfSteps, numberOfWays);

            return numberOfWays;
        }
    }
}