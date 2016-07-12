using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class CandyTests
    {
        [TestMethod]
        public void CandyShouldCalcuateMinimumNumberOfCandiesToDistribute()
        {
            //GIVEN
            var calculator = new Candy();

            //WHEN
            var amount = calculator.CalculateMin(new[] {1, 2, 3, 2, 1});

            //THEN
            Assert.AreEqual(9, amount);
        }
    }
}