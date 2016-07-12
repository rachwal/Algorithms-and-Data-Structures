using System.Collections.Generic;
using Syslo.Data_Structures;

namespace Syslo.Pathfinder
{
    public class PathfinderDfs
    {
        private readonly Dictionary<int, int> steps = new Dictionary<int, int>();
        private bool[] visited;

        public List<int> Find(int start, int end, IList<AdjacencyList> graph)
        {
            visited = new bool[graph.Count];
            steps.Clear();

            Dfs(start, end, graph);

            var path = new List<int>();
            var step = end;
            while (step != start)
            {
                path.Add(step);
                step = steps[step];
            }
            path.Add(step);
            return path;
        }

        private void Dfs(int current, int end, IList<AdjacencyList> graph)
        {
            if (current == end)
            {
                return;
            }

            visited[current] = true;

            var neighbor = graph[current].Head;

            while (neighbor != null)
            {
                if (visited[neighbor.Value])
                {
                    neighbor = neighbor.Next;
                    continue;
                }
                steps[neighbor.Value] = current;
                Dfs(neighbor.Value, end, graph);
                neighbor = neighbor.Next;
            }
        }
    }
}