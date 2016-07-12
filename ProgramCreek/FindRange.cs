using System.Collections.Generic;

namespace ProgramCreek
{
    public class Range
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class FindRange
    {
        public Range Find(IList<IList<int>> input)
        {
            var result = new Range {Min = int.MinValue, Max = int.MaxValue};
            var candidates = new Queue<int>();
            var count = 0;

            while (true)
            {
                for (var listId = 0; listId < input.Count; listId++)
                {
                    if (input[listId].Count == count)
                    {
                        return result;
                    }
                    candidates.Enqueue(input[listId][count]);
                }

                while (candidates.Count > 0)
                {
                    var candidate = candidates.Dequeue();

                    var min = candidate;
                    var max = candidate;

                    for (var listId = 0; listId < input.Count; listId++)
                    {
                        var element = FindClosest(input[listId], candidate);

                        if (element < min)
                        {
                            min = element;
                        }
                        else if (element > max)
                        {
                            max = element;
                        }
                    }

                    if (max - min < result.Max - result.Min || count == 0)
                    {
                        result.Max = max;
                        result.Min = min;
                    }
                }

                count++;
            }
        }

        private int FindClosest(IList<int> input, int element)
        {
            var leftIndex = 0;
            var rightIndex = input.Count - 1;

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