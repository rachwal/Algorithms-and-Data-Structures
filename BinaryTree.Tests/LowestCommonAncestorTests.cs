using DataStructures;
using LeetCode.Algorithms.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinaryTree.Tests
{
    [TestClass]
    public class LowestCommonAncestorTests
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
            var finder = new LowestCommonAncestor();

            //WHEN
            var twenty = finder.Find(tree, 10, 22);
            var eight = finder.Find(tree, 4, 12);
            var twelve = finder.Find(tree, 10, 14);

            //THEN
            Assert.AreEqual(20, twenty);
            Assert.AreEqual(8, eight);
            Assert.AreEqual(12, twelve);
        }
    }
}