public class Solution {
    public int NumDecodings(string s) {
        if (string.IsNullOrEmpty(s) || s[0] == '0')
            return 0;
        int[] dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = 1;
        for (int i = 2; i <= s.Length; i++)
        {
            int one = s[i - 1] - '0';
            int two = int.Parse(s.Substring(i - 2, 2));
            if (one != 0)
                dp[i] += dp[i - 1];
            if (10 <= two && two <= 26)
                dp[i] += dp[i - 2];
        }
        return dp[s.Length];
    }
}