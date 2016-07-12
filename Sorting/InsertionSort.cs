using System;

namespace Algorithms.Sorting
{
    public class InsertionSort : ISorting
    {
        public void Sort(int[] data)
        {
            for (var element = 0; element < data.Length; element++)
            {
                var current = data[element];

                for (var i = 0; i < element; i++)
                {
                    if (data[i] > current)
                    {
                        Array.Copy(data, i, data, i + 1, element - i);
                        data[i] = current;
                        break;
                    }
                }
            }
        }
    }
}