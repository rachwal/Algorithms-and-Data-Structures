using System.Collections.Generic;

namespace LeetCode.Algorithms.Misc
{
    public class SpiralMatrix
    {
        public List<int> SpiralOrder(int[][] matrix)
        {
            var elements = new List<int>();
            if (matrix.Length == 0)
            {
                return elements;
            }
            var rows = matrix.Length;
            var cols = matrix[0].Length;

            var row = 0;
            var col = -1;

            while (true)
            {
                for (var i = 0; i < cols; i++)
                {
                    elements.Add(matrix[row][++col]);
                }

                if (--rows == 0)
                {
                    break;
                }

                for (var i = 0; i < rows; i++)
                {
                    elements.Add(matrix[++row][col]);
                }

                if (--cols == 0)
                {
                    break;
                }

                for (var i = 0; i < cols; i++)
                {
                    elements.Add(matrix[row][--col]);
                }

                if (--rows == 0)
                {
                    break;
                }

                for (var i = 0; i < rows; i++)
                {
                    elements.Add(matrix[--row][col]);
                }

                if (--cols == 0)
                {
                    break;
                }
            }
            return elements;
        }
    }
}