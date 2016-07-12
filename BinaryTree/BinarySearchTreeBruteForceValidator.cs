using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class BinarySearchTreeBruteForceValidator : IBinarySearchTreeValidator
    {
        public bool IsValid(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return IsSubtreeLessThan(root.Left, root.Value) && IsSubtreeGreaterThan(root.Right, root.Value) &&
                   IsValid(root.Left) && IsValid(root.Right);
        }

        private bool IsSubtreeLessThan(TreeNode node, int value)
        {
            if (node == null)
            {
                return true;
            }
            return node.Value < value && IsSubtreeLessThan(node.Left, value) && IsSubtreeLessThan(node.Right, value);
        }

        private bool IsSubtreeGreaterThan(TreeNode node, int value)
        {
            if (node == null)
            {
                return true;
            }
            return node.Value > value && IsSubtreeGreaterThan(node.Left, value) &&
                   IsSubtreeGreaterThan(node.Right, value);
        }
    }
}