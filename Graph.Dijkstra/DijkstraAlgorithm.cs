using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graph.Dijkstra
{
    public class DijkstraAlgorithm
    {
        private readonly Dictionary<string, int> distance = new Dictionary<string, int>();
        private readonly Dictionary<string, string> route = new Dictionary<string, string>();

        public Stack<string> FindPath(DataStructures.Graph graph, string start, string end)
        {
            var nodeIds = graph.Nodes.Select(n => n.Key).ToList();

            Initialize(start, nodeIds);
            RunDijkstra(graph, nodeIds);
            var steps = ExtractPath(start, end);

            return steps;
        }

        private void Initialize(string start, IEnumerable<string> nodeIds)
        {
            distance.Clear();
            route.Clear();

            foreach (var id in nodeIds)
            {
                distance.Add(id, int.MaxValue);
                route.Add(id, string.Empty);
            }
            distance[start] = 0;
        }

        private void RunDijkstra(DataStructures.Graph graph, ICollection<string> nodeIds)
        {
            var neighbors = graph.Neighbors;
            while (nodeIds.Count > 0)
            {
                var minId = GetMin(nodeIds);
                nodeIds.Remove(minId);

                foreach (var edge in neighbors[minId])
                {
                    Relax(minId, edge.Key, edge.Value);
                }
            }
        }

        private string GetMin(IEnumerable<string> nodeIds)
        {
            var minDist = int.MaxValue;
            var minNode = string.Empty;

            foreach (var nodeId in nodeIds)
            {
                if (distance[nodeId] > minDist) continue;
                minDist = distance[nodeId];
                minNode = nodeId;
            }
            return minNode;
        }

        private void Relax(string currentMinId, string candidateMinId, int cost)
        {
            var currentMin = distance[currentMinId];
            var candidateMin = distance[candidateMinId];

            if (candidateMin <= currentMin + cost)
            {
                return;
            }

            distance[candidateMinId] = currentMin + cost;
            route[candidateMinId] = currentMinId;
        }

        private Stack<string> ExtractPath(string start, string end)
        {
            var steps = new Stack<string>();
            var current = end;

            while (current != start)
            {
                current = route[current];

                if (current == string.Empty || steps.Contains(current))
                {
                    return null;
                }

                steps.Push(current);
            }
            return steps;
        }
    }
}