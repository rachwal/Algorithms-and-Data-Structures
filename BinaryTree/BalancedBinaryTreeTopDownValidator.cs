using System;
using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class BalancedBinaryTreeTopDownValidator : IBalancedBinaryTreeValidator
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return Math.Abs(MaxDepth(root.Left) - MaxDepth(root.Right)) <= 1
                   && IsBalanced(root.Left)
                   && IsBalanced(root.Right);
        }

        private int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(MaxDepth(root.Left), MaxDepth(root.Right)) + 1;
        }
    }
}