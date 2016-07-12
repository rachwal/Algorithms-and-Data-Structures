using System.Collections.Generic;

namespace LeetCode.Algorithms.Stack
{
    public class MinStack
    {
        private readonly Stack<int> minStack = new Stack<int>();
        private readonly Stack<int> stack = new Stack<int>();

        public void Push(int x)
        {
            stack.Push(x);
            if (minStack.Count == 0 || x <= minStack.Peek())
            {
                minStack.Push(x);
            }
        }

        public void Pop()
        {
            var element = stack.Pop();
            if (element == minStack.Peek())
            {
                minStack.Pop();
            }
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
    }
}