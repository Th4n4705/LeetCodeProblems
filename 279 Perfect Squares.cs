public class Solution {
    public int NumSquares(int n) {
        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            int min = int.MaxValue;
            for (int j = 1; j * j <= i; j++)
                if (dp[i - j * j] < min)
                    min = dp[i - j * j];
            dp[i] = min + 1;
        }
        return dp[n];
    }
}