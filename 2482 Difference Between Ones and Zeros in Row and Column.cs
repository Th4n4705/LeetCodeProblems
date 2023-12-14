public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        int[][] ans = new int[grid.Length][];
        int[] rows = new int[grid.Length];
        int[] cols = new int[grid[0].Length];
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[i].Length; j++)
            {
                cols[j] += grid[i][j] == 1 ? 1 : -1;
                rows[i] += grid[i][j] == 1 ? 1 : -1;
            }
        for (int i = 0; i < grid.Length; i++)
        {
            ans[i] = new int[grid[i].Length];
            for (int j = 0; j < grid[i].Length; j++)
                ans[i][j] = rows[i] + cols[j];
        }
        return ans;
    }
}