using System;
using System.Collections.Generic;

namespace ProgramCreek
{
    public class LongestSubstringWhichContainsTwoUniqueCharacters
    {
        public int FindLongestSubstringLength(string input)
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

                if (substringCharacters.Count <= 2)
                {
                    continue;
                }

                maxLength = Math.Max(maxLength, inputIndex - substringStartIndex);

                while (substringCharacters.Count > 2)
                {
                    var lastCharacterInSubstring = input[substringStartIndex];
                    var count = substringCharacters[lastCharacterInSubstring];

                    if (count > 1)
                    {
                        substringCharacters[lastCharacterInSubstring] = count - 1;
                    }
                    else
                    {
                        substringCharacters.Remove(lastCharacterInSubstring);
                    }

                    substringStartIndex++;
                }
            }

            maxLength = Math.Max(maxLength, input.Length - substringStartIndex);
            return maxLength;
        }
    }
}