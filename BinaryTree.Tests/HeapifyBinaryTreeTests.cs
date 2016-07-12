using DataStructures;
using DataStructures.Tree.Printer;
using LeetCode.Algorithms.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinaryTree.Tests
{
    [TestClass]
    public class HeapifyBinaryTreeTests
    {
        private TreeNode CreateSampleTree()
        {
            var tree = new TreeNode
            {
                Value = 20,
                Left = new TreeNode
                {
                    Value = 8,
                    Left = new TreeNode {Value = 4},
                    Right = new TreeNode
                    {
                        Value = 12,
                        Left = new TreeNode {Value = 10},
                        Right = new TreeNode {Value = 14}
                    }
                },
                Right = new TreeNode {Value = 22}
            };
            return tree;
        }

        [TestMethod]
        public void BinaryTreeDepthShouldReturnMaxDepthOfBinaryTree()
        {
            //GIVEN
            var tree = CreateSampleTree();
            var heapifier = new HeapifyBinaryTree();

            //WHEN
            var heap = heapifier.Heapify(tree);

            //THEN
            var printer = new TreePrinter();
            var heapPrint = printer.BreadthFirstTraversal(heap);

            Assert.AreEqual("4 8 10 12 14 20 22 # # # # # # # #", heapPrint);
        }
    }
}