using System;
using LeetCode.Algorithms.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.DynamicProgramming.Tests
{
    [TestClass]
    public class MaximumProductSubarrayTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void MaximumProductSubarrayShouldThrowAnInvalidArgumentExceptionWhenGetAnEmptyArray()
        {
            //GIVEN
            var input = new int[] {};
            var finder = new MaximumProductSubarray();

            //WHEN
            var maxProduct = finder.MaxProduct(input);

            //THEN
            // expected invalid argument exception
        }

        [TestMethod]
        public void MaximumProductSubarrayShouldReturnMaximumProductWhenGetsValidInput()
        {
            //GIVEN
            var input = new[] {2, 3, -2, 4};
            var finder = new MaximumProductSubarray();

            //WHEN
            var maxProduct = finder.MaxProduct(input);

            //THEN
            Assert.AreEqual(6, maxProduct);
        }
    }
}