public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        k = k % (grid.Length * grid[0].Length);
        while (k != 0)
        {
            int tmp = grid[grid.Length - 1][grid[0].Length - 1];
            int tmp2 = 0;
            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                {
                    tmp2 = grid[i][j];
                    grid[i][j] = tmp;
                    tmp = tmp2;
                }
            k--;
        }
        
        IList<IList<int>> ans = new List<IList<int>>();
        foreach (var row in grid) {
            ans.Add(new List<int>(row));
        }
        return ans;
    }
}