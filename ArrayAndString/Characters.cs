using System;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class Characters
    {
        private readonly char[] lastRead = new char[4];
        private readonly IReader reader;
        private int offset;

        public Characters(IReader r)
        {
            reader = r;
        }

        public unsafe int ReadOnce(char[] buffer, int n)
        {
            var totalBytesRead = 0;
            var bytesRead = -1;
            var currentBuffer = new char[4];

            fixed (char* buff = currentBuffer)
            {
                while (totalBytesRead < n && bytesRead != 0)
                {
                    bytesRead = reader.Read4(buff);
                    var missingBytes = n - totalBytesRead;
                    var bytesToCopy = Math.Min(missingBytes > 4 ? 4 : missingBytes, bytesRead);
                    for (var i = 0; i < bytesToCopy; i++)
                    {
                        buffer[totalBytesRead + i] = buff[i];
                    }
                    totalBytesRead += bytesToCopy;
                }
            }
            return totalBytesRead;
        }

        public unsafe int ReadMany(char[] buffer, int n)
        {
            var totalBytesRead = 0;
            var bytesRead = -1;
            var currentBuffer = new char[4];

            if (offset > 0)
            {
                for (var i = 0; i < offset; i++)
                {
                    buffer[i] = lastRead[i];
                }
            }

            totalBytesRead += offset;

            fixed (char* buff = currentBuffer)
            {
                while (totalBytesRead < n && bytesRead != 0)
                {
                    bytesRead = reader.Read4(buff);

                    var missingBytes = n - totalBytesRead;

                    var bytesToCopy = Math.Min(missingBytes > 4 ? 4 : missingBytes, bytesRead);

                    for (var i = 0; i < bytesToCopy; i++)
                    {
                        buffer[totalBytesRead + i] = buff[i];
                    }
                    totalBytesRead += bytesToCopy;

                    offset = bytesRead - bytesToCopy;

                    if (offset <= 0)
                    {
                        continue;
                    }

                    for (var i = 0; i < offset; i++)
                    {
                        lastRead[i] = buff[bytesToCopy + i];
                    }
                }
            }
            return totalBytesRead;
        }
    }
}