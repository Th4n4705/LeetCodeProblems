public class Solution {
    public int FindChampion(int[][] grid) {
        for (int i = 0; i < grid.Length; i++)
        {
            int counter = 0;
            for (int j = 0; j < grid.Length; j++)
                if (grid[i][j] == 1)
                    counter++;
            if (counter == grid[i].Length - 1)
                return i;
        }
        return -1;
    }
}