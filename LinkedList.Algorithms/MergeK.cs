using System.Collections.Generic;
using DataStructures;

namespace LeetCode.Algorithms.LinkedList.Algorithms
{
    public class MergeK
    {
        public ListNode Merge(List<ListNode> lists)
        {
            if (lists == null || lists.Count == 0)
            {
                return null;
            }
            var rightIndex = lists.Count - 1;
            while (rightIndex > 0)
            {
                var leftIndex = 0;
                while (leftIndex < rightIndex)
                {
                    lists[leftIndex] = MergeTwo(lists[leftIndex], lists[rightIndex]);
                    leftIndex++;
                    rightIndex--;
                }
            }
            return lists[0];
        }

        private ListNode MergeTwo(ListNode first, ListNode second)
        {
            var head = new ListNode(0);
            var current = head;

            while (first != null && second != null)
            {
                if (first.Value < second.Value)
                {
                    current.Next = first;
                    first = first.Next;
                }
                else
                {
                    current.Next = second;
                    second = second.Next;
                }
                current = current.Next;
            }

            if (first != null)
            {
                current.Next = first;
            }
            if (second != null)
            {
                current.Next = second;
            }
            return head.Next;
        }
    }
}