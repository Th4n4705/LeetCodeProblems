public class Solution {
    public int LongestPalindromeSubseq(string s) {
        int[][] dp = new int[s.Length][];
        for (int i=0;i<dp.Length;++i)
            dp[i] = new int[s.Length];
        
        return DFS(s, 0, s.Length-1, dp);
    }

    private int DFS(string s, int start, int end, int[][] dp)
    {
        if (start > end)
            return 0;
        if (start == end)
            return 1;
        if (dp[start][end] == 0)
        {
            if (s[start] == s[end])
                dp[start][end] = 2 + DFS(s, start + 1, end - 1, dp);
            else
            {
                int right = DFS(s, start + 1, end, dp);
                int left = DFS(s, start, end - 1, dp);
                dp[start][end] = Math.Max(right, left);
            }
        }
        return dp[start][end];
    }
}