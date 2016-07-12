using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class ValidNumberTests
    {
        [TestMethod]
        public void ValidNumberShouldValidateIfStringIsAValidNumber()
        {
            //GIVEN
            var validator = new ValidNumber();

            //WHEN
            var zero = validator.Validate("0");
            var oneTenth = validator.Validate("0.1");
            var text = validator.Validate("abc");

            //THEN
            Assert.IsTrue(zero);
            Assert.IsTrue(oneTenth);
            Assert.IsFalse(text);
        }
    }
}