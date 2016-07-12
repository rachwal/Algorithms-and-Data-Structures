namespace ProgramCreek
{
    public interface IHeap
    {
        int Count();
        int ExtractRoot();
        void Insert(int x);
        int Root();
    }
}