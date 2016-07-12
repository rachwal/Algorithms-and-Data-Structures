using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.Dijkstra
{
    public class PathPrinter
    {
        public string Print<T>(Stack<T> path)
        {
            if (path == null)
            {
                return string.Empty;
            }
            var print = new StringBuilder();

            while (path.Count > 1)
            {
                print.Append($"{path.Pop()} ");
            }

            if (path.Count == 1)
            {
                print.Append($"{path.Pop()}");
            }

            return print.ToString();
        }
    }
}