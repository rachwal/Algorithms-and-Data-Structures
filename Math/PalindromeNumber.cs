namespace LeetCode.Algorithms.Math
{
    public class PalindromeNumber
    {
        public bool IsValid(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var div = 1;

            while (x/div >= 10)
            {
                div *= 10;
            }

            while (x != 0)
            {
                var l = x/div;
                var r = x%10;
                if (l != r)
                {
                    return false;
                }
                x = x%div/10;
                div /= 100;
            }

            return true;
        }
    }
}