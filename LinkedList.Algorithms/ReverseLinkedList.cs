using DataStructures;

namespace LeetCode.Algorithms.LinkedList.Algorithms
{
    public class ReverseLinkedList
    {
        public ListNode Reverse(ListNode list)
        {
            ListNode reversed = null;
            while (list != null)
            {
                var next = list.Next;
                list.Next = reversed;
                reversed = list;
                list = next;
            }
            return reversed;
        }
    }
}