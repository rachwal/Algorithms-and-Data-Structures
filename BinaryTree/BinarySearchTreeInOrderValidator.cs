using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class BinarySearchTreeInOrderValidator : IBinarySearchTreeValidator
    {
        private TreeNode previous;

        public bool IsValid(TreeNode root)
        {
            previous = null;
            return IsMonotonicallyIncreasing(root);
        }

        private bool IsMonotonicallyIncreasing(TreeNode node)
        {
            if (node == null)
            {
                return true;
            }

            if (IsMonotonicallyIncreasing(node.Left))
            {
                if (previous != null && previous.Value >= node.Value)
                {
                    return false;
                }
                previous = node;
                return IsMonotonicallyIncreasing(node.Right);
            }
            return false;
        }
    }
}