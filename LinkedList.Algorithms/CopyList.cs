using System.Collections.Generic;
using DataStructures;

namespace LeetCode.Algorithms.LinkedList.Algorithms
{
    public class CopyList
    {
        public RandomListNode Copy(RandomListNode node)
        {
            var map = new Dictionary<RandomListNode, RandomListNode>();
            var current = node;

            var head = new RandomListNode(0);
            var currentCopy = head;

            while (current != null)
            {
                currentCopy.Next = new RandomListNode(current.Value);
                map[current] = currentCopy.Next;

                current = current.Next;
                currentCopy = currentCopy.Next;
            }

            current = node;
            currentCopy = head;

            while (current != null)
            {
                currentCopy.Next.Random = current.Random != null ? map[current.Random] : null;
                current = current.Next;
                currentCopy = currentCopy.Next;
            }
            return head.Next;
        }

        public RandomListNode CopyModify(RandomListNode node)
        {
            var current = node;
            while (current != null)
            {
                var next = current.Next;
                var copy = new RandomListNode(current.Value);

                current.Next = copy;
                copy.Next = next;
                current = next;
            }

            current = node;

            while (current != null)
            {
                current.Next.Random = current.Random != null ? current.Random.Next : null;
                current = current.Next.Next;
            }

            current = node;

            var head = current != null ? current.Next : null;
            while (current != null)
            {
                var copy = current.Next;
                current.Next = copy.Next;

                current = current.Next;
                copy.Next = current != null ? current.Next : null;
            }
            return head;
        }
    }
}