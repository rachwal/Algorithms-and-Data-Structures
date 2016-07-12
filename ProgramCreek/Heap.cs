using System.Collections.Generic;

namespace ProgramCreek
{
    public abstract class Heap : IHeap
    {
        protected IList<int> Data { get; } = new List<int>();

        public int Root()
        {
            if (Data.Count > 0)
            {
                return Data[0];
            }
            return int.MinValue;
        }

        public int Count()
        {
            return Data.Count;
        }

        public void Insert(int x)
        {
            Data.Add(x);
            HeapifyUp();
        }

        public int ExtractRoot()
        {
            var element = Data[0];
            Data[0] = Data[Data.Count - 1];
            Data.RemoveAt(Data.Count - 1);
            HeapifyDown(0);
            return element;
        }

        protected abstract void HeapifyUp();

        protected abstract void HeapifyDown(int k);

        protected void Swap(int a, int b)
        {
            var temp = Data[a];
            Data[a] = Data[b];
            Data[b] = temp;
        }
    }
}