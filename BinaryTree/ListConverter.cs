using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class ListConverter
    {
        private ListNode list;

        public ListNode Convert(TreeNode root)
        {
            list = new ListNode();
            var head = list;

            ConvertToList(root);

            return head.Next;
        }

        private void ConvertToList(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            ConvertToList(node.Left);

            list.Next = new ListNode {Value = node.Value};
            list = list.Next;

            ConvertToList(node.Right);
        }
    }
}