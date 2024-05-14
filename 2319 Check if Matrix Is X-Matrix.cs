public class Solution {
    public bool CheckXMatrix(int[][] grid) {
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[i].Length; j++)
                if ((grid[i][j] == 0) == (i == j || i + j == grid.Length - 1))
                    return false;
        return true;
    }
}