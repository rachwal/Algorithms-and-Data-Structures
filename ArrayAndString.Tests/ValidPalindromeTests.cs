using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class ValidPalindromeTests
    {
        [TestMethod]
        public void ValidPalindromeShouldValidateInputIgnoringNonLettersNorNumbers()
        {
            //GIVEN
            const string validPalindrome = "k,ajak";
            const string nonValidPalindrome = "kajak1";

            var validator = new ValidPalindrome();

            //WHEN
            var testOfValidInput = validator.Validate(validPalindrome);
            var testOfInvalidInput = validator.Validate(nonValidPalindrome);

            //THEN
            Assert.IsTrue(testOfValidInput);
            Assert.IsFalse(testOfInvalidInput);
        }
    }
}