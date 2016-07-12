using System.Collections.Generic;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class TwoSum
    {
        public int[] FindIds(int[] data, int target)
        {
            var result = new[] {-1, -1};
            var elements = new Dictionary<int, int>();

            for (var index = 0; index < data.Length; index++)
            {
                var current = data[index];
                var difference = target - current;
                if (elements.ContainsKey(difference))
                {
                    result[0] = elements[difference];
                    result[1] = index;
                    return result;
                }
                elements.Add(current, index);
            }
            return result;
        }
    }
}