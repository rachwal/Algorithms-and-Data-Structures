using DataStructures;
using LeetCode.Algorithms.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinaryTree.Tests
{
    [TestClass]
    public class BinaryTreeDepthTests
    {
        private TreeNode CreateSampleTree()
        {
            var tree = new TreeNode
            {
                Value = 10,
                Left = new TreeNode
                {
                    Value = 5,
                    Left = new TreeNode(3),
                    Right = new TreeNode(7)
                },
                Right = new TreeNode
                {
                    Value = 15,
                    Left = new TreeNode(12),
                    Right = new TreeNode
                    {
                        Value = 17,
                        Right = new TreeNode(13),
                        Left = new TreeNode(11)
                    }
                }
            };
            return tree;
        }

        [TestMethod]
        public void BinaryTreeDepthShouldReturnMaxDepthOfBinaryTree()
        {
            //GIVEN
            var tree = CreateSampleTree();
            var treeDepth = new BinaryTreeDepth();

            //WHEN
            var maxDepth = treeDepth.GetMax(tree);

            //THEN
            Assert.AreEqual(4, maxDepth);
        }

        [TestMethod]
        public void BinaryTreeDepthShouldReturnMinDepthOfBinaryTreeUsingDft()
        {
            //GIVEN
            var tree = CreateSampleTree();
            var treeDepth = new BinaryTreeDepth();

            //WHEN
            var maxDepth = treeDepth.GetMinDft(tree);

            //THEN
            Assert.AreEqual(3, maxDepth);
        }

        [TestMethod]
        public void BinaryTreeDepthShouldReturnMinDepthOfBinaryTreeUsingBft()
        {
            //GIVEN
            var tree = CreateSampleTree();
            var treeDepth = new BinaryTreeDepth();

            //WHEN
            var maxDepth = treeDepth.GetMinBft(tree);

            //THEN
            Assert.AreEqual(3, maxDepth);
        }
    }
}