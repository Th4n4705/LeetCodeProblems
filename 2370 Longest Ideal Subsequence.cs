public class Solution {
    public int LongestIdealString(string s, int k) {
        int max = 0;
        int[] dp = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            char current = s[i];
            int tmp = 0;
            int l = current - 'a';
            for (int j = 0; j < 26; j++)
                if (Math.Abs(current - 'a' - j) <= k)
                    tmp = Math.Max(tmp, dp[j]);
            dp[l] = tmp + 1;
            max = Math.Max(max, dp[l]);
        }
        return max;
    }
}