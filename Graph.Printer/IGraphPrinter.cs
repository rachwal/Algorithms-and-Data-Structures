using DataStructures;

namespace Algorithms.Graph.Printer
{
    public interface IGraphPrinter
    {
        string BreadthFirstTraversal(IGraph graph, string id);
        string DepthFirstTraversal(IGraph graph);
    }
}