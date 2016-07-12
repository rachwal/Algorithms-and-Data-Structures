using DataStructures;

namespace LeetCode.Algorithms.LinkedList.Algorithms
{
    public class AddTwo
    {
        public ListNode Add(ListNode firstList, ListNode secondList)
        {
            var head = new ListNode();
            var first = firstList;
            var second = secondList;
            var current = head;
            var carry = 0;

            while (first != null || second != null)
            {
                var x = first?.Value ?? 0;
                var y = second?.Value ?? 0;

                var digit = carry + x + y;

                carry = digit/10;
                current.Next = new ListNode(digit%10);
                current = current.Next;

                first = first?.Next;
                second = second?.Next;
            }
            return head.Next;
        }
    }
}