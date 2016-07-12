using System.Linq;
using LeetCode.Algorithms.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Misc.Tests
{
    [TestClass]
    public class SpiralMatrixTests
    {
        [TestMethod]
        public void SpiralMatrixTestsShouldReturnMatrixInSpiralOrder()
        {
            //GIVEN
            var matrix = new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
            var spiralMatrix = new SpiralMatrix();

            //WHEN
            var list = spiralMatrix.SpiralOrder(matrix);

            //THEN
            Assert.IsTrue(new[] {1, 2, 3, 6, 9, 8, 7, 4, 5}.SequenceEqual(list));
        }
    }
}