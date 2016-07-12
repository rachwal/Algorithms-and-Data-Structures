using System.Linq;
using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class MissingRangesTests
    {
        [TestMethod]
        public void MissingRangesShouldRangesMissingInInputArrayForSpecifiedBeginAndEnd()
        {
            //GIVEN
            var expectedRanges = new[] {"2", "4->49", "51->74", "76->99"};
            var finder = new MissingRanges();

            //WHEN
            var ranges = finder.Find(new[] {0, 1, 3, 50, 75}, 0, 99);

            //THEN
            Assert.IsTrue(expectedRanges.SequenceEqual(ranges));
        }
    }
}