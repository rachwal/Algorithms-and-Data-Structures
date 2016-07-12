using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class LongestCommonPrefixTests
    {
        [TestMethod]
        public void LongestCommonPrefixShouldReturnSubstring()
        {
            //GIVEN
            var finder = new LongestCommonPrefix();

            //WHEN
            var zeroLength = finder.FindPrefix(new[] {"abcdkajakefg", "abceeff", string.Empty});
            var threeLength = finder.FindPrefix(new[] {"abcdkajakefg", "abceeff", "abc"});
            var maxLength = finder.FindPrefix(new[] {"abcd", "abcd", "abcd"});

            //THEN
            Assert.AreEqual(string.Empty, zeroLength);
            Assert.AreEqual("abc", threeLength);
            Assert.AreEqual("abcd", maxLength);
        }
    }
}