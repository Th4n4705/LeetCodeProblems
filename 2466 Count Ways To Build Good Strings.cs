public class Solution {
    private const int MODULAR = 1_000_000_000 + 7;
    public int CountGoodStrings(int low, int high, int zero, int one) {
        int[] dp = new int[high + 1];
        dp[0] = 1;
        int res = 0;
        for (int i = 1; i <= high; ++i)
        {
            if (i >= zero)
                dp[i] = (dp[i] + dp[i - zero]) % MODULAR;
            if (i >= one)
                dp[i] = (dp[i] + dp[i - one]) % MODULAR;
            if (i >= low)
                res = (res + dp[i]) % MODULAR;
        }
        return res;
    }
}