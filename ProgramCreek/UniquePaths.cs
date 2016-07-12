namespace ProgramCreek
{
    public class UniquePaths
    {
        public int UniquePathsDfs(int rowsCount, int columnsCount)
        {
            return Dfs(0, 0, rowsCount, columnsCount);
        }

        private int Dfs(int row, int column, int rowsCount, int columnsCount)
        {
            if (row == rowsCount - 1 && column == columnsCount - 1)
            {
                return 1;
            }

            if (row < rowsCount - 1 && column < columnsCount - 1)
            {
                return Dfs(row + 1, column, rowsCount, columnsCount) + Dfs(row, column + 1, rowsCount, columnsCount);
            }

            if (row < rowsCount - 1)
            {
                return Dfs(row + 1, column, rowsCount, columnsCount);
            }

            if (column < columnsCount - 1)
            {
                return Dfs(row, column + 1, rowsCount, columnsCount);
            }

            return 0;
        }

        public int UniquePathsDp(int rowsCount, int columnsCount)
        {
            if (rowsCount == 0 || columnsCount == 0)
            {
                return 0;
            }

            if (rowsCount == 1 || columnsCount == 1)
            {
                return 1;
            }

            var dp = new int[rowsCount][];
            for (var row = 0; row < rowsCount; row++)
            {
                dp[row] = new int[columnsCount];
                dp[row][0] = 1;
                for (var column = 0; column < columnsCount; column++)
                {
                    dp[0][column] = 1;
                }
            }

            for (var row = 1; row < rowsCount; row++)
            {
                for (var column = 1; column < columnsCount; column++)
                {
                    dp[row][column] = dp[row - 1][column] + dp[row][column - 1];
                }
            }

            return dp[rowsCount - 1][columnsCount - 1];
        }
    }
}