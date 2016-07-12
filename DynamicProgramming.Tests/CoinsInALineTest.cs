using LeetCode.Algorithms.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.DynamicProgramming.Tests
{
    [TestClass]
    public class CoinsInALineTest
    {
        [TestMethod]
        public void CoinsInALineShouldReturnMaximumMoneyToWin()
        {
            //GIVEN
            var coins = new[] {3, 2, 2, 3, 1, 2};
            var game = new CoinsInALine();

            //WHEN
            var maxMoney = game.MaxMoney(coins);

            //THEN
            Assert.AreEqual(8, maxMoney);
        }
    }
}