namespace LeetCode.Algorithms.ArrayAndString
{
    public class ArrayRotator
    {
        public void Rotate(int[] array, int k)
        {
            if (k == 0)
            {
                return;
            }

            if (k < 0)
            {
                Rotate(array, array.Length + k);
                return;
            }

            if (k >= array.Length)
            {
                var point = k%array.Length;
                Rotate(array, point);
                return;
            }

            Reverse(array, 0, array.Length - 1);
            Reverse(array, 0, k - 1);
            Reverse(array, k, array.Length - 1);
        }

        private void Reverse(int[] array, int left, int right)
        {
            while (left < right)
            {
                var tmp = array[left];
                array[left] = array[right];
                array[right] = tmp;
                left++;
                right--;
            }
        }
    }
}