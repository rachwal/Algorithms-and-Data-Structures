using Algorithms.LinkedList.Printer;
using DataStructures;
using LeetCode.Algorithms.LinkedList.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.LinkedList.Tests
{
    [TestClass]
    public class ReverseLinkedListTests
    {
        [TestMethod]
        public void ReverseLinkedListShouldReverseList()
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
                            new ListNode {Value = 3, Next = new ListNode {Value = 4, Next = new ListNode {Value = 5}}}
                    }
            };
            var converter = new ReverseLinkedList();

            //WHEN
            var reversedList = converter.Reverse(linkedList);

            //THEN
            var printer = new ListPrinter();
            var printedThird = printer.Print(reversedList);
            Assert.AreEqual("5 4 3 2 1", printedThird);
        }
    }
}