using DataStructures;

namespace LeetCode.Algorithms.LinkedList.Algorithms
{
    public class MergeTwo
    {
        public ListNode Merge(ListNode first, ListNode second)
        {
            var head = new ListNode(0);
            var node = head;
            while (first != null && second != null)
            {
                if (first.Value < second.Value)
                {
                    node.Next = first;
                    first = first.Next;
                }
                else
                {
                    node.Next = second;
                    second = second.Next;
                }
                node = node.Next;
            }

            if (first != null)
            {
                node.Next = first;
            }

            if (second != null)
            {
                node.Next = second;
            }
            return head.Next;
        }
    }
}