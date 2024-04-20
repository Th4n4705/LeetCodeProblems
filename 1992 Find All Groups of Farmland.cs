public class Solution {
    public int[][] FindFarmland(int[][] land) {
        List<int[]> ans = new();
        for (int i = 0; i < land.Length; i++)
            for (int j = 0; j < land[i].Length; j++)
                if (land[i][j] == 1)
                    ans.Add(LandBoundaryChecker(land, i, j));
        return ans.ToArray();
    }

    int[] LandBoundaryChecker(int[][] land, int i, int j)
    {
        int row = i;
        int col = j;
        while (row < land.Length && land[row][j] == 1)
            row++;
        while (col < land[i].Length && land[i][col] == 1)
            col++;
        for (int row2 = i; row2 < row; row2++)
            for (int col2 = j; col2 < col; col2++)
                land[row2][col2] = 0;
        return new int[]{i, j, row - 1, col - 1};
    }
}