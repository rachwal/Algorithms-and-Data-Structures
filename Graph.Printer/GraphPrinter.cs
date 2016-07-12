using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace Algorithms.Graph.Printer
{
    public class GraphPrinter : IGraphPrinter
    {
        public string BreadthFirstTraversal(IGraph graph, string id)
        {
            var print = new StringBuilder();
            var visited = new Dictionary<string, bool>();
            var queue = new Queue<string>();
            queue.Enqueue(id);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (visited.ContainsKey(current))
                {
                    continue;
                }

                print.Append($"{current} ");

                visited.Add(current, true);

                var neighbors = graph.Neighbors[current];
                foreach (var neighbor in neighbors)
                {
                    queue.Enqueue(neighbor.Key);
                }
            }

            var result = print.ToString();
            return result.TrimEnd();
        }

        public string DepthFirstTraversal(IGraph graph)
        {
            var print = new StringBuilder();
            var visited = new Dictionary<string, bool>();

            foreach (var entry in graph.Nodes)
            {
                print.Append(PrintDFS(graph, entry.Key, visited));
            }
            var result = print.ToString();
            return result.TrimEnd();
        }

        private string PrintDFS(IGraph graph, string id, IDictionary<string, bool> visited)
        {
            if (visited.ContainsKey(id))
            {
                return string.Empty;
            }
            var print = new StringBuilder();

            print.Append($"{id} ");
            visited.Add(id, true);

            var neighbor = graph.Neighbors[id];
            foreach (var entry in neighbor)
            {
                print.Append(PrintDFS(graph, entry.Key, visited));
            }
            return print.ToString();
        }
    }
}