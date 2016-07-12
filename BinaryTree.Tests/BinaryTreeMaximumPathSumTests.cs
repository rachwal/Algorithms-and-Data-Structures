using DataStructures;
using LeetCode.Algorithms.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinaryTree.Tests
{
    [TestClass]
    public class BinaryTreeMaximumPathSumTests
    {
        private TreeNode CreateSampleTree()
        {
            var tree = new TreeNode
            {
                Value = 1,
                Left = new TreeNode
                {
                    Value = 2,
                    Left = new TreeNode(2),
                    Right = new TreeNode(3)
                },
                Right = new TreeNode
                {
                    Value = 4,
                }
            };
            return tree;
        }

        [TestMethod]
        public void BinaryTreeMaximumPathSumShouldRetrunPathWithMaximumSum()
        {
            //GIVEN
            var tree = CreateSampleTree();
            var search = new BinaryTreeMaximumPathSum();

            //WHEN
            var maxSum = search.FindMax(tree);

            //THEN
            Assert.AreEqual(10, maxSum);
        }
    }
}