public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        int[][] ans = new int[m][];
        if (m * n != original.Length)
            return new int[0][];
        for (int i = 0; i < m; i++)
        {
            ans[i] = new int[n];
            for (int j = 0; j < n; j++)
                ans[i][j] = original[i * n + j];
        }
        return ans;
    }
}