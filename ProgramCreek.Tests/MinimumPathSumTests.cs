using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class MinimumPathSumTests
    {
        [TestMethod]
        public void MinimumPathSumShouldFindMinPathSumUsingDfs()
        {
            //GIVEN
            var finder = new MinimumPathSum();

            //WHEN
            var minPathSum = finder.MinPathSumDfs(
                new[]
                {
                    new[] {2, 1, 2, 2, 2},
                    new[] {1, 0, 1, 2, 2},
                    new[] {2, 1, 0, 1, 2},
                    new[] {2, 2, 1, 0, 1},
                    new[] {2, 2, 2, 1, 3}
                });

            //THEN
            Assert.AreEqual(9, minPathSum);
        }

        [TestMethod]
        public void MinimumPathSumShouldFindMinPathSumUsingDp()
        {
            //GIVEN
            var finder = new MinimumPathSum();

            //WHEN
            var minPathSum = finder.MinPathSumDp(
                new[]
                {
                    new[] {2, 1, 2, 2, 2},
                    new[] {1, 0, 1, 2, 2},
                    new[] {2, 1, 0, 1, 2},
                    new[] {2, 2, 1, 0, 1},
                    new[] {2, 2, 2, 1, 3}
                });

            //THEN
            Assert.AreEqual(9, minPathSum);
        }
    }
}