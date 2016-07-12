using System.Collections.Generic;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class SumOfTwoDesign
    {
        private readonly Dictionary<int, int> map = new Dictionary<int, int>();

        public void Add(int number)
        {
            if (map.ContainsKey(number))
            {
                map[number]++;
            }
            else
            {
                map.Add(number, 0);
            }
        }

        public bool Find(int value)
        {
            foreach (var key in map.Keys)
            {
                var missing = value - key;
                if (missing == key)
                {
                    if (map[key] >= 2)
                    {
                        return true;
                    }
                }
                else if (map.ContainsKey(missing))
                {
                    return true;
                }
            }
            return false;
        }
    }
}