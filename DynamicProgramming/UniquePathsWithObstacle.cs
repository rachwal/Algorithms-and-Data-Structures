namespace LeetCode.Algorithms.DynamicProgramming
{
    public class UniquePathsWithObstacle
    {
        public int GetNumberOfUniquePaths(int[][] obstacleGrid)
        {
            var numberOfRows = obstacleGrid.Length;
            if (numberOfRows == 0)
            {
                return 0;
            }

            var numberOfColumns = obstacleGrid[0].Length;

            var mat = new int[numberOfRows + 1][];
            for (var i = 0; i <= numberOfRows; i++)
            {
                mat[i] = new int[numberOfColumns + 1];
            }

            mat[numberOfRows - 1][numberOfColumns] = 1;
            for (var row = numberOfRows - 1; row >= 0; row--)
            {
                for (var column = numberOfColumns - 1; column >= 0; column--)
                {
                    mat[row][column] = obstacleGrid[row][column] == 1 ? 0 : mat[row + 1][column] + mat[row][column + 1];
                }
            }
            return mat[0][0];
        }
    }
}