using System;

namespace Algorithms.Sorting
{
    public class QuickSortBasic : ISorting
    {
        public void Sort(int[] data)
        {
            QuickSortRecursive(data);
        }

        private int[] QuickSortRecursive(int[] data)
        {
            if (data.Length < 2)
            {
                return data;
            }

            var pivotIndex = data.Length/2;
            var pivotValue = data[pivotIndex];

            var leftCount = 0;

            for (var i = 0; i < data.Length; i++)
            {
                if (data[i] < pivotValue)
                {
                    leftCount++;
                }
            }

            var left = new int[leftCount];
            var right = new int[data.Length - leftCount - 1];

            var l = 0;
            var r = 0;

            for (var i = 0; i < data.Length; i++)
            {
                if (i == pivotIndex)
                {
                    continue;
                }

                var value = data[i];

                if (value < pivotValue)
                {
                    left[l++] = value;
                }
                else
                {
                    right[r++] = value;
                }
            }

            left = QuickSortRecursive(left);
            right = QuickSortRecursive(right);

            Array.Copy(left, 0, data, 0, left.Length);
            data[left.Length] = pivotValue;
            Array.Copy(right, 0, data, left.Length + 1, right.Length);

            return data;
        }
    }
}