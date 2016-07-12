using DataStructures.Tree.Printer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tree.Tests
{
    [TestClass]
    public class PrinterTests
    {
        private TreeNode CreateSimpleTree()
        {
            var n6 = new TreeNode(6);
            var n5 = new TreeNode(5);
            var n4 = new TreeNode(4);
            var n2 = new TreeNode(2);
            var n3 = new TreeNode(3);
            var n15 = new TreeNode(15);

            var tree = new TreeNode(10)
            {
                Left = n3,
                Right = n15
            };

            n3.Left = n2;
            n3.Right = n4;
            n4.Right = n5;
            n5.Right = n6;
            return tree;
        }

        [TestMethod]
        public void TreePrinterShouldPrintNodesWithDfTraversing()
        {
            //GIVEN
            var expectedPrintedTree = "10 3 2 4 5 6 15";
            var tree = CreateSimpleTree();
            var printer = new TreePrinter();

            //WHEN
            var printedTree = printer.DepthFirstTraversal(tree);

            //THEN
            Assert.AreEqual(expectedPrintedTree, printedTree);
        }

        [TestMethod]
        public void TreePrinterShouldPrintNodesWithBfTraversing()
        {
            //GIVEN
            var expectedPrintedTree = "10 3 15 2 4 # # # # # 5 # 6 # #";
            var tree = CreateSimpleTree();
            var printer = new TreePrinter();

            //WHEN
            var printedTree = printer.BreadthFirstTraversal(tree);

            //THEN
            Assert.AreEqual(expectedPrintedTree, printedTree);
        }
    }
}