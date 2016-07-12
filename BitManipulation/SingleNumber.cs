using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms.BitManipulation
{
    public class SingleNumber
    {
        public int FindWithHashMap(int[] array)
        {
            var map = new Dictionary<int, int>();
            foreach (var entry in array)
            {
                var count = map.ContainsKey(entry) ? map[entry] : 0;
                map[entry] = count + 1;
            }
            foreach (var entry in array)
            {
                if (map[entry] == 1)
                {
                    return entry;
                }
            }
            throw new ArgumentException("No single element");
        }

        public int FindWithHashSet(int[] array)
        {
            var set = new HashSet<int>();
            foreach (var entry in array)
            {
                if (set.Contains(entry))
                {
                    set.Remove(entry);
                }
                else
                {
                    set.Add(entry);
                }
            }
            return set.First();
        }

        public int FindWithXor(int[] array)
        {
            var value = 0;
            foreach (var entry in array)
            {
                value ^= entry;
            }
            return value;
        }

        public int FindSingleNumberAmongTripples(int[] array)
        {
            var count = new int[32];
            var result = 0;

            for (var i = 0; i < 32; i++)
            {
                for (var j = 0; j < array.Length; j++)
                {
                    if (((array[j] >> i) & 1) != 0)
                    {
                        count[i]++;
                    }
                }
                result |= count[i]%3 << i;
            }
            return result;
        }

        public int FindSingleNumberAmongTripplesBitmasks(int[] array)
        {
            var ones = 0;
            var twos = 0;

            for (var i = 0; i < array.Length; i++)
            {
                twos |= ones & array[i];
                ones ^= array[i];

                var threes = ones & twos;
                ones &= ~threes;
                twos &= ~threes;
            }
            return ones;
        }
    }
}