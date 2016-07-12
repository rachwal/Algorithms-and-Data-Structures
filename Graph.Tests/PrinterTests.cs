using Algorithms.Graph.Printer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Graph.Tests
{
    [TestClass]
    public class PrinterTests
    {
        private DataStructures.Graph CreateSimpleGraph()
        {
            var graph = new DataStructures.Graph();
            graph.AddEdge("A", "B", 0);
            graph.AddEdge("A", "C", 0);
            graph.AddEdge("A", "F", 0);
            graph.AddEdge("B", "D", 0);
            graph.AddEdge("C", "G", 0);
            graph.AddEdge("D", "E", 0);
            graph.AddEdge("D", "H", 0);
            return graph;
        }

        [TestMethod]
        public void GraphPrinterShouldPrintNodesWithDfsTraversing()
        {
            //GIVEN
            const string expectedPrintedGraph = "A B D E H C G F";
            var graph = CreateSimpleGraph();
            var printer = new GraphPrinter();

            //WHEN
            var printedGraph = printer.DepthFirstTraversal(graph);

            //THEN
            Assert.AreEqual(expectedPrintedGraph, printedGraph);
        }

        [TestMethod]
        public void GraphPrinterShouldPrintNodesWithBfsTraversingFromANode()
        {
            //GIVEN
            const string expectedPrintedGraph = "A B C F D G E H";
            var graph = CreateSimpleGraph();
            var printer = new GraphPrinter();

            //WHEN
            var printedGraph = printer.BreadthFirstTraversal(graph, "A");

            //THEN
            Assert.AreEqual(expectedPrintedGraph, printedGraph);
        }
    }
}