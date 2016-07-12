using System;
using System.Linq;
using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class ReverseStringsTests
    {
        [TestMethod]
        public void ReverseStringsShouldReverseWordsInASentence()
        {
            //GIVEN
            const string input = "the      sky is blue      ";
            const string expectedOutput = "blue is sky the";
            var reverseStrings = new ReverseStrings();

            //WHEN
            var output = reverseStrings.Reverse(input);

            //THEN
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void ReverseStringsShouldReverseInPlaceWordsInASentence()
        {
            //GIVEN
            const string sentence = "the sky is blue";
            var text = sentence.ToCharArray();
            const string expectedOutput = "blue is sky the";

            var reverseStrings = new ReverseStrings();

            //WHEN
            reverseStrings.ReverseInPlace(text);

            //THEN
            Assert.IsTrue(expectedOutput.SequenceEqual(text));
        }

        [TestMethod]
        public void ShouldReverseWordsInPlace()
        {
            //GIVEN
            const string text = "the sky is blue";
            const string expectedOutput = "blue is sky the";

            var reverseStrings = new ReverseStrings();

            //WHEN
            reverseStrings.ReverseInPlaceUnsafe(text);

            //THEN
            Assert.AreEqual(expectedOutput, text);
        }
    }
}