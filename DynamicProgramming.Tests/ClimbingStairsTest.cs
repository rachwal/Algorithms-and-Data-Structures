using LeetCode.Algorithms.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.DynamicProgramming.Tests
{
    [TestClass]
    public class ClimbingStairsTest
    {
        [TestMethod]
        public void ClimbingStairsShouldReturnNumberOfDistinctWaysToClimbNSteps()
        {
            //GIVEN
            var climbingStairs = new ClimbingStairs();

            //WHEN
            var oneStep = climbingStairs.GetDistinctWaysNumber(1);
            var twoSteps = climbingStairs.GetDistinctWaysNumber(2);
            var sixSteps = climbingStairs.GetDistinctWaysNumber(6);

            //THEN
            Assert.AreEqual(1, oneStep);
            Assert.AreEqual(2, twoSteps);
            Assert.AreEqual(13, sixSteps);
        }

        [TestMethod]
        public void ClimbingStairsShouldReturnNumberOfDistinctWaysToClimbNStepsUsingCache()
        {
            //GIVEN
            var climbingStairs = new ClimbingStairs();

            //WHEN
            var oneStep = climbingStairs.GetDistinctWays(1);
            var twoSteps = climbingStairs.GetDistinctWays(2);
            var sixSteps = climbingStairs.GetDistinctWays(6);

            //THEN
            Assert.AreEqual(1, oneStep);
            Assert.AreEqual(2, twoSteps);
            Assert.AreEqual(13, sixSteps);
        }
    }
}