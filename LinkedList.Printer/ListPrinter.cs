using System.Text;
using DataStructures;

namespace Algorithms.LinkedList.Printer
{
    public class ListPrinter
    {
        public string Print(ListNode node)
        {
            var result = new StringBuilder();
            while (node != null)
            {
                result.Append($"{node.Value} ");
                node = node.Next;
            }
            return result.ToString().TrimEnd();
        }
    }
}