public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int max = 0;
        int curr = nums[0];
        for (int i = 1; i < nums.Length; i++)
            if (nums[i - 1] < nums[i])
                curr += nums[i];
            else
            {
                max = Math.Max(max, curr);
                curr = nums[i];
            }
        return max = Math.Max(max, curr);
    }
}