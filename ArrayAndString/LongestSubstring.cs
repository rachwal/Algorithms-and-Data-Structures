using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class LongestSubstring
    {
        public string GetLongestSubstring(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            var characters = new Dictionary<char, int>();

            var max = 0;
            var substring = string.Empty;

            for (var i = 0; i < input.Length; i++)
            {
                var current = input[i];

                if (!characters.ContainsKey(current))
                {
                    characters.Add(current, i);
                    continue;
                }

                var leftIndex = characters[current];

                var currentLength = i - leftIndex;
                if (currentLength > max)
                {
                    max = currentLength;
                    substring = input.Substring(leftIndex, max);
                }
                characters.Clear();
                characters.Add(current, i);
            }
            return substring;
        }

        public int GetLengthWithoutRepeatingCharacters(string input)
        {
            var set = new HashSet<char>();
            var max = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var current = input[i];
                if (!set.Contains(current))
                {
                    set.Add(current);
                    continue;
                }

                max = Math.Max(max, set.Count);

                set.Remove(current);
            }
            return max;
        }

        public int GetLengthWithAtMostTwoDistinctCharacters(string input)
        {
            var characters = new Dictionary<char, int>();
            var leftIndex = 0;
            var max = 0;
            var length = 0;

            for (var rightIndex = 0; rightIndex < input.Length; rightIndex++)
            {
                var current = input[rightIndex];
                if (characters.ContainsKey(current))
                {
                    length++;
                    continue;
                }

                if (characters.Count < 2)
                {
                    characters.Add(current, 1);
                    length++;
                    continue;
                }

                max = Math.Max(max, length);
                var lastCharacter = input[leftIndex];
                leftIndex = rightIndex - characters[lastCharacter];
                characters.Remove(lastCharacter);

                length = rightIndex - leftIndex;
            }
            return max;
        }

        public string GetLongestPalindromicSubstring(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            var leftIndex = 0;
            var rightIndex = 0;

            for (var i = 0; i < text.Length; i++)
            {
                var len1 = ExpandAroundCenter(text, i, i);
                var len2 = ExpandAroundCenter(text, i, i + 1);

                var length = Math.Max(len1, len2);

                if (length <= rightIndex - leftIndex)
                {
                    continue;
                }

                leftIndex = i - (length - 1)/2;
                rightIndex = i + length/2;
            }

            return text.Substring(leftIndex, rightIndex - leftIndex + 1);
        }

        private int ExpandAroundCenter(string text, int left, int right)
        {
            while (left >= 0 && right < text.Length && text[left] == text[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}