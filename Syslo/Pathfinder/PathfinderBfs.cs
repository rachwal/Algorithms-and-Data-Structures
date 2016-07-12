using System.Collections.Generic;
using Syslo.Data_Structures;

namespace Syslo.Pathfinder
{
    public class PathfinderBfs
    {
        public List<int> Find(int start, int end, IList<AdjacencyList> graph)
        {
            var visited = new HashSet<int>();
            var queue = new Queue<int>();
            queue.Enqueue(end);

            var steps = new Stack<Step>();

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current == start)
                {
                    break;
                }

                var node = graph[current].Head;

                while (node != null)
                {
                    if (visited.Contains(node.Value))
                    {
                        node = node.Next;
                        continue;
                    }

                    steps.Push(new Step {Current = node.Value, Prev = current});

                    if (node.Value == start)
                    {
                        var path = new List<int>();
                        var id = start;
                        while (steps.Count > 0)
                        {
                            var step = steps.Pop();
                            if (id != step.Current)
                            {
                                continue;
                            }
                            path.Add(id);
                            id = step.Prev;
                        }
                        path.Add(end);
                        return path;
                    }

                    queue.Enqueue(node.Value);
                    node = node.Next;
                }
                visited.Add(current);
            }
            return null;
        }

        private class Step
        {
            public int Current { get; set; }
            public int Prev { get; set; }
        }
    }
}