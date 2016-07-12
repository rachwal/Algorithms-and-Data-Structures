using Algorithms.LinkedList.Printer;
using DataStructures;
using LeetCode.Algorithms.LinkedList.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.LinkedList.Tests
{
    [TestClass]
    public class AddTwoTests
    {
        [TestMethod]
        public void AddTwoTestShouldAddTwoNumbersRepresentedAsALinkedLists()
        {
            //GIVEN
            var first = new ListNode
            {
                Value = 2,
                Next = new ListNode {Value = 4, Next = new ListNode {Value = 3, Next = null}}
            };
            var second = new ListNode
            {
                Value = 5,
                Next = new ListNode {Value = 6, Next = new ListNode {Value = 4, Next = null}}
            };
            var calculator = new AddTwo();

            //WHEN
            var third = calculator.Add(first, second);

            //THEN
            var printer = new ListPrinter();
            var printedThird = printer.Print(third);
            Assert.AreEqual("7 0 8", printedThird);
        }
    }
}