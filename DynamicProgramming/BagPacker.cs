using System;

namespace LeetCode.Algorithms.DynamicProgramming
{
    public class InfinityException : Exception
    {
        public InfinityException() : base("Max value is infinity!")
        {
        }
    }

    public class CakeType
    {
        public CakeType(int weight, int value)
        {
            Weight = weight;
            Value = value;
        }

        public int Weight { get; set; }
        public int Value { get; set; }
    }

    public class BagPacker
    {
        public long MaxBagValue(CakeType[] types, int maxCapacity)
        {
            var dpValues = new long[maxCapacity + 1];

            for (var capacity = 0; capacity <= maxCapacity; capacity++)
            {
                long selectedValue = 0;

                foreach (var type in types)
                {
                    if (type.Weight == 0 && type.Value != 0)
                    {
                        throw new InfinityException();
                    }

                    if (type.Weight > capacity)
                    {
                        continue;
                    }

                    var currentValue = type.Value + dpValues[capacity - type.Weight];

                    selectedValue = Math.Max(currentValue, selectedValue);
                }

                dpValues[capacity] = selectedValue;
            }

            return dpValues[maxCapacity];
        }
    }
}