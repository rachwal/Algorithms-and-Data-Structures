namespace ProgramCreek
{
    public class MaxHeap : Heap
    {
        protected override void HeapifyUp()
        {
            var pos = Data.Count - 1;
            while (pos > 0 && Data[pos/2] < Data[pos])
            {
                var y = Data[pos];
                Data[pos] = Data[pos/2];
                Data[pos/2] = y;

                pos = pos/2;
            }
        }

        protected override void HeapifyDown(int k)
        {
            var current = k;
            if (2*k < Data.Count && Data[current] < Data[2*k])
            {
                current = 2*k;
            }

            if (2*k + 1 < Data.Count && Data[current] < Data[2*k + 1])
            {
                current = 2*k + 1;
            }

            if (current != k)
            {
                Swap(k, current);
                HeapifyDown(current);
            }
        }
    }
}