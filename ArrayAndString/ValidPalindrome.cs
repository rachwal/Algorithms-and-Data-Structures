namespace LeetCode.Algorithms.ArrayAndString
{
    public class ValidPalindrome
    {
        public bool Validate(string input)
        {
            var leftIndex = 0;
            var rightIndex = input.Length - 1;

            while (leftIndex < rightIndex)
            {
                while (leftIndex < rightIndex && !char.IsLetterOrDigit(input[leftIndex]))
                {
                    leftIndex++;
                }
                while (leftIndex < rightIndex && !char.IsLetterOrDigit(input[rightIndex]))
                {
                    leftIndex--;
                }
                if (input[leftIndex] != input[rightIndex])
                {
                    return false;
                }
                leftIndex++;
                rightIndex--;
            }
            return true;
        }
    }
}