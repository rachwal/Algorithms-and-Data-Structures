namespace ProgramCreek
{
    public class MergeKSortedArrays
    {
        public int[] Merge(int[][] arrays)
        {
            if (arrays == null)
            {
                return null;
            }

            var end = arrays.Length - 1;

            while (end > 0)
            {
                var begin = 0;
                while (begin < end)
                {
                    arrays[begin] = Merge2(arrays[begin], arrays[end]);
                    begin++;
                    end--;
                }
            }
            return arrays[0];
        }

        private int[] Merge2(int[] first, int[] second)
        {
            if (first == null || second == null)
            {
                return null;
            }
            var result = new int[first.Length + second.Length];
            var firstIndex = 0;
            var secondIndex = 0;
            while (firstIndex < first.Length && secondIndex < second.Length)
            {
                if (first[firstIndex] < second[secondIndex])
                {
                    result[firstIndex + secondIndex] = first[firstIndex];
                    firstIndex++;
                }
                else
                {
                    result[firstIndex + secondIndex] = second[secondIndex];
                    secondIndex++;
                }
            }

            while (firstIndex < first.Length)
            {
                result[firstIndex + secondIndex] = first[firstIndex];
                firstIndex++;
            }

            while (secondIndex < second.Length)
            {
                result[firstIndex + secondIndex] = second[secondIndex];
                secondIndex++;
            }

            return result;
        }
    }
}