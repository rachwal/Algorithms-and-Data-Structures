using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraph
    {
        Dictionary<string, Dictionary<string, int>> Neighbors { get; }
        Dictionary<string, GraphNode> Nodes { get; }

        void AddEdge(string from, string to, int value);
        void AddNode(GraphNode graphNode);
    }
}