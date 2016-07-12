using System.Collections.Generic;

namespace Syslo
{
    public class ItemComparer : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            double p1 = x.Value;
            double q1 = x.Weight;
            double p2 = y.Value;
            double q2 = y.Weight;
            return (p2/q2).CompareTo(p1/q1);
        }
    }
}