namespace LeetCode.Algorithms.BinarySearch
{
    public class FindMinimumInSortedRotatedArrayWithDuplicates
    {
        public int FindMin(int[] data)
        {
            if (data.Length == 0)
            {
                return -1;
            }

            var leftIndex = 0;
            var rightIndex = data.Length - 1;

            while (leftIndex < rightIndex && data[leftIndex] >= data[rightIndex])
            {
                var middleIndex = (leftIndex + rightIndex)/2;
                if (data[middleIndex] > data[rightIndex])
                {
                    leftIndex = middleIndex + 1;
                }
                else if (data[middleIndex] < data[leftIndex])
                {
                    rightIndex = middleIndex;
                }
                else
                {
                    leftIndex = leftIndex + 1;
                }
            }

            return data[leftIndex];
        }
    }
}