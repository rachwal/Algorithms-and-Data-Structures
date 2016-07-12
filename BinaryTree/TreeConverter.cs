using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class TreeConverter
    {
        private ListNode head;

        public TreeNode Convert(ListNode list)
        {
            head = list;
            var size = GetListSize(list, 0);
            return ConvertToTree(0, size - 1);
        }

        private int GetListSize(ListNode node, int count)
        {
            if (node == null)
            {
                return count;
            }
            count++;
            node = node.Next;
            count = GetListSize(node, count);
            return count;
        }

        private TreeNode ConvertToTree(int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            var middle = (start + end)/2;

            var left = ConvertToTree(start, middle - 1);

            var node = new TreeNode {Value = head.Value};
            head = head.Next;

            var right = ConvertToTree(middle + 1, end);

            node.Left = left;
            node.Right = right;
            return node;
        }
    }
}