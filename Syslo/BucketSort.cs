using System.Collections.Generic;
using Syslo.Data_Structures;

namespace Syslo
{
    public class BucketSort
    {
        private Queue<ListNode>[] buckets;

        public IEnumerable<ListNode> Sort(Queue<ListNode> input)
        {
            buckets = new Queue<ListNode>[10];

            for (var digit = 1; digit < 10; digit++)
            {
                buckets[digit] = new Queue<ListNode>();
            }

            var result = new List<ListNode>();

            var position = 0;

            while (input.Count > 0)
            {
                while (input.Count > 0)
                {
                    var item = input.Dequeue();

                    var head = item;
                    var digitIndex = 0;
                    var digit = head.Value;

                    while (head != null && digitIndex < position)
                    {
                        digit = head.Value;
                        head = head.Next;
                        digitIndex++;
                    }

                    if (digitIndex == position)
                    {
                        buckets[digit].Enqueue(item);
                    }
                    else
                    {
                        result.Add(item);
                    }
                }

                for (var i = 1; i < 10; i++)
                {
                    var bucket = buckets[i];
                    while (bucket.Count > 0)
                    {
                        input.Enqueue(bucket.Dequeue());
                    }
                }
                position++;
            }
            return result;
        }
    }
}