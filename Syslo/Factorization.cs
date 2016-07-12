using System.Collections.Generic;

namespace Syslo
{
    public class Factorization
    {
        public IList<int> Find(int n)
        {
            var factors = new List<int>();
            var d = FindDivisors(n);
            var i = 0;

            while (n > 1)
            {
                var q = n/d[i];
                var r = n%d[i];

                if (r == 0)
                {
                    factors.Add(d[i]);
                    n = q;
                }
                else
                {
                    if (q > d[i])
                    {
                        i = i + 1;
                    }
                    else
                    {
                        factors.Add(n);
                        n = 1;
                    }
                }
            }

            return factors;
        }

        private List<int> FindDivisors(int n)
        {
            var divisors = new List<int>();

            for (var i = 2; i < n/2; i++)
            {
                if (n%i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors;
        }
    }
}