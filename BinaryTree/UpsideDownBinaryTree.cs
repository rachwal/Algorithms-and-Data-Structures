using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class UpsideDownBinaryTree
    {
        public TreeNode ConvertTopDown(TreeNode root)
        {
            var current = root;
            TreeNode parent = null;
            TreeNode parentRight = null;

            while (current != null)
            {
                var left = current.Left;
                current.Left = parentRight;
                parentRight = current.Right;
                current.Right = parent;
                parent = current;
                current = left;
            }
            return parent;
        }

        public TreeNode ConvertBottomUp(TreeNode root)
        {
            return DfsBottomUp(root, null);
        }

        private TreeNode DfsBottomUp(TreeNode node, TreeNode parent)
        {
            if (node == null)
            {
                return parent;
            }

            var root = DfsBottomUp(node.Left, node);

            node.Left = parent == null ? null : parent.Right;
            node.Right = parent;

            return root;
        }
    }
}