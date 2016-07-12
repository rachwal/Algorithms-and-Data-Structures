using System;

namespace ProgramCreek
{
    public class MinimumPathSum
    {
        public int MinPathSumDfs(int[][] grid)
        {
            return Dfs(0, 0, grid);
        }

        private int Dfs(int row, int column, int[][] grid)
        {
            if (row == grid.Length - 1 && column == grid[0].Length - 1)
            {
                return grid[row][column];
            }

            if (row < grid.Length - 1 && column < grid[0].Length - 1)
            {
                var stepRight = grid[row][column] + Dfs(row + 1, column, grid);
                var stepDown = grid[row][column] + Dfs(row, column + 1, grid);
                return Math.Min(stepRight, stepDown);
            }

            if (row < grid.Length - 1)
            {
                return grid[row][column] + Dfs(row + 1, column, grid);
            }

            if (column < grid[0].Length - 1)
            {
                return grid[row][column] + Dfs(row, column + 1, grid);
            }

            return 0;
        }

        public int MinPathSumDp(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            var rowsCount = grid.Length;
            var columnsCount = grid[0].Length;

            var dp = new int[rowsCount][];
            for (var row = 0; row < rowsCount; row++)
            {
                dp[row] = new int[columnsCount];
            }

            dp[0][0] = grid[0][0];

            for (var column = 1; column < columnsCount; column++)
            {
                dp[0][column] = dp[0][column - 1] + grid[0][column];
            }

            for (var row = 1; row < rowsCount; row++)
            {
                dp[row][0] = dp[row - 1][0] + grid[row][0];
            }

            for (var row = 1; row < rowsCount; row++)
            {
                for (var column = 1; column < columnsCount; column++)
                {
                    if (dp[row - 1][column] > dp[row][column - 1])
                    {
                        dp[row][column] = dp[row][column - 1] + grid[row][column];
                    }
                    else
                    {
                        dp[row][column] = dp[row - 1][column] + grid[row][column];
                    }
                }
            }
            return dp[rowsCount - 1][columnsCount - 1];
        }
    }
}