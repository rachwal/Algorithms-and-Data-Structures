using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class UniquePathsTests
    {
        [TestMethod]
        public void UniquePathsShouldReturnNumberOfUniquePathsFromTopLeftToBottomRightCornerOfMatrixUsingDfs()
        {
            //GIVEN
            const int numberOfRows = 3;
            const int numberOfColumns = 7;

            var uniquePaths = new UniquePaths();

            //WHEN
            var count = uniquePaths.UniquePathsDfs(numberOfRows, numberOfColumns);

            //THEN
            Assert.AreEqual(GetNewtonSymbolValue(numberOfColumns + numberOfRows - 2, numberOfRows - 1), count);
        }

        [TestMethod]
        public void UniquePathsShouldReturnNumberOfUniquePathsFromTopLeftToBottomRightCornerOfMatrixUsingDp()
        {
            //GIVEN
            const int numberOfRows = 3;
            const int numberOfColumns = 7;

            var uniquePaths = new UniquePaths();

            //WHEN
            var count = uniquePaths.UniquePathsDp(numberOfRows, numberOfColumns);

            //THEN
            Assert.AreEqual(GetNewtonSymbolValue(numberOfColumns + numberOfRows - 2, numberOfRows - 1), count);
        }

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
    }
}