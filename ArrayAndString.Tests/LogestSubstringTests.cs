using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class LogestSubstringTests
    {
        [TestMethod]
        public void LogestSubstringShouldReturnLengthOfTheLongestSubstringWithoutRepeatingCharacters()
        {
            //GIVEN
            var longestSubstring = new LongestSubstring();

            //WHEN
            var abcabcbb = longestSubstring.GetLengthWithoutRepeatingCharacters("abcabcbb");
            var bbbbbb = longestSubstring.GetLengthWithoutRepeatingCharacters("bbbbbb");

            //THEN
            Assert.AreEqual(3, abcabcbb);
            Assert.AreEqual(1, bbbbbb);
        }

        [TestMethod]
        public void LogestSubstringShouldReturnLengthOfTheLongestSubstringWithAtMostTwoDistinctCharacters()
        {
            //GIVEN
            var longestSubstring = new LongestSubstring();

            //WHEN
            var eceba = longestSubstring.GetLengthWithAtMostTwoDistinctCharacters("eceba");

            //THEN
            Assert.AreEqual(3, eceba);
        }

        [TestMethod]
        public void LogestSubstringShouldReturnLongestPalindromicSubstring()
        {
            //GIVEN
            var longestSubstring = new LongestSubstring();

            //WHEN
            var aba = longestSubstring.GetLongestPalindromicSubstring("abacdgfdcaba");
            var kajak = longestSubstring.GetLongestPalindromicSubstring("jakajakkrzysztof");
            var empty = longestSubstring.GetLongestPalindromicSubstring(string.Empty);

            //THEN
            Assert.AreEqual("aba", aba);
            Assert.AreEqual("kajak", kajak);
            Assert.AreEqual(string.Empty, empty);
        }
    }
}