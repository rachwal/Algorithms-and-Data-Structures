using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class BinaryTreeConverter
    {
        private ListNode list;

        public TreeNode Convert(ListNode head)
        {
            var n = 0;
            var current = head;

            while (current != null)
            {
                current = current.Next;
                n++;
            }
            list = head;
            return SortedLinkedListToBst(0, n - 1);
        }

        private TreeNode SortedLinkedListToBst(int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            var middle = (start + end)/2;

            var leftChild = SortedLinkedListToBst(start, middle - 1);

            var parent = new TreeNode(list.Value);

            parent.Left = leftChild;

            list = list.Next;

            parent.Right = SortedLinkedListToBst(middle + 1, end);

            return parent;
        }

        public TreeNode Convert(int[] array)
        {
            return SortedArrayToBst(array, 0, array.Length - 1);
        }

        private TreeNode SortedArrayToBst(int[] array, int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            var middle = (start + end)/2;
            var node = new TreeNode(array[middle])
            {
                Left = SortedArrayToBst(array, start, middle - 1),
                Right = SortedArrayToBst(array, middle + 1, end)
            };
            return node;
        }
    }
}