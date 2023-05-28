public class Solution {
    public int MinCost(int n, int[] cuts) {
        Array.Sort(cuts);
        int l = cuts.Length;
        int[,] dp = new int[l + 2, l + 2];
        for (var i = 2; i <= l + 1; i++)
            for (var j = 0; j + i <= l + 1; j++)
            {
                var k = j + i;
                dp[j, k] = int.MaxValue;
                for (var m = j + 1; m < k; m++)
                    dp[j, k] = Math.Min(dp[j, k], dp[j, m] + dp[m, k]);
                var left = j == 0 ? 0 : cuts[j - 1];
                var right = k == l + 1 ? n : cuts[k - 1];
                dp[j, k] += right - left;
            }
        return dp[0, l + 1];
    }
}