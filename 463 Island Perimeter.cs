public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int perimeter = 0;
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    perimeter += 4;
                    if (i > 0 && grid[i - 1][j] == 1)
                        perimeter--;
                    if (j > 0 && grid[i][j - 1] == 1)
                        perimeter--;
                    if (i < grid.Length - 1 && grid[i + 1][j] == 1)
                        perimeter--;
                    if (j < grid[0].Length - 1 && grid[i][j + 1] == 1)
                        perimeter--;
                }
            }
        return perimeter;
    }
}