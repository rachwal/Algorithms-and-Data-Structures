using DataStructures;
using DataStructures.Tree.Printer;
using LeetCode.Algorithms.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinaryTree.Tests
{
    [TestClass]
    public class UpsideDownBinaryTreeTests
    {
        private TreeNode CreateSampleTree()
        {
            var tree = new TreeNode
            {
                Value = 1,
                Left = new TreeNode
                {
                    Value = 2,
                    Left = new TreeNode(4),
                    Right = new TreeNode(5)
                },
                Right = new TreeNode
                {
                    Value = 3,
                }
            };
            return tree;
        }

        [TestMethod]
        public void UpsideDownBinaryTreeShouldConvertBinaryTreeUsingTopDownApproach()
        {
            //GIVEN
            var tree = CreateSampleTree();
            var converter = new UpsideDownBinaryTree();

            //WHEN
            var convertedTree = converter.ConvertTopDown(tree);

            //THEN
            var printer = new TreePrinter();
            var print1 = printer.BreadthFirstTraversal(convertedTree);
            var print2 = printer.InOrderTraversal(convertedTree);
            Assert.AreEqual("4 5 2 # # 3 1 # # # #", print1);
            Assert.AreEqual("5 4 3 2 1", print2);
        }

        [TestMethod]
        public void UpsideDownBinaryTreeShouldConvertBinaryTreeUsingBottomUpApproach()
        {
            //GIVEN
            var tree = CreateSampleTree();
            var converter = new UpsideDownBinaryTree();

            //WHEN
            var convertedTree = converter.ConvertBottomUp(tree);

            //THEN
            var printer = new TreePrinter();
            var print1 = printer.BreadthFirstTraversal(convertedTree);
            var print2 = printer.InOrderTraversal(convertedTree);
            Assert.AreEqual("4 5 2 # # 3 1 # # # #", print1);
            Assert.AreEqual("5 4 3 2 1", print2);
        }
    }
}