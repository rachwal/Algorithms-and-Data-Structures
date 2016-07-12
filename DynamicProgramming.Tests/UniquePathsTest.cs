using LeetCode.Algorithms.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.DynamicProgramming.Tests
{
    [TestClass]
    public class UniquePathsTest
    {
        private int Factorial(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            return n*Factorial(n - 1);
        }

        private int GetNewtonSymbolValue(int n, int k)
        {
            return Factorial(n)/(Factorial(k)*Factorial(n - k));
        }

        [TestMethod]
        public void UniquePathsShouldReturnNumberOfUniquePathsUsingBacktrack()
        {
            //GIVEN
            const int numberOfRows = 3;
            const int numberOfColumns = 7;

            var uniquePaths = new UniquePaths();

            //WHEN
            var count = uniquePaths.UniquePathsBacktrack(numberOfRows, numberOfColumns);

            //THEN
            Assert.AreEqual(GetNewtonSymbolValue(numberOfColumns + numberOfRows - 2, numberOfRows - 1), count);
        }

        [TestMethod]
        public void UniquePathsShouldReturnNumberOfUniquePathsUsingBacktrackWithMemorization()
        {
            //GIVEN
            const int numberOfRows = 3;
            const int numberOfColumns = 7;

            var uniquePaths = new UniquePaths();

            //WHEN
            var count = uniquePaths.UniquePathsBacktrackWithMemorization(numberOfRows, numberOfColumns);

            //THEN
            Assert.AreEqual(GetNewtonSymbolValue(numberOfColumns + numberOfRows - 2, numberOfRows - 1), count);
        }

        [TestMethod]
        public void UniquePathsShouldReturnNumberOfUniquePathsUsingBacktrackWithMemorizationBottomUp()
        {
            //GIVEN
            const int numberOfRows = 3;
            const int numberOfColumns = 7;

            var uniquePaths = new UniquePaths();

            //WHEN
            var count = uniquePaths.UniquePathsBacktrackWithMemorizationBottomUp(numberOfRows, numberOfColumns);

            //THEN
            Assert.AreEqual(GetNewtonSymbolValue(numberOfColumns + numberOfRows - 2, numberOfRows - 1), count);
        }
    }
}