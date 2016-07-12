using System;
using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class BinarySearchTreeTopDownValidator : IBinarySearchTreeValidator
    {
        public bool IsValid(TreeNode root)
        {
            return IsValid(root, int.MinValue, int.MaxValue);
        }

        private bool IsValid(TreeNode node, IComparable minValue, IComparable maxValue)
        {
            if (node == null || minValue == null)
            {
                return true;
            }

            return minValue.CompareTo(maxValue) < 0
                   && IsValid(node.Left, minValue, node.Value)
                   && IsValid(node.Right, node.Value, maxValue);
        }
    }
}