using DataStructures;

namespace ProgramCreek
{
    public class ConvertSortedListToBinarySearchTree
    {
        private ListNode Head { get; set; }

        public TreeNode Convert(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            Head = head;

            var length = GetListLength(head);

            return ConvertInOrder(0, length - 1);
        }

        private int GetListLength(ListNode head)
        {
            var element = head;
            var length = 0;

            while (element != null)
            {
                length++;
                element = element.Next;
            }

            return length;
        }

        private TreeNode ConvertInOrder(int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var middle = (start + end)/2;

            var left = ConvertInOrder(start, middle - 1);

            var root = new TreeNode(Head.Value);
            Head = Head.Next;

            var right = ConvertInOrder(middle + 1, end);

            root.Left = left;
            root.Right = right;
            return root;
        }
    }
}