using System;

namespace DataStructures
{
    public class ComparableListNode : ListNode, IComparable<ListNode>
    {
        public ComparableListNode(int value) : base(value)
        {
        }

        public int CompareTo(ListNode node)
        {
            if (node == null)
            {
                return 1;
            }
            if (Value > node.Value)
            {
                return 1;
            }
            if (Value < node.Value)
            {
                return -1;
            }
            return 0;
        }
    }
}