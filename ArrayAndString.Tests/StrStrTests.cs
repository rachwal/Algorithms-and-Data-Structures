using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class StrStrTests
    {
        [TestMethod]
        public void StrStrShouldReturnPositionOfTheNeedleWhenExists()
        {
            //GIVEN
            const string haystack = "abcdefghij";
            const string needle = "fgh";

            var finder = new StrStr();

            //WHEN
            var position = finder.Find(haystack, needle);

            //THEN
            Assert.AreEqual(5, position);
        }

        [TestMethod]
        public void StrStrShouldReturnNegativeNumberWhenNeedleDoesNotExists()
        {
            //GIVEN
            const string haystack = "abcdefghij";
            const string needle = "abj";

            var finder = new StrStr();

            //WHEN
            var position = finder.Find(haystack, needle);

            //THEN
            Assert.AreEqual(-1, position);
        }

        [TestMethod]
        public void StrStrShouldReturnZeroWhenNeedleIsAnEmptyString()
        {
            //GIVEN
            const string haystack = "abcdefghij";
            const string needle = "";

            var finder = new StrStr();

            //WHEN
            var position = finder.Find(haystack, needle);

            //THEN
            Assert.AreEqual(0, position);
        }

        [TestMethod]
        public void StrStrShouldReturnZeroWhenNeedleAndHaystackAreAnEmptyStrings()
        {
            //GIVEN
            const string haystack = "";
            const string needle = "";

            var finder = new StrStr();

            //WHEN
            var position = finder.Find(haystack, needle);

            //THEN
            Assert.AreEqual(0, position);
        }

        [TestMethod]
        public void StrStrShouldReturnNegativeNumberWhenHaystackIsEmptyButNeedleIsNot()
        {
            //GIVEN
            const string haystack = "";
            const string needle = "a";

            var finder = new StrStr();

            //WHEN
            var position = finder.Find(haystack, needle);

            //THEN
            Assert.AreEqual(-1, position);
        }
    }
}