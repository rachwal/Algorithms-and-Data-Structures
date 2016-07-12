namespace ProgramCreek
{
    public interface IMedianInAStream
    {
        void AddElement(int element);
        void BalanceHeaps();
        int GetMedian(int element);
        void Initialize(MaxHeap max, MinHeap min);
    }
}