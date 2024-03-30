public class Solution {
    public int MinimumSubarrayLength(int[] nums, int k) {
        int ans = Int32.MaxValue;
        for (int i = 0; i < nums.Length; i++)
            for (int j = i; j < nums.Length; j++)
                if (Helper(nums, i, j) >= k)
                    ans = Math.Min(ans, j - i + 1);
        return ans == Int32.MaxValue ? -1 : ans;
    }

    int Helper(int[] nums, int i, int j)
    {
        int ans = nums[i];
        for (int k = i + 1; k <= j; k++)
            ans |= nums[k];
        return ans;
    }
}