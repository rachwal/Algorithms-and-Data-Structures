namespace Algorithms.Sorting
{
    public class QuickSortSwapping : ISorting
    {
        public void Sort(int[] data)
        {
            QuickSortRecursive(data, 0, data.Length);
        }

        private void QuickSortRecursive(int[] data, int start, int length)
        {
            if (length < 2)
            {
                return;
            }

            var pivotIndex = start + length/2;
            var pivotValue = data[pivotIndex];
            var end = start + length;

            var current = start;

            Swap(data, pivotIndex, --end);

            while (current < end)
            {
                if (data[current] < pivotValue)
                {
                    current++;
                }
                else
                {
                    Swap(data, current, --end);
                }
            }

            Swap(data, end, start + length - 1);

            var leftLength = end - start;
            var rightLength = length - leftLength - 1;

            if (leftLength > 1)
            {
                QuickSortRecursive(data, start, leftLength);
            }

            if (rightLength > 1)
            {
                QuickSortRecursive(data, end + 1, rightLength);
            }
        }

        private void Swap(int[] data, int first, int second)
        {
            var temp = data[first];
            data[first] = data[second];
            data[second] = temp;
        }
    }
}