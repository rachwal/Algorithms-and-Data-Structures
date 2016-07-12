using System.Collections.Generic;
using LeetCode.Algorithms.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Stack.Tests
{
    [TestClass]
    public class ParenthesisValidatorTests
    {
        private Dictionary<char, char> CreateValidSymbols()
        {
            var operations = new Dictionary<char, char>
            {
                ['('] = ')',
                ['{'] = '}',
                ['['] = ']'
            };
            return operations;
        }

        [TestMethod]
        public void ParenthesisValidatorShouldValidateInputStrings()
        {
            //GIVEN
            var validSymbols = CreateValidSymbols();
            var validator = new ParenthesisValidator(validSymbols);

            //WHEN
            var firstResult = validator.IsValid("()[]{}");
            var secondResult = validator.IsValid("([)]");

            //THEN
            Assert.IsTrue(firstResult);
            Assert.IsFalse(secondResult);
        }

        [TestMethod]
        public void ParenthesisValidatorShouldValidateAnEmptyString()
        {
            //GIVEN
            var validSymbols = CreateValidSymbols();
            var validator = new ParenthesisValidator(validSymbols);

            //WHEN
            var result = validator.IsValid(string.Empty);

            //THEN
            Assert.IsTrue(result);
        }
    }
}