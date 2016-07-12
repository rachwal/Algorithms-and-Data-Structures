using System;
using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class BalancedBinaryTreeBottomUpValidator : IBalancedBinaryTreeValidator
    {
        public bool IsBalanced(TreeNode root)
        {
            var maxDepth = MaxDepth(root);
            return maxDepth >= 0;
        }

        private int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = MaxDepth(root.Left);
            if (left < 0)
            {
                return int.MinValue;
            }

            var right = MaxDepth(root.Right);
            if (right < 0)
            {
                return int.MinValue;
            }
            return Math.Abs(left - right) <= 1 ? Math.Max(left, right) + 1 : int.MinValue;
        }
    }
}