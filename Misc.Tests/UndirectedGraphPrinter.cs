using System.Collections.Generic;
using System.Text;
using LeetCode.Algorithms.Misc;

namespace Algorithms.Misc.Tests
{
    public class UndirectedGraphPrinter
    {
        public string Print(UndirectedGraphNode node)
        {
            if (node == null)
            {
                return string.Empty;
            }
            var printedNodes = new HashSet<UndirectedGraphNode>();
            var result = PrintDft(node, printedNodes);
            return result.TrimEnd();
        }

        private string PrintDft(UndirectedGraphNode node, ISet<UndirectedGraphNode> printedNodes)
        {
            if (printedNodes.Contains(node))
            {
                return string.Empty;
            }

            var result = PrintCurrentNode(node);

            printedNodes.Add(node);

            foreach (var neighbor in node.Neighbors)
            {
                result.Append(PrintDft(neighbor, printedNodes));
            }

            return result.ToString();
        }

        private StringBuilder PrintCurrentNode(UndirectedGraphNode node)
        {
            var result = new StringBuilder();
            result.Append($"{node.Label}: ");

            foreach (var neighbor in node.Neighbors)
            {
                result.Append($"{neighbor.Label} ");
            }
            result.AppendLine();
            return result;
        }
    }
}