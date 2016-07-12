using LeetCode.Algorithms.BinarySearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinarySearch.Tests
{
    [TestClass]
    public class FindMinimumInSortedRotatedArrayWithDuplicatesTest
    {
        [TestMethod]
        public void FindMinimumInSortedRotatedArrayWithDuplicatesShouldReturnTheMinimumValue()
        {
            //GIVEN
            var input = new[] {1, 1, 1, 0, 1};
            var finder = new FindMinimumInSortedRotatedArrayWithDuplicates();

            //WHEN
            var value = finder.FindMin(input);

            //THEN
            Assert.AreEqual(0, value);
        }
    }
}