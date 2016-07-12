using System.Linq;
using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class PermutationsGeneratorTests
    {
        [TestMethod]
        public void PermutationsGeneratorShouldGeneratePermutationsOfAString()
        {
            //GIVEN
            var expectedPermutations = new[] {"123", "132", "213", "231", "312", "321"};
            var generator = new PermutationsGenerator();

            //WHEN
            var permutations = generator.Generate("123");

            //THEN
            Assert.IsTrue(expectedPermutations.SequenceEqual(permutations));
        }
    }
}