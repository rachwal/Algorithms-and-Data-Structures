namespace Syslo
{
    public class Fibonacci
    {
        public int Calculate(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            var p = 1;
            var q = 1;

            for (var i = 1; i < n/2; i++)
            {
                p = p + q;
                q = q + p;
            }

            if (n%2 != 0)
            {
                q = q + p;
            }

            return q;
        }

        public int CalculateRecursive(int n)
        {
            if (n < 3)
            {
                return 1;
            }
            return CalculateRecursive(n - 2) + CalculateRecursive(n - 1);
        }

        public int CalculateIterative(int n)
        {
            if (n < 3)
            {
                return 1;
            }

            var p = 1;
            var q = 1;

            for (var i = 2; i < n; i++)
            {
                var temp = p + q;
                q = p;
                p = temp;
            }

            return p;
        }
    }
}