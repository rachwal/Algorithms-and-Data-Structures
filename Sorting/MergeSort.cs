using System;

namespace Algorithms.Sorting
{
    public class MergeSort : ISorting
    {
        public void Sort(int[] data)
        {
            MergeSortSimple(data);
        }

        private void MergeSortSimple(int[] data)
        {
            if (data.Length < 2)
            {
                return;
            }

            var mid = data.Length/2;
            var left = new int[mid];
            var right = new int[data.Length - mid];

            Array.Copy(data, 0, left, 0, left.Length);
            Array.Copy(data, mid, right, 0, right.Length);

            MergeSortSimple(left);
            MergeSortSimple(right);

            Merge(data, left, right);
        }

        private void Merge(int[] destination, int[] left, int[] right)
        {
            var dataIndex = 0;
            var leftIndex = 0;
            var rightIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    destination[dataIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    destination[dataIndex] = right[rightIndex];
                    rightIndex++;
                }
                dataIndex++;
            }

            while (leftIndex < left.Length)
            {
                destination[dataIndex] = left[leftIndex];
                leftIndex++;
                dataIndex++;
            }

            while (rightIndex < right.Length)
            {
                destination[dataIndex] = right[rightIndex];
                rightIndex++;
                dataIndex++;
            }
        }
    }
}