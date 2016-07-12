using LeetCode.Algorithms.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Math.Tests
{
    [TestClass]
    public class PalindromeNumberTests
    {
        [TestMethod]
        public void PalindromeNumberShouldValidateIfNumberIsAPalindromeOrNot()
        {
            //GIVEN
            var validator = new PalindromeNumber();

            //WHEN
            var valid = validator.IsValid(12321);
            var invalid = validator.IsValid(123);

            //THEN
            Assert.IsTrue(valid);
            Assert.IsFalse(invalid);
        }
    }
}