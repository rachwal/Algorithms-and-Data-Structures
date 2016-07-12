using DataStructures;
using DataStructures.Tree.Validator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class ConvertSortedArrayToBinarySearchTreeTests
    {
        [TestMethod]
        public void ConvertSortedArrayToBinarySearchTreeShouldReturnValidBinarySearchTree()
        {
            //GIVEN
            var converter = new ConvertSortedArrayToBinarySearchTree();

            //WHEN
            var tree = converter.SortedArrayToBst(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9});
            var nonBst = new TreeNode(10)
            {
                Left = new TreeNode(3),
                Right = new TreeNode(15)
            };
            nonBst.Left.Right = new TreeNode(2);

            //THEN
            var validator = new TreeValidator();
            Assert.IsTrue(validator.ValidateBst(tree));
            Assert.IsFalse(validator.ValidateBst(nonBst));
        }
    }
}