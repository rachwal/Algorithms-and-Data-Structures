using System;

namespace LeetCode.Algorithms.DynamicProgramming
{
    public class MaximumProductSubarray
    {
        public int MaxProduct(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Input cannot be empty.");
            }

            var localMax = array[0];
            var localMin = array[0];
            var globalMax = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                var current = array[i];
                var prevStepMax = localMax;
                var prevStepMin = localMin;

                localMax = Math.Max(Math.Max(current, prevStepMax*current), prevStepMin*current);
                localMin = Math.Min(Math.Min(current, prevStepMax*current), prevStepMin*current);
                globalMax = Math.Max(localMax, globalMax);
            }
            return globalMax;
        }
    }
}