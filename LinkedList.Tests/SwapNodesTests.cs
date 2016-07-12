using Algorithms.LinkedList.Printer;
using DataStructures;
using LeetCode.Algorithms.LinkedList.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.LinkedList.Tests
{
    [TestClass]
    public class SwapNodesTests
    {
        [TestMethod]
        public void SwapNodesShouldSwapNodesInPairs()
        {
            //GIVEN
            var list = new ListNode
            {
                Value = 1,
                Next = new ListNode {Value = 2, Next = new ListNode {Value = 3, Next = new ListNode(4)}}
            };
            var swapNodes = new SwapNodes();

            //WHEN
            var result = swapNodes.Swap(list);

            //THEN
            var printer = new ListPrinter();
            var printedResult = printer.Print(result);
            Assert.AreEqual("2 1 4 3", printedResult);
        }
    }
}