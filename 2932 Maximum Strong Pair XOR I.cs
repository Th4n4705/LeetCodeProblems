public class Solution {
    public int MaximumStrongPairXor(int[] nums) {
        int ans = 0;
        for (int i = 0; i < nums.Length - 1; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (Math.Abs(nums[i] - nums[j]) <= Math.Min(nums[i], nums[j]))
                    ans = Math.Max(ans, nums[i] ^ nums[j]);
        return ans;
    }
}