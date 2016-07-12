using DataStructures;
using DataStructures.Tree.Printer;
using LeetCode.Algorithms.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinaryTree.Tests
{
    [TestClass]
    public class BinaryTreeConverterTests
    {
        [TestMethod]
        public void BinaryTreeConverterShouldConvertSortedArrayToBinarySearchTree()
        {
            //GIVEN
            var array = new[] {2, 3, 4, 5, 6, 10, 15};
            var converter = new BinaryTreeConverter();

            //WHEN
            var tree = converter.Convert(array);

            //THEN
            var printer = new TreePrinter();
            var print1 = printer.BreadthFirstTraversal(tree);
            var print2 = printer.InOrderTraversal(tree);
            Assert.AreEqual("5 3 10 2 4 6 15 # # # # # # # #", print1);
            Assert.AreEqual("2 3 4 5 6 10 15", print2);
        }

        [TestMethod]
        public void BinaryTreeConverterShouldConvertSortedLinkedListToBinarySearchTree()
        {
            //GIVEN
            var list = CreateSampleList();
            var converter = new BinaryTreeConverter();

            //WHEN
            var tree = converter.Convert(list);

            //THEN
            var printer = new TreePrinter();
            var print1 = printer.BreadthFirstTraversal(tree);
            var print2 = printer.InOrderTraversal(tree);
            Assert.AreEqual("5 3 10 2 4 6 15 # # # # # # # #", print1);
            Assert.AreEqual("2 3 4 5 6 10 15", print2);
        }

        private ListNode CreateSampleList()
        {
            var list = new ListNode
            {
                Value = 2,
                Next = new ListNode
                {
                    Value = 3,
                    Next = new ListNode
                    {
                        Value = 4,
                        Next = new ListNode
                        {
                            Value = 5,
                            Next = new ListNode
                            {
                                Value = 6,
                                Next = new ListNode
                                {
                                    Value = 10,
                                    Next = new ListNode(15)
                                }
                            }
                        }
                    }
                }
            };
            return list;
        }
    }
}