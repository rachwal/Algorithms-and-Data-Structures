using LeetCode.Algorithms.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.DynamicProgramming.Tests
{
    [TestClass]
    public class UniquePathsWithObstacleTest
    {
        [TestMethod]
        public void UniquePathsShouldReturnNumberOfUniquePathsUsingBacktrack()
        {
            //GIVEN
            var obstacleGrid = new[] {new[] {0, 0, 0}, new[] {0, 1, 0}, new[] {0, 0, 0}};
            var uniquePaths = new UniquePathsWithObstacle();

            //WHEN
            var numberOfPaths = uniquePaths.GetNumberOfUniquePaths(obstacleGrid);

            //THEN
            Assert.AreEqual(2, numberOfPaths);
        }
    }
}