using System.Collections.Generic;
using Syslo.Data_Structures;

namespace Syslo.Pathfinder
{
    public class PathfinderDijkstra
    {
        private int[] distance;
        private int[] route;
        private bool[] visited;

        public List<int> Find(int start, int end, IList<AdjacencyList> graph)
        {
            Initialize(start, graph);

            var current = start;
            while (!visited[end])
            {
                var neighbor = graph[current].Head;
                while (neighbor != null)
                {
                    if (visited[neighbor.Value])
                    {
                        neighbor = neighbor.Next;
                        continue;
                    }

                    var candidate = distance[current] + 1;
                    if (candidate < distance[neighbor.Value])
                    {
                        distance[neighbor.Value] = candidate;
                        route[neighbor.Value] = current;
                    }
                    neighbor = neighbor.Next;
                }

                var nextCandidateDistance = int.MaxValue;
                var nextCandidate = 0;

                for (var node = 0; node < graph.Count; node++)
                {
                    if (visited[node] || distance[node] >= nextCandidateDistance)
                    {
                        continue;
                    }

                    nextCandidate = node;
                    nextCandidateDistance = distance[node];
                }

                if (nextCandidateDistance < int.MaxValue)
                {
                    visited[nextCandidate] = true;
                    current = nextCandidate;
                }
                else
                {
                    visited[end] = true;
                }
            }

            var path = ExtractPath(start, end);

            return path;
        }

        private List<int> ExtractPath(int start, int end)
        {
            var path = new List<int>();
            var step = end;

            path.Add(step);

            while (step != start)
            {
                step = route[step];

                if (step != -1)
                {
                    path.Add(step);
                }
                else
                {
                    return new List<int>();
                }
            }
            return path;
        }

        private void Initialize(int start, IList<AdjacencyList> graph)
        {
            var size = graph.Count;
            visited = new bool[size];
            distance = new int[size];
            route = new int[size];

            for (var node = 0; node < size; node++)
            {
                distance[node] = int.MaxValue;
                visited[node] = false;
                route[node] = -1;
            }

            distance[start] = 0;
            visited[start] = true;
        }
    }
}