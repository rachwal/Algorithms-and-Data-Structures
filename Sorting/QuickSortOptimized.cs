namespace Algorithms.Sorting
{
    public class QuickSortOptimized : ISorting
    {
        public void Sort(int[] data)
        {
            QuickSortRecursive(data, 0, data.Length - 1);
        }

        private void QuickSortRecursive(int[] data, int left, int right)
        {
            var middle = (left + right)/2;
            var pivotValue = data[middle];
            var leftIndex = left;
            var rightIndex = right;

            while (leftIndex <= rightIndex)
            {
                while (data[leftIndex] < pivotValue)
                {
                    leftIndex++;
                }

                while (data[rightIndex] > pivotValue)
                {
                    rightIndex--;
                }

                if (leftIndex <= rightIndex)
                {
                    Swap(data, leftIndex, rightIndex);
                    leftIndex++;
                    rightIndex--;
                }
            }

            if (left < rightIndex)
            {
                QuickSortRecursive(data, left, rightIndex);
            }

            if (right > leftIndex)
            {
                QuickSortRecursive(data, leftIndex, right);
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