public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        int[][] ans = new int[grid.Length - 2][];
        for (int i = 0; i < grid.Length - 2; i++)
        {
            ans[i] = new int[grid.Length - 2];
            for (int j = 0; j < grid.Length - 2; j++)
                ans[i][j] = MaxFinder(i, j, grid);
        }
        return ans;
    }

    private int MaxFinder(int x, int y, int[][] grid)
    {
        int max = int.MinValue;
        for (int i = x; i < x + 3; i++)
            for (int j = y; j < y + 3; j++)
                if (max < grid[i][j])
                    max = grid[i][j];
        return max;
    }
}