using System;
using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class BinaryTreeMaximumPathSum
    {
        private int maxSum;

        public int FindMax(TreeNode root)
        {
            maxSum = int.MinValue;
            FindSum(root);
            return maxSum;
        }

        private int FindSum(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            var left = FindSum(node.Left);
            var right = FindSum(node.Right);

            maxSum = Math.Max(node.Value + left + right, maxSum);

            var currentPath = node.Value + Math.Max(left, right);

            return currentPath > 0 ? currentPath : 0;
        }
    }
}