public class Solution {
    public int[] FindColumnWidth(int[][] grid) {
        int l = grid.Length;
        int l0 = grid[0].Length;
        int[] ans = new int[l0];
        for (int i = 0; i < l0; i++)
        {
            int max = int.MinValue;
            for (int j = 0; j < l; j++)
                max = Math.Max(max, grid[j][i].ToString().Length);
            ans[i] = max;
        }
        return ans;
    }
}