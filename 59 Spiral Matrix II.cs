public class Solution {
    public int[][] GenerateMatrix(int n) {
        int num = 1;
        int[][] ans = new int[n][];
        for (int i = 0; i < n; i++)
            ans[i] = new int[n];
        for (int i = 0, j = n - 1; i <= j; i++, j--)
        {
            for (int k = i; k <= j; k++)
                ans[i][k] = num++;
            for (int k = i + 1; k <= j; k++)
                ans[k][j] = num++;
            for (int k = j - 1; k >= i; k--)
                ans[j][k] = num++;
            for (int k = j - 1; k > i; k--)
                ans[k][i] = num++;
        }
        return ans;
    }
}