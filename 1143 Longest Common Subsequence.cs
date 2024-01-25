public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int[] dp = new int[text2.Length + 1];
        for (int i = 1; i <= text1.Length; i++)
        {
            int prev = 0;
            for (int j = 1; j <= text2.Length; j++)
            {
                int tmp = dp[j];
                if (text1[i - 1] == text2[j - 1])
                    dp[j] = prev + 1;
                else
                    dp[j] = Math.Max(dp[j], dp[j - 1]);
                prev = tmp;
            }
        }
        return dp[text2.Length];
    }
}