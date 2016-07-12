using System.Collections.Generic;

namespace Syslo
{
    public class Dijkstra
    {
        private int[] distance;
        private int[] route;
        private bool[] visited;

        public IList<int> Solve(int start, int finish, int?[][] graph)
        {
            Initialize(graph.Length, start);

            RunDijkstra(start, finish, graph);

            var path = ExtractPath(start, finish);
            return path;
        }

        private void Initialize(int size, int start)
        {
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

        private void RunDijkstra(int start, int finish, int?[][] graph)
        {
            var current = start;
            while (!visited[finish])
            {
                for (var node = 0; node < graph.Length; node++)
                {
                    if (graph[current][node] == null || visited[node])
                    {
                        continue;
                    }

                    var candidate = distance[current] + graph[current][node];
                    if (candidate < distance[node])
                    {
                        distance[node] = candidate.Value;
                        route[node] = current;
                    }
                }

                var nextCandidateDistance = int.MaxValue;
                var nextCandidate = 0;

                for (var node = 0; node < graph.Length; node++)
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
                    visited[finish] = true;
                }
            }
        }

        private IList<int> ExtractPath(int start, int finish)
        {
            var path = new List<int>();
            var step = finish;

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
                    return null;
                }
            }
            return path;
        }
    }
}