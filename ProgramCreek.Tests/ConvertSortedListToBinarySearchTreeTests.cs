using DataStructures;
using DataStructures.Tree.Printer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class ConvertSortedListToBinarySearchTreeTests
    {
        [TestMethod]
        public void ConvertSortedListToBinarySearchTreeShouldReturnConvertedTree()
        {
            //GIVEN
            var linkedList = new ListNode(1)
            {
                Next = new ListNode(2)
                {
                    Next = new ListNode(3)
                    {
                        Next = new ListNode(4)
                        {
                            Next = new ListNode(5)
                            {
                                Next = new ListNode(6)
                            }
                        }
                    }
                }
            };

            var converter = new ConvertSortedListToBinarySearchTree();

            //WHEN
            var tree = converter.Convert(linkedList);

            //THEN
            var printer = new TreePrinter();
            var printTreeInOrder = printer.InOrderTraversal(tree);
            var printTreeDfs = printer.DepthFirstTraversal(tree);
            var printTreeBfs = printer.BreadthFirstTraversal(tree);

            Assert.AreEqual("1 2 3 4 5 6", printTreeInOrder);
            Assert.AreEqual("3 1 2 5 4 6", printTreeDfs);
            Assert.AreEqual("3 1 5 # 2 4 6 # # # # # #", printTreeBfs);
        }
    }
}