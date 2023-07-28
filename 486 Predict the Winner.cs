public class Solution {
    public bool PredictTheWinner(int[] nums) {
        int[,] dp = new int[nums.Length, nums.Length];
        for (int i = 0; i < nums.Length; i++)
            dp[i, i] = nums[i];
        for (int k = 1; k < nums.Length; k++)
            for (int i = 0; i < nums.Length - k; i++)
            {
                int j = i + k;
                dp[i, j] = Math.Max(nums[i] - dp[i + 1, j], nums[j] - dp[i, j - 1]);
            }
        return 0 <= dp[0, nums.Length - 1];
    }
}