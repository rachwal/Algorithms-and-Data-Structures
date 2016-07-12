using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class HouseRobberTests
    {
        [TestMethod]
        public void HouseRobberShouldShowMaxAmoutOfMoneyUsingDp()
        {
            //GIVEN
            var robber = new HouseRobber();

            //WHEN
            var money = robber.RobDp(new[] {50, 1, 1, 50});

            //THEN
            Assert.AreEqual(100, money);
        }

        [TestMethod]
        public void HouseRobberShouldShowMaxAmoutOfMoneyUsingLv()
        {
            //GIVEN
            var robber = new HouseRobber();

            //WHEN
            var money = robber.RobLv(new[] {50, 1, 1, 50});

            //THEN
            Assert.AreEqual(100, money);
        }
    }
}