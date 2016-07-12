namespace LeetCode.Algorithms.DynamicProgramming
{
    public class UniquePaths
    {
        private int[][] array;
        private int columnsNo = -1;
        private int rowsNo = -1;

        public int UniquePathsBacktrack(int numberOfRows, int numberOfColumns)
        {
            return Backtrack(0, 0, numberOfRows, numberOfColumns);
        }

        private int Backtrack(int row, int column, int numberOfRows, int numberOfColumns)
        {
            if (row == numberOfRows - 1 && column == numberOfColumns - 1)
            {
                return 1;
            }

            if (row >= numberOfRows || column >= numberOfColumns)
            {
                return 0;
            }

            return Backtrack(row + 1, column, numberOfRows, numberOfColumns) +
                   Backtrack(row, column + 1, numberOfRows, numberOfColumns);
        }

        public int UniquePathsBacktrackWithMemorization(int numberOfRows, int numberOfColumns)
        {
            if (columnsNo != numberOfColumns || rowsNo != numberOfRows)
            {
                Initialize(numberOfRows, numberOfColumns);
            }
            return BacktrackWithMemorization(0, 0, numberOfRows, numberOfColumns);
        }

        private void Initialize(int numberOfRows, int numberOfColumns)
        {
            rowsNo = numberOfRows;
            columnsNo = numberOfColumns;

            array = new int[numberOfRows + 1][];
            for (var row = 0; row <= numberOfRows; row++)
            {
                array[row] = new int[numberOfColumns + 1];
                for (var column = 0; column <= numberOfColumns; column++)
                {
                    array[row][column] = -1;
                }
            }
        }

        private int BacktrackWithMemorization(int row, int column, int numberOfRows, int numberOfColumns)
        {
            if (row == numberOfRows - 1 && column == numberOfColumns - 1)
            {
                return 1;
            }

            if (row >= numberOfRows || column >= numberOfColumns)
            {
                return 0;
            }

            if (array[row + 1][column] == -1)
            {
                array[row + 1][column] = BacktrackWithMemorization(row + 1, column, numberOfRows,
                    numberOfColumns);
            }

            if (array[row][column + 1] == -1)
            {
                array[row][column + 1] = BacktrackWithMemorization(row, column + 1, numberOfRows, numberOfColumns);
            }

            return array[row + 1][column] + array[row][column + 1];
        }

        public int UniquePathsBacktrackWithMemorizationBottomUp(int numberOfRows, int numberOfColumns)
        {
            var mat = new int[numberOfRows + 1][];
            for (var row = 0; row <= numberOfRows; row++)
            {
                mat[row] = new int[numberOfColumns + 1];
            }

            mat[numberOfRows - 1][numberOfColumns] = 1;

            for (var row = numberOfRows - 1; row >= 0; row--)
            {
                for (var column = numberOfColumns - 1; column >= 0; column--)
                {
                    mat[row][column] = mat[row + 1][column] + mat[row][column + 1];
                }
            }
            return mat[0][0];
        }
    }
}