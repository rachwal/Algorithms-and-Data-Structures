using System.Linq;
using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class TelephoneWordsTests
    {
        [TestMethod]
        public void TelephoneWordsShouldPrintAllCombinationsForAGivenNumber()
        {
            //GIVEN
            var number = new[] {2, 1, 3, 0};
            var expectedWords = new[]
            {
                "A1D0", "A1E0", "A1F0",
                "B1D0", "B1E0", "B1F0",
                "C1D0", "C1E0", "C1F0",
            };

            var telephone = new TelephoneWords();

            //WHEN
            var words = telephone.PrintWords(number);

            //THEN
            Assert.IsTrue(expectedWords.SequenceEqual(words));
        }
    }
}