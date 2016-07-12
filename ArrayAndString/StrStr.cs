namespace LeetCode.Algorithms.ArrayAndString
{
    public class StrStr
    {
        public int Find(string haystack, string needle)
        {
            for (var i = 0;; i++)
            {
                for (var j = 0;; j++)
                {
                    if (j == needle.Length)
                    {
                        return i;
                    }

                    if (i + j == haystack.Length)
                    {
                        return -1;
                    }

                    if (needle[j] != haystack[i + j])
                    {
                        break;
                    }
                }
            }
        }
    }
}