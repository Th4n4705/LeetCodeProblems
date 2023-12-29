public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums, (a, b) => b - a);
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] < i + 1)
                return -1;
            else if (i == nums.Length - 1 || nums[i + 1] < i + 1)
                return i + 1;
        return -1;
    }
}