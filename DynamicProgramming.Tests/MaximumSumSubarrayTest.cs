using LeetCode.Algorithms.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.DynamicProgramming.Tests
{
    [TestClass]
    public class MaximumSumSubarrayTest
    {
        [TestMethod]
        public void MaximumSumSubarrayShouldFindMaximumSumUsingDc()
        {
            //GIVEN
            var data = new[] {2, 1, -3, 4, -1, 2, 1, -5, 4};
            var finder = new MaximumSumSubarray();

            //WHEN
            var sum = finder.MaxSubArrayDivideAndConquer(data);

            //THEN
            Assert.AreEqual(6, sum);
        }

        [TestMethod]
        public void MaximumSumSubarrayShouldFindMaximumSumUsingDp()
        {
            //GIVEN
            var data = new[] {2, 1, -3, 4, -1, 2, 1, -5, 4};
            var finder = new MaximumSumSubarray();

            //WHEN
            var sum = finder.MaxSubArrayDynamicProgramming(data);

            //THEN
            Assert.AreEqual(6, sum);
        }
    }
}