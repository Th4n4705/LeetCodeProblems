public class Solution {
    public int SurfaceArea(int[][] grid) {
        int ar = 2 * grid.Length * grid.Length;
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid.Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    ar -= 2;
                    continue;
                }
                ar += GetSideWall (grid, grid[i][j], i - 1, j);
                ar += GetSideWall (grid, grid[i][j], i + 1, j);
                ar += GetSideWall (grid, grid[i][j], i, j - 1);
                ar += GetSideWall (grid, grid[i][j], i, j + 1);
            }
        return ar;
    }

    int GetSideWall (int[][] grid, int h, int r, int c)
    {
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[r].Length)
            return h;
        if (h > grid[r][c])
            return h - grid[r][c];
        return 0;
    }
}