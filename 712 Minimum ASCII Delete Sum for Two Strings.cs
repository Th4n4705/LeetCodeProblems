public class Solution {
    public int MinimumDeleteSum(string s1, string s2) {
        int[,] dp = new int[s1.Length + 1, s2.Length + 1];
        for (int i = 1; i <= s1.Length; i++)
            for (int j = 1; j <= s2.Length; j++)
                if (s1[i - 1] == s2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + (int)s1[i - 1];
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < s1.Length; i++)
            sum1 += (int)s1[i];
        for (int i = 0; i < s2.Length; i++)
            sum2 += (int)s2[i];
        int Sum = dp[s1.Length, s2.Length];
        return sum1 + sum2 - 2 * Sum;
    }
}