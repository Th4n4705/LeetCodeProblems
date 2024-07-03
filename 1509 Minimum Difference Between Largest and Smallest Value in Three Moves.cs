public class Solution {
    public int MinDifference(int[] nums) {
        if (nums.Length <= 3)
            return 0;
        Array.Sort(nums);
        int i = 0;
        int r = nums.Length - 4;
        int ans = Int32.MaxValue;
        while (i <= 3)
        {
            ans = Math.Min(ans, nums[r + i] - nums[i]);
            i++;
        }
        return ans;
    }
}