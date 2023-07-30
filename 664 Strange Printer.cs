public class Solution {
    public int StrangePrinter(string s) {
        int[,] dp = new int[s.Length, s.Length];
        for (int i = s.Length - 1; 0 <= i; --i)
        {
            dp[i, i] = 1;
            for (int j = i + 1; j < s.Length; ++j)
            {
                dp[i, j] = dp[i, j - 1] + 1;
                for (int k = i; k < j; ++k)
                    if (s[k] == s[j])
                        dp[i, j] = Math.Min(dp[i, j], dp[i, k] + (k + 1 <= j - 1 ? dp[k + 1, j - 1] : 0));
            }
        }
        return dp[0, s.Length - 1];
    }
}