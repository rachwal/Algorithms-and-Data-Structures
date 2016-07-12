namespace LeetCode.Algorithms.ArrayAndString
{
    public class WildCardMatch
    {
        public bool IsMatch(string haystack, string needle)
        {
            for (var haystackIndex = 0;; haystackIndex++)
            {
                for (var needleIndex = 0;; needleIndex++)
                {
                    if (needleIndex == needle.Length)
                    {
                        return true;
                    }

                    if (haystackIndex + needleIndex == haystack.Length)
                    {
                        return false;
                    }

                    if (needle[needleIndex] == '*')
                    {
                        continue;
                    }

                    if (needle[needleIndex] != haystack[haystackIndex + needleIndex])
                    {
                        break;
                    }
                }
            }
        }
    }
}