public class Solution {
    public int ProjectionArea(int[][] grid) {
        int total = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            int X = 0;
            int Y = 0;
            for (int j = 0; j < grid.Length; j++)
            {
                total += grid[i][j] > 0 ? 1 : 0;
                X = Math.Max(X, grid[i][j]);
                Y = Math.Max(Y, grid[j][i]);
            }
            total += X + Y;
        }
        return total;
    }
}