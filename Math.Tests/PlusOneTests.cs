using System.Collections.Generic;
using System.Linq;
using LeetCode.Algorithms.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Math.Tests
{
    [TestClass]
    public class PlusOneTests
    {
        [TestMethod]
        public void PlusOneShouldAddOneToListOfIntegersRepresentingNumber()
        {
            //GIVEN
            var number = new List<int> {1, 2, 3};
            var calculator = new PlusOne();

            //WHEN
            calculator.AddOne(number);

            //THEN
            Assert.IsTrue(new List<int> {1, 2, 4}.SequenceEqual(number));
        }
    }
}