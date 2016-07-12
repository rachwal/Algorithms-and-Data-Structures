using System;
using System.Collections.Generic;
using LeetCode.Algorithms.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Stack.Tests
{
    [TestClass]
    public class ReversePolishNotationEvaluatorTests
    {
        private Dictionary<string, IOperation> CreateOperations()
        {
            var operations = new Dictionary<string, IOperation>
            {
                ["+"] = new Add(),
                ["-"] = new Substract(),
                ["*"] = new Multiply(),
                ["/"] = new Divide()
            };
            return operations;
        }

        [TestMethod]
        public void ReversePolishNotationEvaluatorShouldEvaluateAnArrayOfTokens()
        {
            //GIVEN
            var operations = CreateOperations();
            var firstCase = new[] {"2", "1", "+", "3", "*"};
            var secondCase = new[] {"4", "13", "5", "/", "+"};
            var evaluator = new ReversePolishNotationEvaluator(operations);

            //WHEN
            var firstResult = evaluator.Evaluate(firstCase);
            var secondResult = evaluator.Evaluate(secondCase);

            //THEN
            Assert.AreEqual(9, firstResult);
            Assert.AreEqual(6, secondResult);
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void ReversePolishNotationEvaluatorShouldThrowAnInvalidOperationExceptionWhenTryToEvaluateEmptyTokenArray
            ()
        {
            //GIVEN
            var operations = CreateOperations();
            var tokens = new string[] {};
            var evaluator = new ReversePolishNotationEvaluator(operations);

            //WHEN
            var result = evaluator.Evaluate(tokens);

            //THEN
            // expecting an invalid operation exception
        }
    }
}