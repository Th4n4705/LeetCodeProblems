public class Solution {
    public bool CanMakeSquare(char[][] grid) {
        for (int i = 0; i < grid.Length - 1; i++)
            for (int j = 0; j < grid[0].Length - 1; j++)
                if ((grid[i][j] == grid[i + 1][j] && (grid[i][j] == grid[i][j + 1] || grid[i][j] == grid[i + 1][j + 1])) ||
                    (grid[i][j + 1] == grid[i + 1][j + 1] && (grid[i][j + 1] == grid[i + 1][j] || grid[i][j] == grid[i + 1][j + 1])))
                    return true;
        return false;
    }
}