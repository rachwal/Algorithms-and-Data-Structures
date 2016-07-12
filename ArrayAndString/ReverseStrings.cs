using System.Text;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class ReverseStrings
    {
        public string Reverse(string text)
        {
            var builder = new StringBuilder();

            var rightIndex = text.Length - 1;
            for (var leftIndex = text.Length - 1; leftIndex >= 0; leftIndex--)
            {
                if (text[leftIndex] == ' ')
                {
                    rightIndex = leftIndex;
                }
                else if (leftIndex == 0 || text[leftIndex - 1] == ' ')
                {
                    var word = text.Substring(leftIndex, rightIndex - leftIndex);
                    builder.Append($"{word} ");
                }
            }

            var result = builder.ToString();
            return result.TrimEnd();
        }

        public unsafe void ReverseInPlaceUnsafe(string text)
        {
            var length = text.Length;
            var rightIndex = length;
            fixed (char* p = text)
            {
                ReverseT(p, 0, length - 1);
                for (var leftIndex = length - 1; leftIndex >= 0; leftIndex--)
                {
                    if (p[leftIndex] == ' ')
                    {
                        rightIndex = leftIndex;
                    }
                    else if (leftIndex == 0 || p[leftIndex - 1] == ' ')
                    {
                        ReverseT(p, leftIndex, rightIndex - 1);
                    }
                }
            }
        }

        private unsafe void ReverseT(char* input, int start, int end)
        {
            while (start < end)
            {
                var temp = input[start];
                input[start] = input[end];
                input[end] = temp;
                start++;
                end--;
            }
        }

        public void ReverseInPlace(char[] input)
        {
            Reverse(input, 0, input.Length - 1);

            var rightIndex = input.Length;

            for (var leftIndex = input.Length - 1; leftIndex >= 0; leftIndex--)
            {
                if (input[leftIndex] == ' ')
                {
                    rightIndex = leftIndex;
                }
                else if (leftIndex == 0 || input[leftIndex - 1] == ' ')
                {
                    Reverse(input, leftIndex, rightIndex - 1);
                }
            }
        }

        private void Reverse(char[] input, int begin, int end)
        {
            while (begin < end)
            {
                var temp = input[begin];
                input[begin] = input[end];
                input[end] = temp;
                begin++;
                end--;
            }
        }
    }
}