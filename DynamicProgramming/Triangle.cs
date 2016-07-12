using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms.DynamicProgramming
{
    public class Triangle
    {
        public int MinimumPathSum(List<List<int>> triangle)
        {
            var total = new int[triangle.Count];
            var lastLevel = triangle.Count - 1;

            for (var i = 0; i < triangle[lastLevel].Count; i++)
            {
                total[i] = triangle[lastLevel][i];
            }

            for (var level = lastLevel - 1; level >= 0; level--)
            {
                for (var element = 0; element < triangle[level + 1].Count - 1; element++)
                {
                    total[element] = triangle[level][element] + Math.Min(total[element], total[element + 1]);
                }
            }

            return total[0];
        }
    }
}