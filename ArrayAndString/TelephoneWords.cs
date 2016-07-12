using System.Collections.Generic;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class TelephoneWords
    {
        private char[] result;
        IList<string> words = new List<string>();

        public IEnumerable<string> PrintWords(int[] number)
        {
            result = new char[number.Length];
            words.Clear();
            PrintWords(number, 0);
            return words;
        }

        private void PrintWords(int[] number, int curDigit)
        {
            if (curDigit == number.Length)
            {
                words.Add(new string(result));
                return;
            }

            for (var i = 1; i <= 3; ++i)
            {
                result[curDigit] = GetCharKey(number[curDigit], i);

                PrintWords(number, curDigit + 1);

                if (number[curDigit] == 0 || number[curDigit] == 1)
                {
                    return;
                }
            }
        }

        private char GetCharKey(int number, int letterIndex)
        {
            var telephone = new Dictionary<int, Dictionary<int, char>>
            {
                [2] = new Dictionary<int, char> {[1] = 'A', [2] = 'B', [3] = 'C'},
                [3] = new Dictionary<int, char> {[1] = 'D', [2] = 'E', [3] = 'F'},
                [4] = new Dictionary<int, char> {[1] = 'G', [2] = 'H', [3] = 'I'},
                [5] = new Dictionary<int, char> {[1] = 'J', [2] = 'K', [3] = 'L'},
                [6] = new Dictionary<int, char> {[1] = 'M', [2] = 'N', [3] = 'O'},
                [7] = new Dictionary<int, char> {[1] = 'P', [2] = 'R', [3] = 'S'},
                [8] = new Dictionary<int, char> {[1] = 'T', [2] = 'U', [3] = 'V'},
                [9] = new Dictionary<int, char> {[1] = 'W', [2] = 'X', [3] = 'Y'},
            };

            if (telephone.ContainsKey(number))
            {
                return telephone[number][letterIndex];
            }
            return number.ToString()[0];
        }
    }
}