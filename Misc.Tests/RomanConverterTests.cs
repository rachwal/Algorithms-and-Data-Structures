using LeetCode.Algorithms.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Misc.Tests
{
    [TestClass]
    public class RomanConverterTests
    {
        [TestMethod]
        public void RomanConverterShouldConvertAnIntegerToARomanNumber()
        {
            //GIVEN
            var converter = new RomanConverter();

            //WHEN
            var one = converter.Convert(1);
            var three = converter.Convert(3);
            var five = converter.Convert(5);
            var nine = converter.Convert(9);
            var twoThousandSixteen = converter.Convert(2016);

            //THEN
            Assert.AreEqual("I", one);
            Assert.AreEqual("III", three);
            Assert.AreEqual("V", five);
            Assert.AreEqual("IX", nine);
            Assert.AreEqual("MMXVI", twoThousandSixteen);
        }

        [TestMethod]
        public void RomanConverterShouldConvertARomanNumberToAnInteger()
        {
            //GIVEN
            var converter = new RomanConverter();

            //WHEN
            var one = converter.Convert("I");
            var three = converter.Convert("III");
            var five = converter.Convert("V");
            var nine = converter.Convert("IX");
            var twoThousandSixteen = converter.Convert("MMXVI");

            //THEN
            Assert.AreEqual(1, one);
            Assert.AreEqual(3, three);
            Assert.AreEqual(5, five);
            Assert.AreEqual(9, nine);
            Assert.AreEqual(2016, twoThousandSixteen);
        }
    }
}