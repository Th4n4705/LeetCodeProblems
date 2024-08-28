public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        while (k > 0)
        {
            int index = Array.IndexOf(nums, nums.Min());
            nums[index] = nums[index] * multiplier;
            k--;
        }
        return nums;
    }
}