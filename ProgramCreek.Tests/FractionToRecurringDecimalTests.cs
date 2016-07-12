using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class FractionToRecurringDecimalTests
    {
        [TestMethod]
        public void FractionToRecurringDecimalShouldPrintresultWithRecurringDecimalPart()
        {
            //GIVEN
            var printer = new FractionToRecurringDecimal();

            //WHEN
            var result1 = printer.GetFraction(1, 2, 3);
            var result2 = printer.GetFraction(2, 1, 3);
            var result3 = printer.GetFraction(2359348, 99900, 3);

            //THEN
            Assert.AreEqual("0.5", result1);
            Assert.AreEqual("2", result2);
            Assert.AreEqual("23.61709(709)", result3);
        }
    }
}