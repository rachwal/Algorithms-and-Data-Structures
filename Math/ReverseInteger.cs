namespace LeetCode.Algorithms.Math
{
    public class ReverseInteger
    {
        private const int MaxDiv10 = int.MaxValue/10;
        private const int MaxDiv10Rest = int.MaxValue - MaxDiv10;

        public int Reverse(int x)
        {
            var value = 0;
            while (x != 0)
            {
                var digit = x%10;
                if (System.Math.Abs(value) > MaxDiv10 || (System.Math.Abs(value) == MaxDiv10 && digit > MaxDiv10Rest))
                {
                    return 0;
                }
                value = 10*value + digit;
                x /= 10;
            }
            return value;
        }
    }
}