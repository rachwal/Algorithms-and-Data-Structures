using System;

namespace ProgramCreek
{
    public class Candy
    {
        public int CalculateMin(int[] ratings)
        {
            if (ratings == null || ratings.Length == 0)
            {
                return 0;
            }

            var candies = new int[ratings.Length];
            candies[0] = 1;

            for (var childId = 1; childId < ratings.Length; childId++)
            {
                if (ratings[childId] > ratings[childId - 1])
                {
                    candies[childId] = candies[childId - 1] + 1;
                }
                else
                {
                    candies[childId] = 1;
                }
            }

            var result = candies[ratings.Length - 1];
            for (var childId = ratings.Length - 2; childId >= 0; childId--)
            {
                var cur = 1;
                if (ratings[childId] > ratings[childId + 1])
                {
                    cur = candies[childId + 1] + 1;
                }
                result += Math.Max(cur, candies[childId]);
                candies[childId] = cur;
            }
            return result;
        }
    }
}