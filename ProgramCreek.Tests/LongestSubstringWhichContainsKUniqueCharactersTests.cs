using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class LongestSubstringWhichContainsKUniqueCharactersTests
    {
        [TestMethod]
        public void LongestSubstringWhichContainsKUniqueCharactersShouldReturnLengthOfLongsestSubstring()
        {
            //GIVEN
            var finder = new LongestSubstringWhichContainsKUniqueCharacters();

            //WHEN
            var cbbbbcccb = finder.FindLongestSubstringLength("abcbbbbcccbddddadacb", 2);
            var cadcacacaca = finder.FindLongestSubstringLength("abcadcacacaca", 3);

            //THEN
            Assert.AreEqual(10, cbbbbcccb);
            Assert.AreEqual(11, cadcacacaca);
        }
    }
}