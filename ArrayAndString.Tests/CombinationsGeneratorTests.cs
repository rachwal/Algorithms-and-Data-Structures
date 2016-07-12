using System.Linq;
using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class CombinationsGeneratorTests
    {
        [TestMethod]
        public void CombinationsGeneratorShouldGenerateCombinationsOfAString()
        {
            //GIVEN
            var expectedCombinations = new[] {"1", "2", "3", "21", "31", "32", "321"};
            var generator = new CombinationsGenerator();

            //WHEN
            var combinations = generator.Generate("123");

            //THEN
            Assert.IsTrue(expectedCombinations.SequenceEqual(combinations));
        }
    }
}