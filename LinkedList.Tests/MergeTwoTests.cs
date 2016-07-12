using Algorithms.LinkedList.Printer;
using DataStructures;
using LeetCode.Algorithms.LinkedList.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.LinkedList.Tests
{
    [TestClass]
    public class MergeTwoTests
    {
        [TestMethod]
        public void MergeTwoTestShouldMergeTwoLinkedLists()
        {
            //GIVEN
            var first = new ListNode
            {
                Value = 0,
                Next = new ListNode {Value = 3, Next = new ListNode {Value = 5, Next = null}}
            };
            var second = new ListNode
            {
                Value = 2,
                Next = new ListNode {Value = 4, Next = new ListNode {Value = 8, Next = null}}
            };
            var merger = new MergeTwo();

            //WHEN
            var third = merger.Merge(first, second);

            //THEN
            var printer = new ListPrinter();
            var printedThird = printer.Print(third);
            Assert.AreEqual("0 2 3 4 5 8", printedThird);
        }
    }
}