using DataStructures;
using LeetCode.Algorithms.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinaryTree.Tests
{
    [TestClass]
    public class BinarySearchTreeValidatorTests
    {
        private TreeNode CreateValidBinarySearchTree()
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
                    Right = new TreeNode(17)
                }
            };
            return tree;
        }

        private TreeNode CreateInvalidBinarySearchTree()
        {
            var tree = new TreeNode
            {
                Value = 1,
                Left = new TreeNode
                {
                    Value = 2,
                    Left = new TreeNode(3),
                    Right = new TreeNode(4)
                },
                Right = new TreeNode
                {
                    Value = 5,
                    Left = new TreeNode(6),
                    Right = new TreeNode(7)
                }
            };
            return tree;
        }

        [TestMethod]
        public void BinaryTreeValidatorShouldValidateBinarySearchTreeUsingBruteForce()
        {
            //GIVEN
            var validTree = CreateValidBinarySearchTree();
            var validator = new BinarySearchTreeBruteForceValidator();

            //WHEN
            var isValid = validator.IsValid(validTree);

            //THEN
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void BinaryTreeValidatorShouldInvalidateNotBinarySearchTreeUsingBruteForce()
        {
            //GIVEN
            var invalidBinarySearchTree = CreateInvalidBinarySearchTree();
            var validator = new BinarySearchTreeBruteForceValidator();

            //WHEN
            var isValid = validator.IsValid(invalidBinarySearchTree);

            //THEN
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void BinaryTreeValidatorShouldValidateBinarySearchTreeUsingTopDown()
        {
            //GIVEN
            var validTree = CreateValidBinarySearchTree();
            var validator = new BinarySearchTreeTopDownValidator();

            //WHEN
            var isValid = validator.IsValid(validTree);

            //THEN
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void BinaryTreeValidatorShouldInvalidateNotBinarySearchTreeUsingTopDown()
        {
            //GIVEN
            var invalidBinarySearchTree = CreateInvalidBinarySearchTree();
            var validator = new BinarySearchTreeTopDownValidator();

            //WHEN
            var isValid = validator.IsValid(invalidBinarySearchTree);

            //THEN
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void BinaryTreeValidatorShouldValidateBinarySearchTreeUsingInOrder()
        {
            //GIVEN
            var validTree = CreateValidBinarySearchTree();
            var validator = new BinarySearchTreeInOrderValidator();

            //WHEN
            var isValid = validator.IsValid(validTree);

            //THEN
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void BinaryTreeValidatorShouldInvalidateNotBinarySearchTreeUsingInOrder()
        {
            //GIVEN
            var invalidBinarySearchTree = CreateInvalidBinarySearchTree();
            var validator = new BinarySearchTreeInOrderValidator();

            //WHEN
            var isValid = validator.IsValid(invalidBinarySearchTree);

            //THEN
            Assert.IsFalse(isValid);
        }
    }
}