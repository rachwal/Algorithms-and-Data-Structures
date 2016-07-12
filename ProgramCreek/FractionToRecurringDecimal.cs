using System.Collections.Generic;
using System.Text;

namespace ProgramCreek
{
    public class FractionToRecurringDecimal
    {
        // b0 = |x|, a0 = [b0]
        // b_{i} = 10·(b_{i-1} - a_{i-1}) 
        // a_{i} = [b_{i}]
        public string GetFraction(int numerator, int denominator, int periodLength)
        {
            if (numerator == 0)
            {
                return "0";
            }

            if (denominator == 0)
            {
                return string.Empty;
            }

            var result = new StringBuilder();

            if (numerator < 0 ^ denominator < 0)
            {
                result.Append("-");
            }

            var value = numerator/denominator;

            result.Append(value);

            var fraction = (numerator%denominator)*10;

            if (fraction == 0)
            {
                return result.ToString();
            }

            result.Append(".");

            var map = new Dictionary<long, int>();
            var count = 0;

            while (fraction != 0)
            {
                if (map.ContainsKey(fraction))
                {
                    count++;
                }

                map[fraction] = result.Length;

                value = fraction/denominator;
                fraction = 10*(fraction%denominator);
                result.Append(value);

                if (map.ContainsKey(fraction) && count == periodLength)
                {
                    var lastNonRecurringIndex = map[fraction];
                    var number = result.ToString();
                    var unique = number.Substring(0, lastNonRecurringIndex);
                    var recurring = number.Substring(lastNonRecurringIndex, number.Length - lastNonRecurringIndex);
                    return unique + "(" + recurring + ")";
                }
            }

            return result.ToString();
        }
    }
}