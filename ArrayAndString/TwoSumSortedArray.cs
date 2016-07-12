namespace LeetCode.Algorithms.ArrayAndString
{
    public class TwoSumSortedArray
    {
        public int[] FindIndexes(int[] data, int target)
        {
            var result = new[] {-1, -1};
            var leftIndex = 0;
            var rightInex = data.Length - 1;

            while (leftIndex < rightInex)
            {
                var value = data[leftIndex] + data[rightInex];

                if (value < target)
                {
                    leftIndex++;
                }
                else if (value > target)
                {
                    rightInex--;
                }
                else
                {
                    result[0] = leftIndex;
                    result[1] = rightInex;
                    return result;
                }
            }
            return result;
        }
    }
}