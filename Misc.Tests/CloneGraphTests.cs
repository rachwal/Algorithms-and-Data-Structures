using LeetCode.Algorithms.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Misc.Tests
{
    [TestClass]
    public class CloneGraphTests
    {
        private UndirectedGraphNode CreateSampleGraph()
        {
            var nodeA = new UndirectedGraphNode("A");
            var nodeB = new UndirectedGraphNode("B");
            var nodeC = new UndirectedGraphNode("C");
            var nodeD = new UndirectedGraphNode("D");
            var nodeE = new UndirectedGraphNode("E");
            var nodeF = new UndirectedGraphNode("F");
            var nodeG = new UndirectedGraphNode("G");
            var nodeH = new UndirectedGraphNode("H");

            nodeA.Neighbors.Add(nodeB);
            nodeA.Neighbors.Add(nodeC);
            nodeA.Neighbors.Add(nodeF);
            nodeB.Neighbors.Add(nodeD);
            nodeC.Neighbors.Add(nodeD);
            nodeC.Neighbors.Add(nodeG);
            nodeD.Neighbors.Add(nodeE);
            nodeD.Neighbors.Add(nodeH);
            nodeF.Neighbors.Add(nodeA);
            nodeG.Neighbors.Add(nodeH);
            return nodeA;
        }

        [TestMethod]
        public void CloneGraphShouldReturnNullDftCloneWhenGetsNullGraph()
        {
            //GIVEN
            UndirectedGraphNode graph = null;
            var cloneGraph = new CloneGraph();

            //WHEN
            var clone = cloneGraph.DftClone(graph);

            //THEN
            Assert.AreEqual(graph, clone);
        }

        [TestMethod]
        public void CloneGraphShouldReturnDftClonedWhenGetsNotNullGraphToClone()
        {
            //GIVEN
            var graph = CreateSampleGraph();
            var printer = new UndirectedGraphPrinter();
            var graphPrint = printer.Print(graph);
            var cloner = new CloneGraph();

            //WHEN
            var clone = cloner.DftClone(graph);
            graph.Neighbors.Clear();

            //THEN
            var clonePrint = printer.Print(clone);
            Assert.AreEqual(graphPrint, clonePrint);
        }

        [TestMethod]
        public void CloneGraphShouldReturnNullBftCloneWhenGetsNullGraph()
        {
            //GIVEN
            UndirectedGraphNode graph = null;
            var cloneGraph = new CloneGraph();

            //WHEN
            var clone = cloneGraph.BftClone(graph);

            //THEN
            Assert.AreEqual(graph, clone);
        }

        [TestMethod]
        public void CloneGraphShouldReturnBftClonedWhenGetsNotNullGraphToClone()
        {
            //GIVEN
            var graph = CreateSampleGraph();
            var printer = new UndirectedGraphPrinter();
            var graphPrint = printer.Print(graph);
            var cloner = new CloneGraph();

            //WHEN
            var clone = cloner.BftClone(graph);
            graph.Neighbors.Clear();

            //THEN
            var clonePrint = printer.Print(clone);
            Assert.AreEqual(graphPrint, clonePrint);
        }
    }
}