using Algorithms.LinkedList.Printer;
using DataStructures;
using DataStructures.Tree.Printer;
using LeetCode.Algorithms.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinaryTree.Tests
{
    [TestClass]
    public class ConverterTests
    {
        private TreeNode CreateSampleTree()
        {
            var tree = new TreeNode
            {
                Value = 6,
                Left = new TreeNode
                {
                    Value = 4,
                    Left = new TreeNode
                    {
                        Value = 2,
                        Left = new TreeNode {Value = 1},
                        Right = new TreeNode {Value = 3}
                    },
                    Right = new TreeNode {Value = 5}
                },
                Right = new TreeNode {Value = 7}
            };
            return tree;
        }

        [TestMethod]
        public void ListConverterShouldConvertBinarySearchTreeToSortedLinkedList()
        {
            //GIVEN
            var tree = CreateSampleTree();
            var listConverter = new ListConverter();


            //WHEN
            var linkedList = listConverter.Convert(tree);

            //THEN
            var printer = new ListPrinter();
            var printedList = printer.Print(linkedList);
            Assert.AreEqual("1 2 3 4 5 6 7", printedList);
        }

        [TestMethod]
        public void TreeConverterShouldConvertSortedLinkedListToBinarySearchTree()
        {
            //GIVEN
            var linkedList = new ListNode
            {
                Value = 1,
                Next =
                    new ListNode
                    {
                        Value = 2,
                        Next =
                            new ListNode
                            {
                                Value = 3,
                                Next =
                                    new ListNode
                                    {
                                        Value = 4,
                                        Next =
                                            new ListNode
                                            {
                                                Value = 5,
                                                Next = new ListNode {Value = 6, Next = new ListNode {Value = 7}}
                                            }
                                    }
                            }
                    }
            };
            var treeConverter = new TreeConverter();

            //WHEN
            var balancedTree = treeConverter.Convert(linkedList);

            //THEN
            var printer = new TreePrinter();
            var printedList = printer.BreadthFirstTraversal(balancedTree);
            Assert.AreEqual("4 2 6 1 3 5 7 # # # # # # # #", printedList);
        }
    }
}