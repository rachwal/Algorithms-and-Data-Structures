using LeetCode.Algorithms.BinarySearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BinarySearch.Tests
{
    [TestClass]
    public class SearchInsertPositionTest
    {
        [TestMethod]
        public void
            SearchInsertPositionShouldReturnIndexOfElementAndIfItDoesNotExistShouldReturnInsertPositonOfSuchAnElement()
        {
            //GIVEN
            var input = new[] {1, 3, 5, 6};
            var finder = new SearchInsertPosition();

            //WHEN
            var fivePosition = finder.SearchInsert(input, 5);
            var twoPosition = finder.SearchInsert(input, 2);
            var sevenPosition = finder.SearchInsert(input, 7);
            var zeroPosition = finder.SearchInsert(input, 0);

            //THEN
            Assert.AreEqual(2, fivePosition);
            Assert.AreEqual(1, twoPosition);
            Assert.AreEqual(4, sevenPosition);
            Assert.AreEqual(0, zeroPosition);
        }
    }
}