using System.Collections.Generic;

namespace LeetCode.Algorithms.Stack
{
    public interface IOperation
    {
        int Evaluate(int x, int y);
    }

    public class Add : IOperation
    {
        public int Evaluate(int x, int y)
        {
            return x + y;
        }
    }

    public class Substract : IOperation
    {
        public int Evaluate(int x, int y)
        {
            return x - y;
        }
    }

    public class Multiply : IOperation
    {
        public int Evaluate(int x, int y)
        {
            return x*y;
        }
    }

    public class Divide : IOperation
    {
        public int Evaluate(int x, int y)
        {
            return x/y;
        }
    }

    public class ReversePolishNotationEvaluator
    {
        private readonly Dictionary<string, IOperation> operations;

        public ReversePolishNotationEvaluator(Dictionary<string, IOperation> operationsDictionary)
        {
            operations = operationsDictionary;
        }

        public int Evaluate(IEnumerable<string> tokens)
        {
            var stack = new Stack<int>();
            foreach (var token in tokens)
            {
                if (operations.ContainsKey(token))
                {
                    var y = stack.Pop();
                    var x = stack.Pop();
                    stack.Push(operations[token].Evaluate(x, y));
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }
            return stack.Pop();
        }
    }
}