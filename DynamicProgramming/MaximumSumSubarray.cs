using System;

namespace LeetCode.Algorithms.DynamicProgramming
{
    public class MaximumSumSubarray
    {
        public int MaxSubArrayDivideAndConquer(int[] array)
        {
            return MaxSubArrayDC(array, 0, array.Length - 1);
        }

        private int MaxSubArrayDC(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return int.MinValue;
            }

            var m = (leftIndex + rightIndex)/2;
            var leftPart = MaxSubArrayDC(array, leftIndex, m - 1);
            var rightPart = MaxSubArrayDC(array, m + 1, rightIndex);

            var sum = 0;

            var leftMaxSum = 0;
            for (var i = m - 1; i >= leftIndex; i--)
            {
                sum += array[i];
                leftMaxSum = Math.Max(sum, leftMaxSum);
            }

            sum = 0;
            var rightMaxSum = 0;
            for (var i = m + 1; i <= rightIndex; i++)
            {
                sum += array[i];
                rightMaxSum = Math.Max(sum, rightMaxSum);
            }

            return Math.Max(leftMaxSum + array[m] + rightMaxSum, Math.Max(leftPart, rightPart));
        }

        public int MaxSubArrayDynamicProgramming(int[] array)
        {
            var maxEndingHere = array[0];
            var maxSoFar = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                maxEndingHere = Math.Max(maxEndingHere + array[i], array[i]);
                maxSoFar = Math.Max(maxEndingHere, maxSoFar);
            }

            return maxSoFar;
        }
    }
}