using LeetCode.Algorithms.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Math.Tests
{
    [TestClass]
    public class ReverseIntegerTests
    {
        [TestMethod]
        public void ReverseIntegerShouldReturnReversedNumber()
        {
            //GIVEN
            var reverseInteger = new ReverseInteger();

            //WHEN
            var reversed123 = reverseInteger.Reverse(123);
            var reversed123456 = reverseInteger.Reverse(123456);

            //THEN
            Assert.AreEqual(321, reversed123);
            Assert.AreEqual(654321, reversed123456);
        }

        [TestMethod]
        public void ReverseIntegerShouldReturnZeroWhenReversedNumberIsOutOfRange()
        {
            //GIVEN
            var reverseInteger = new ReverseInteger();

            //WHEN
            var reversedOutOfRange = reverseInteger.Reverse(int.MaxValue);

            //THEN
            Assert.AreEqual(0, reversedOutOfRange);
        }
    }
}