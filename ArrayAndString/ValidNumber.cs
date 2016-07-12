namespace LeetCode.Algorithms.ArrayAndString
{
    public class ValidNumber
    {
        public bool Validate(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var isValid = false;
            var leftIndex = 0;
            var rightIndex = input.Length;

            while (leftIndex < rightIndex && char.IsWhiteSpace(input[leftIndex]))
            {
                leftIndex++;
            }

            if (leftIndex < rightIndex && (input[leftIndex] == '+' || input[leftIndex] == '-'))
            {
                leftIndex++;
            }

            while (leftIndex < rightIndex && char.IsDigit(input[leftIndex]))
            {
                leftIndex++;
                isValid = true;
            }

            if (leftIndex < rightIndex && input[leftIndex] == '.')
            {
                leftIndex++;

                while (leftIndex < rightIndex && char.IsDigit(input[leftIndex]))
                {
                    leftIndex++;
                }
            }

            while (leftIndex < rightIndex && char.IsWhiteSpace(input[leftIndex]))
            {
                leftIndex++;
            }

            return isValid && leftIndex == rightIndex;
        }
    }
}