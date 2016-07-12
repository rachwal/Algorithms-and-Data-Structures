namespace LeetCode.Algorithms.BinarySearch
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] input, int element)
        {
            var leftIndex = 0;
            var rightIndex = input.Length - 1;
            while (leftIndex < rightIndex)
            {
                var middle = (leftIndex + rightIndex)/2;
                if (input[middle] < element)
                {
                    leftIndex = middle + 1;
                }
                else
                {
                    rightIndex = middle;
                }
            }
            return input[leftIndex] < element ? leftIndex + 1 : leftIndex;
        }
    }
}