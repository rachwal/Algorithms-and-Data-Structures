using System;
using LeetCode.Algorithms.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Stack.Tests
{
    [TestClass]
    public class MinStackTests
    {
        [TestMethod]
        public void MinStackShouldKeepTrackOfMinimumValueInTheStack()
        {
            //GIVEN
            var minStack = new MinStack();

            //WHEN
            minStack.Push(1);
            minStack.Push(4);
            minStack.Push(3);
            minStack.Push(0);
            minStack.Push(3);

            //THEN
            Assert.AreEqual(0, minStack.GetMin());
            minStack.Pop();
            minStack.Pop();
            Assert.AreEqual(1, minStack.GetMin());
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void MinStackShouldThrowAnInvalidOperationExceptionWhenTryToPopAnEmptyStack()
        {
            //GIVEN
            var minStack = new MinStack();

            //WHEN
            minStack.Pop();

            //THEN
            // expecting invalid operation exception
        }
    }
}