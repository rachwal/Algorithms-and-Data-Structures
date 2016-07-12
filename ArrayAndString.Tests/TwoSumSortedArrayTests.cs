using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class TwoSumSortedArrayTests
    {
        [TestMethod]
        public void TwoSumSortedArrayReturnIdsOfTargetSumElementsWhenTheyExists()
        {
            //GIVEN
            var data = new[] {1, 2, 3, 4, 5};
            var finder = new TwoSum();

            //WHEN
            var ids = finder.FindIds(data, 8);

            //THEN
            Assert.AreEqual(2, ids[0]);
            Assert.AreEqual(4, ids[1]);
        }

        [TestMethod]
        public void TwoSumSortedArrayShouldReturnNegativeIdsWhenElementsDoesNotSumToTargetExists()
        {
            //GIVEN
            var data = new[] {1, 2, 3, 4, 5};
            var finder = new TwoSum();

            //WHEN
            var ids = finder.FindIds(data, 10);

            //THEN
            Assert.AreEqual(-1, ids[0]);
            Assert.AreEqual(-1, ids[1]);
        }
    }
}