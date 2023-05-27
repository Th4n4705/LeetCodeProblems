public class Solution {
    public string StoneGameIII(int[] stoneValue) {
        int n = stoneValue.Length;
        int[] dp = new int[3];
        for (int i = n - 1; i >= 0; --i)
        {
            int first = stoneValue[i] - dp[(i + 1) % 3];
            int second = i + 1 < n ? stoneValue[i] + stoneValue[i + 1] - dp[(i + 2) % 3] : int.MinValue;
            int third =  i + 2 < n ? stoneValue[i] + stoneValue[i + 1] + stoneValue[i + 2] 
                - dp[(i + 3) % 3] : int.MinValue;
            dp[i % 3] = Math.Max(first, Math.Max(second, third));
        }
        return dp[0] switch{
            > 0 => "Alice",
            < 0 => "Bob",
            _ => "Tie"
        };
    }
}