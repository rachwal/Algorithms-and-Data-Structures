using DataStructures;

namespace LeetCode.Algorithms.LinkedList.Algorithms
{
    public class SwapNodes
    {
        public ListNode Swap(ListNode node)
        {
            var head = new ListNode(0) {Next = node};

            var current = node;
            var previous = head;

            while (current != null && current.Next != null)
            {
                var next = current.Next;
                var nextNext = current.Next.Next;

                previous.Next = next;
                next.Next = current;
                current.Next = nextNext;

                previous = current;
                current = nextNext;
            }
            return head.Next;
        }
    }
}