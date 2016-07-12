using System.Collections.Generic;

namespace LeetCode.Algorithms.Misc
{
    public class UndirectedGraphNode
    {
        public UndirectedGraphNode(string x)
        {
            Label = x;
            Neighbors = new List<UndirectedGraphNode>();
        }

        public string Label { get; set; }
        public IList<UndirectedGraphNode> Neighbors { get; set; }
    }

    public class CloneGraph
    {
        public UndirectedGraphNode DftClone(UndirectedGraphNode original)
        {
            if (original == null)
            {
                return null;
            }
            var map = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
            return Dft(original, map);
        }

        private UndirectedGraphNode Dft(UndirectedGraphNode node,
            IDictionary<UndirectedGraphNode, UndirectedGraphNode> map)
        {
            if (map.ContainsKey(node))
            {
                return map[node];
            }
            var nodeCopy = new UndirectedGraphNode(node.Label);
            map[node] = nodeCopy;
            foreach (var neighbor in node.Neighbors)
            {
                nodeCopy.Neighbors.Add(Dft(neighbor, map));
            }
            return nodeCopy;
        }

        public UndirectedGraphNode BftClone(UndirectedGraphNode node)
        {
            if (node == null)
            {
                return null;
            }
            var clonedNodes = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
            var queue = new Queue<UndirectedGraphNode>();
            queue.Enqueue(node);

            var clone = new UndirectedGraphNode(node.Label);
            clonedNodes[node] = clone;

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                foreach (var neighbor in current.Neighbors)
                {
                    if (clonedNodes.ContainsKey(neighbor))
                    {
                        clonedNodes[current].Neighbors.Add(clonedNodes[neighbor]);
                    }
                    else
                    {
                        var neighborClone = new UndirectedGraphNode(neighbor.Label);
                        clonedNodes[current].Neighbors.Add(neighborClone);
                        clonedNodes[neighbor] = neighborClone;
                        queue.Enqueue(neighbor);
                    }
                }
            }
            return clone;
        }
    }
}