using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class OneEditDistanceTests
    {
        [TestMethod]
        public void OneEditDistanceShouldValidateAppendingOfSingleCharacter()
        {
            //GIVEN
            const string text = "test";
            var validator = new OneEditDistance();

            //WHEN
            var isValid = validator.IsOneEdit(text, "testt");

            //THEN
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void OneEditDistanceShouldValidateRemovingOfSingleCharacter()
        {
            //GIVEN
            const string text = "test";
            var validator = new OneEditDistance();

            //WHEN
            var isValid = validator.IsOneEdit(text, "tst");

            //THEN
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void OneEditDistanceShouldValidateInsertingOfSingleCharacter()
        {
            //GIVEN
            const string text = "test";
            var validator = new OneEditDistance();

            //WHEN
            var isValid = validator.IsOneEdit(text, "teest");

            //THEN
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void OneEditDistanceShouldValidateEditingOfSingleCharacter()
        {
            //GIVEN
            const string text = "test";
            var validator = new OneEditDistance();

            //WHEN
            var isValid = validator.IsOneEdit(text, "tfst");

            //THEN
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void OneEditDistanceShouldInValidateEditingOfMoreThanOneCharacter()
        {
            //GIVEN
            const string text = "test";
            var validator = new OneEditDistance();

            //WHEN
            var isValid = validator.IsOneEdit(text, "tfft");

            //THEN
            Assert.IsFalse(isValid);
        }
    }
}