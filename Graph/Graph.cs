using System.Collections.Generic;

namespace DataStructures
{
    public class Graph : IGraph
    {
        public Graph()
        {
            Nodes = new Dictionary<string, GraphNode>();
            Neighbors = new Dictionary<string, Dictionary<string, int>>();
        }

        public Dictionary<string, Dictionary<string, int>> Neighbors { get; }
        public Dictionary<string, GraphNode> Nodes { get; }

        public void AddNode(GraphNode node)
        {
            if (Nodes.ContainsKey(node.Id))
            {
                return;
            }

            var id = node.Id;
            Nodes.Add(id, node);
            Neighbors.Add(id, new Dictionary<string, int>());
        }

        public void AddEdge(string from, string to, int value)
        {
            if (!Nodes.ContainsKey(from))
            {
                AddNode(new GraphNode(from));
            }

            if (!Nodes.ContainsKey(to))
            {
                AddNode(new GraphNode(to));
            }

            var fromNodeNeighbours = Neighbors[from];
            if (!fromNodeNeighbours.ContainsKey(to))
            {
                fromNodeNeighbours.Add(to, value);
            }
        }

        public void RemoveNode(string id)
        {
            if (!Nodes.ContainsKey(id))
            {
                return;
            }

            Nodes.Remove(id);
            Neighbors.Remove(id);

            foreach (var element in Neighbors)
            {
                if (!element.Value.ContainsKey(id))
                {
                    continue;
                }
                element.Value.Remove(id);
            }
        }

        public void RemoveEdge(string from, string to)
        {
            if (!Nodes.ContainsKey(from))
            {
                return;
            }

            var neighbours = Neighbors[from];
            if (!neighbours.ContainsKey(to))
            {
                return;
            }

            neighbours.Remove(to);
        }
    }
}