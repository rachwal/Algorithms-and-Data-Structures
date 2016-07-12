using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class StringToIntegerTests
    {
        [TestMethod]
        public void StringToIntegerShould()
        {
            //GIVEN
            var converter = new StringToInteger();

            //WHEN
            var ten = converter.Convert("+10");
            var minusTwentyTwo = converter.Convert("-22");
            var zero = converter.Convert(null);

            //THEN
            Assert.AreEqual(10, ten);
            Assert.AreEqual(-22, minusTwentyTwo);
            Assert.AreEqual(0, zero);
        }
    }
}