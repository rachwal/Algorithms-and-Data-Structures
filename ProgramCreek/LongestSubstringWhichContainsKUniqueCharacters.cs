using System;
using System.Collections.Generic;

namespace ProgramCreek
{
    public class LongestSubstringWhichContainsKUniqueCharacters
    {
        public int FindLongestSubstringLength(string input, int k)
        {
            var maxLength = 0;
            var substringCharacters = new Dictionary<char, int>();
            var substringStartIndex = 0;

            for (var inputIndex = 0; inputIndex < input.Length; inputIndex++)
            {
                var currentCharacter = input[inputIndex];
                if (substringCharacters.ContainsKey(currentCharacter))
                {
                    substringCharacters[currentCharacter]++;
                }
                else
                {
                    substringCharacters.Add(currentCharacter, 1);
                }

                if (substringCharacters.Count <= k)
                {
                    continue;
                }

                maxLength = Math.Max(maxLength, inputIndex - substringStartIndex);

                while (substringCharacters.Count > k)
                {
                    var substringLastCharacter = input[substringStartIndex];
                    var count = substringCharacters[substringLastCharacter];
                    if (count > 1)
                    {
                        substringCharacters[substringLastCharacter] = count - 1;
                    }
                    else
                    {
                        substringCharacters.Remove(substringLastCharacter);
                    }
                    substringStartIndex++;
                }
            }
            maxLength = Math.Max(maxLength, input.Length - substringStartIndex);
            return maxLength;
        }
    }
}