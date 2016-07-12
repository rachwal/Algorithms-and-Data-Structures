namespace LeetCode.Algorithms.ArrayAndString
{
    public class StringToInteger
    {
        private const int MaxDiv10 = int.MaxValue/10;
        private const int MaxDiv10Rest = int.MaxValue - MaxDiv10;

        public int Convert(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            var leftIndex = 0;
            var rightIndex = input.Length;

            while (leftIndex < rightIndex && char.IsWhiteSpace(input[leftIndex]))
            {
                leftIndex++;
            }

            var sign = 1;
            if (leftIndex < rightIndex && input[leftIndex] == '+')
            {
                leftIndex++;
            }
            else if (leftIndex < rightIndex && input[leftIndex] == '-')
            {
                sign = -1;
                leftIndex++;
            }

            var value = 0;

            while (leftIndex < rightIndex && char.IsDigit(input[leftIndex]))
            {
                var digit = input[leftIndex] - '0';

                if (value > MaxDiv10 || value == MaxDiv10 && digit > MaxDiv10Rest)
                {
                    return sign > 0 ? int.MaxValue : int.MinValue;
                }

                value = 10*value + digit;

                leftIndex++;
            }
            return sign*value;
        }
    }
}