using System.Collections.Generic;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class ListPrinter
    {
        public List<string> Generate(string element)
        {
            return PrintNonOverlapping(element, string.Empty, new List<string>());
        }

        private List<string> PrintNonOverlapping(string element, string prefix, List<string> list)
        {
            list.Add(prefix + "(" + element + ")");

            for (var i = 1; i < element.Length; i++)
            {
                var newPrefix = prefix + "(" + element.Substring(0, i) + ")";
                PrintNonOverlapping(element.Substring(i, element.Length - i), newPrefix, list);
            }
            return list;
        }
    }
}