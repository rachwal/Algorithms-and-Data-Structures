using LeetCode.Algorithms.BitManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BitManipulation.Tests
{
    [TestClass]
    public class SingleNumberTests
    {
        [TestMethod]
        public void SingleNumberShouldReturnSingleNumberInAnArrayUsingHashMap()
        {
            //GIVEN
            var search = new SingleNumber();

            //WHEN
            var number = search.FindWithHashMap(new[] {1, 1, 2, 2, 3, 4, 4, 5, 5});

            //THEN
            Assert.AreEqual(3, number);
        }

        [TestMethod]
        public void SingleNumberShouldReturnSingleNumberInAnArrayUsingHashSet()
        {
            //GIVEN
            var search = new SingleNumber();

            //WHEN
            var number = search.FindWithHashSet(new[] {1, 1, 2, 2, 3, 4, 4, 5, 5});

            //THEN
            Assert.AreEqual(3, number);
        }

        [TestMethod]
        public void SingleNumberShouldReturnSingleNumberInAnArrayUsingXor()
        {
            //GIVEN
            var search = new SingleNumber();

            //WHEN
            var number = search.FindWithXor(new[] {1, 1, 2, 2, 3, 4, 4, 5, 5});

            //THEN
            Assert.AreEqual(3, number);
        }

        [TestMethod]
        public void SingleNumberShouldReturnSingleNumberInAnArrayAmontTripples()
        {
            //GIVEN
            var search = new SingleNumber();

            //WHEN
            var number = search.FindSingleNumberAmongTripples(new[] {1, 1, 1, 2, 2, 2, 3, 4, 4, 4, 5, 5, 5});

            //THEN
            Assert.AreEqual(3, number);
        }

        [TestMethod]
        public void SingleNumberShouldReturnSingleNumberInAnArrayAmontTripplesUsingBitmasks()
        {
            //GIVEN
            var search = new SingleNumber();

            //WHEN
            var number = search.FindSingleNumberAmongTripplesBitmasks(new[] {1, 1, 1, 2, 2, 2, 3, 4, 4, 4, 5, 5, 5});

            //THEN
            Assert.AreEqual(3, number);
        }
    }
}