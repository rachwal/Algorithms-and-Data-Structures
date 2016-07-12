using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class LongestSubstringWhichContainsTwoUniqueCharactersTests
    {
        [TestMethod]
        public void LongestSubstringWhichContainsTwoUniqueCharactersShouldReturnLengthOfLongsestSubstring()
        {
            //GIVEN
            const string input = "abcbbbbcccbddddadacb"; //bcbbbbcccb
            var finder = new LongestSubstringWhichContainsTwoUniqueCharacters();

            //WHEN
            var lengthOfLongestSubstring = finder.FindLongestSubstringLength(input);

            //THEN
            Assert.AreEqual(10, lengthOfLongestSubstring);
        }
    }
}