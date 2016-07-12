namespace LeetCode.Algorithms.ArrayAndString
{
    public interface IReader
    {
        unsafe int Read4(char* buffer);
    }

    public class ReaderStub : IReader
    {
        private const string Content = "abcdefghijklmnopqrstuvwxyz";
        private int index;

        public unsafe int Read4(char* buffer)
        {
            var difference = Content.Length - index;
            var max = difference > 3 ? 4 : difference;
            for (var i = 0; i < max; i++)
            {
                buffer[i] = Content[index + i];
            }
            index += max;
            return max;
        }
    }
}