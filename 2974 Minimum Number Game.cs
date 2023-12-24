public class Solution {
    public int[] NumberGame(int[] nums) {
        Array.Sort(nums, (a, b) => a.CompareTo(b));
        for (int i = 0; i < nums.Length; i += 2)
            (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
        return nums;
    }
}