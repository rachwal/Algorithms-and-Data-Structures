namespace Syslo
{
    public class Gcd
    {
        public int CalculateWithModulo(int n, int m)
        {
            while (m > 0 && n > 0)
            {
                if (m > n)
                {
                    m = m%n;
                }
                else
                {
                    n = n%m;
                }
            }
            return m + n;
        }

        public int CalculateWithSubstract(int n, int m)
        {
            while (m > 0 && n > 0)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }
            return m + n;
        }

        public int CalculateRecursive(int n, int m)
        {
            if (m > n)
            {
                return CalculateRecursive(m, n);
            }

            if (m == 0)
            {
                return n;
            }

            return CalculateRecursive(n%m, m);
        }

        public int CalculateWithEquation(int n, int m)
        {
            var a = n;
            var aa = m;
            var x = 0;
            var xx = 1;
            var y = 1;
            var yy = 0;

            while (aa != 0)
            {
                var q = a/aa;
                var z = aa;
                aa = a - q*aa;
                a = z;
                z = xx;
                xx = x - q*xx;
                x = z;
                z = yy;
                yy = y - q*yy;
                y = z;
            }
            return a;
        }
    }
}