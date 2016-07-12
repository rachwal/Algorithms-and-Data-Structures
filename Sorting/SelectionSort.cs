using System;

namespace Algorithms.Sorting
{
    public class SelectionSort : ISorting
    {
        public void Sort(int[] data)
        {
            for (var i = 0; i < data.Length; i++)
            {
                Swap(data, i, FindMinimumIndex(data, i));
            }
        }

        private void Swap(int[] data, int first, int second)
        {
            if (first == second)
            {
                return;
            }

            var tmp = data[first];
            data[first] = data[second];
            data[second] = tmp;
        }

        public void StableSort(int[] data)
        {
            for (var i = 0; i < data.Length; i++)
            {
                Insert(data, i, FindMinimumIndex(data, i));
            }
        }

        private void Insert(int[] data, int start, int index)
        {
            if (index > start)
            {
                var tmp = data[index];
                Array.Copy(data, start, data, start + 1, index - start);
                data[start] = tmp;
            }
        }

        private int FindMinimumIndex(int[] data, int start)
        {
            var minimumIndex = start;
            for (var i = start + 1; i < data.Length; i++)
            {
                if (data[i] < data[minimumIndex])
                {
                    minimumIndex = i;
                }
            }
            return minimumIndex;
        }
    }
}