using LeetCode.Algorithms.BinarySearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinarySearch.Tests
{
    [TestClass]
    public class FindMinimumInSortedRotatedArrayTest
    {
        [TestMethod]
        public void FindMinimumInSortedRotatedArrayShouldReturnTheMinimumValue()
        {
            //GIVEN
            var input = new[] {5, 6, 7, 8, 1};
            var finder = new FindMinimumInSortedRotatedArray();

            //WHEN
            var value = finder.FindMin(input);

            //THEN
            Assert.AreEqual(1, value);
        }
    }
}