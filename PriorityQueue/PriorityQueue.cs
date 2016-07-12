using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class PriorityQueue<T> where T : IComparable<T>, IEnumerable<T>
    {
        private readonly List<T> data = new List<T>();

        public void Enqueue(T item)
        {
            data.Add(item);
            var childIndex = data.Count - 1;
            while (childIndex > 0)
            {
                var parentIndex = (childIndex - 1)/2;
                if (data[childIndex].CompareTo(data[parentIndex]) >= 0)
                {
                    break;
                }

                var tmp = data[childIndex];
                data[childIndex] = data[parentIndex];
                data[parentIndex] = tmp;
                childIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            var lastIndex = data.Count - 1;
            var frontItem = data[0];
            data[0] = data[lastIndex];
            data.RemoveAt(lastIndex);

            --lastIndex;
            var parentIndex = 0;
            while (true)
            {
                var childIndex = parentIndex*2 + 1;
                if (childIndex > lastIndex)
                {
                    break;
                }

                var rightChild = childIndex + 1;
                if (rightChild <= lastIndex && data[rightChild].CompareTo(data[childIndex]) < 0)
                {
                    childIndex = rightChild;
                }

                if (data[parentIndex].CompareTo(data[childIndex]) <= 0)
                {
                    break;
                }

                var tmp = data[parentIndex];
                data[parentIndex] = data[childIndex];
                data[childIndex] = tmp;
                parentIndex = childIndex;
            }
            return frontItem;
        }
    }
}