public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int[] grids = new int[grid.Length * grid.Length + 1];
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid.Length; j++)
                grids[grid[i][j]]++;
        int a = -1;
        int b = -1;
        for (int i = 1; i < grids.Length; i++)
            if (grids[i] > 1)
                a = i;
            else if (grids[i] == 0)
                b = i;
        return new int[]{a, b};
    }
}