using System.Collections.Generic;

namespace Syslo.Data_Structures
{
    public class AdjacencyList
    {
        private readonly ListNode head = new ListNode();

        public AdjacencyList(IEnumerable<int> list)
        {
            AddList(list);
        }

        public ListNode Head => head.Next;

        public void Add(int id)
        {
            var node = head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new ListNode(id);
        }

        public void AddList(IEnumerable<int> list)
        {
            foreach (var element in list)
            {
                Add(element);
            }
        }
    }
}