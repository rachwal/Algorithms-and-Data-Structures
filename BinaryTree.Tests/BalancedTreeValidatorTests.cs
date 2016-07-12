using DataStructures;
using LeetCode.Algorithms.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinaryTree.Tests
{
    [TestClass]
    public class BalancedTreeValidatorTests
    {
        private TreeNode CreateBalancedTree()
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
        public void BalancedBinaryTreeTopDownValidatorShouldValidateBalancedBinaryTree()
        {
            //GIVEN
            var tree = CreateBalancedTree();
            var validator = new BalancedBinaryTreeTopDownValidator();

            //WHEN
            var isBalanced = validator.IsBalanced(tree);

            //THEN
            Assert.IsTrue(isBalanced);
        }

        [TestMethod]
        public void BalancedBinaryTreeBottomUpValidatorShouldValidateBalancedBinaryTree()
        {
            //GIVEN
            var tree = CreateBalancedTree();
            var validator = new BalancedBinaryTreeBottomUpValidator();

            //WHEN
            var isBalanced = validator.IsBalanced(tree);

            //THEN
            Assert.IsTrue(isBalanced);
        }
    }
}