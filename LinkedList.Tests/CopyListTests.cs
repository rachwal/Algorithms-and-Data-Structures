using System;
using System.Text;
using Algorithms.LinkedList.Printer;
using DataStructures;
using LeetCode.Algorithms.LinkedList.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.LinkedList.Tests
{
    [TestClass]
    public class CopyListTests
    {
        private RandomListNode CreateSampleList()
        {
            var n1 = new RandomListNode(1);
            var n2 = new RandomListNode(2);
            var n3 = new RandomListNode(3);
            var n4 = new RandomListNode(4);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Random = n3;
            n3.Random = n2;
            n2.Random = n1;
            return n1;
        }

        private string PrintRandomListNodes(RandomListNode node)
        {
            var current = node;
            var result = new StringBuilder();

            while (current != null)
            {
                var random = current.Random != null ? current.Random.Value.ToString() : "null";
                result.Append($"({current.Value}|{random}) ");
                current = current.Next;
            }
            return result.ToString().TrimEnd();
        }

        [TestMethod]
        public void CopyListShouldCopyLinkedListWithAdditionalRandomPointer()
        {
            //GIVEN
            var sampleList = CreateSampleList();
            var copyList = new CopyList();

            //WHEN
            var result = copyList.Copy(sampleList);

            //THEN
            var printedResult = PrintRandomListNodes(result);
            Assert.AreEqual("(1|null) (2|1) (3|2) (4|3)", printedResult);
        }

        [TestMethod]
        public void CopyListShouldCopyLinkedListWithAdditionalRandomPointerMethodCanModifyInput()
        {
            //GIVEN
            var sampleList = CreateSampleList();
            var copyList = new CopyList();

            //WHEN
            var result = copyList.CopyModify(sampleList);

            //THEN
            var printedResult = PrintRandomListNodes(result);
            Assert.AreEqual("(1|null) (2|1) (3|2) (4|3)", printedResult);
        }
    }
}