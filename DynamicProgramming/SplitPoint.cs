namespace LeetCode.Algorithms.DynamicProgramming
{
    public class SplitPoint
    {
        public int SplitIndex(int[] input)
        {
            var result = new int[input.Length];
            result[0] = input[0];

            var max = int.MinValue;
            var min = int.MaxValue;
            var maxIndex = 0;
            var minIndex = 0;

            for (var i = 1; i < input.Length; i++)
            {
                result[i] = result[i - 1] + input[i];

                if (result[i] < min)
                {
                    min = result[i];
                    minIndex = i;
                }
                else if (result[i] > max)
                {
                    max = result[i];
                    maxIndex = i;
                }
            }

            if (max > 0 && max < input.Length - 1)
            {
                return maxIndex;
            }

            return minIndex;
        }
    }
}