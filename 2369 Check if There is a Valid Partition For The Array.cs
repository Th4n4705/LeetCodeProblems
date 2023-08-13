public class Solution {
    public bool ValidPartition(int[] nums) {
        return Helper_ValidPartition(nums, nums.Length - 1);
    }

    private bool Helper_ValidPartition(int[] nums, int end)
    {
        if (CheckValidity(nums, 0, end) || (CheckValidity(nums, end - 2, end) && Helper_ValidPartition(nums, end - 3)) || (CheckValidity(nums, end - 1, end) && Helper_ValidPartition(nums, end - 2)))
            return true;
        return false;
    }

    private bool CheckValidity(int[] nums, int start, int end)
    {
        if (start < 0 || end >= nums.Length || end - start > 2 || end - start == 0)
            return false;
        if (end - start == 1)
             return nums[start] == nums[end];
        return (nums[start] == nums[start + 1] && nums[start] == nums[start + 2]) || (nums[start + 1] - nums[start] == 1 && nums[end] - nums[start] == 2);
    }
}