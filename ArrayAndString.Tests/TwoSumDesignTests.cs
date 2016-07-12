using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class TwoSumDesignTests
    {
        [TestMethod]
        public void TwoSumDesignShouldReturnTrueIfSumCanBeRepresentedByPairOfAddedNumbers()
        {
            //GIVEN
            var structure = new SumOfTwoDesign();

            //WHEN
            structure.Add(1);
            structure.Add(1);
            structure.Add(3);
            structure.Add(3);
            structure.Add(5);
            structure.Add(5);

            //THEN
            var fourExists = structure.Find(4);
            var sevenExists = structure.Find(7);

            Assert.IsTrue(fourExists);
            Assert.IsFalse(sevenExists);
        }
    }
}