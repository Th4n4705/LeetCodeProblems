public class Solution {
    public int MinimumSum(int[] nums) {
        int ans = Int32.MaxValue;
        for (int i = 0; i < nums.Length - 2; i++)
            for (int j = i + 1; j < nums.Length - 1; j++)
                for (int k = j + 1; k < nums.Length; k++)
                    if (nums[i] < nums[j] && nums[k] < nums[j])
                        ans = Math.Min(ans, nums[i] + nums[j] + nums[k]);
        return ans != Int32.MaxValue ? ans : -1;
    }
}