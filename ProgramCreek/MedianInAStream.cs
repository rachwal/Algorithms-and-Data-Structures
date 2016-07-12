using System;

namespace ProgramCreek
{
    public class MedianInAStream : IMedianInAStream
    {
        private MaxHeap maxHeap = new MaxHeap();
        private MinHeap minHeap = new MinHeap();

        public void Initialize(MaxHeap max, MinHeap min)
        {
            maxHeap = max;
            minHeap = min;

            BalanceHeaps();
        }

        public void AddElement(int element)
        {
            if (element < maxHeap.Root())
            {
                maxHeap.Insert(element);
            }
            else
            {
                minHeap.Insert(element);
            }

            BalanceHeaps();
        }

        public void BalanceHeaps()
        {
            while (Math.Abs(maxHeap.Count() - minHeap.Count()) > 1)
            {
                if (maxHeap.Count() > minHeap.Count())
                {
                    var root = maxHeap.ExtractRoot();
                    minHeap.Insert(root);
                }
                else
                {
                    var root = minHeap.ExtractRoot();
                    maxHeap.Insert(root);
                }
            }
        }

        public int GetMedian(int element)
        {
            if (maxHeap.Count() == minHeap.Count())
            {
                return (maxHeap.Root() + minHeap.Root())/2;
            }

            if (maxHeap.Count() > minHeap.Count())
            {
                return maxHeap.Root();
            }

            return minHeap.Root();
        }
    }
}