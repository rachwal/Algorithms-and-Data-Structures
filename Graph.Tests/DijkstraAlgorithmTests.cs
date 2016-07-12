using System.Collections.Generic;
using System.Linq;
using Algorithms.Graph.Dijkstra;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Graph.Tests
{
    [TestClass]
    public class DijkstraAlgorithmTests
    {
        private DataStructures.Graph CreateSimpleGraph()
        {
            var graph = new DataStructures.Graph();
            graph.AddEdge("A", "B", 1);
            graph.AddEdge("A", "C", 2);
            graph.AddEdge("A", "F", 3);
            graph.AddEdge("B", "D", 4);
            graph.AddEdge("C", "G", 5);
            graph.AddEdge("C", "D", 1);
            graph.AddEdge("G", "H", 1);
            graph.AddEdge("D", "E", 6);
            graph.AddEdge("D", "H", 7);
            graph.AddEdge("F", "A", 3);
            return graph;
        }

        [TestMethod]
        public void DijkstraAlgorithmShouldFindPathWhenExists()
        {
            //GIVEN
            var expectedPath = new Stack<string>(new[] {"D", "C", "A", "F"});
            var graph = CreateSimpleGraph();
            var algorithm = new DijkstraAlgorithm();

            //WHEN
            var path = algorithm.FindPath(graph, "F", "E");

            //THEN
            Assert.IsTrue(expectedPath.SequenceEqual(path));
        }

        [TestMethod]
        public void DijkstraAlgorithmShouldReturnNullWhenPathDoesNotExists()
        {
            //GIVEN
            Stack<string> expectedPath = null;
            var graph = CreateSimpleGraph();
            var algorithm = new DijkstraAlgorithm();

            //WHEN
            var path = algorithm.FindPath(graph, "E", "F");

            //THEN
            Assert.AreEqual(expectedPath, path);
        }
    }
}