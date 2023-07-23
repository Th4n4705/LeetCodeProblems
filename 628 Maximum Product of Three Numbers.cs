public class Solution {
    public int MaximumProduct(int[] nums) {
        Array.Sort(nums);
        int left = -1;
        int ans = 1;
        if (nums[1] < 0 && 0 < nums[nums.Length - 1])
            left = nums[0] * nums[1] * nums[nums.Length - 1];
        else
            left = nums[nums.Length - 3] * nums[nums.Length - 2] * nums[nums.Length - 1];
        for (int i = nums.Length - 1; i > nums.Length - 4; i--)
            ans *= nums[i];
        return Math.Max(ans, left);
    }
}