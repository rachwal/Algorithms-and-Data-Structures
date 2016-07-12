using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class FindKLargest
    {
        private int index;
        private int target;

        public int FindKMax(TreeNode root, int k)
        {
            target = int.MinValue;
            index = 0;
            FindKth(root, k);
            return target;
        }

        private void FindKth(TreeNode node, int stop)
        {
            if (node == null)
            {
                return;
            }

            FindKth(node.Right, stop);

            if (index < stop)
            {
                index++;
                target = node.Value;
            }
            else
            {
                return;
            }

            FindKth(node.Left, stop);
        }
    }
}