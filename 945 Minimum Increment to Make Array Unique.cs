public class Solution {
    public int MinIncrementForUnique(int[] nums) {
        Array.Sort(nums);
        int n = 0;
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] <= nums[i - 1])
            {
                int increment = nums[i - 1] - nums[i] + 1;
                nums[i] += increment;
                n += increment;
            }
        return n;
    }
}