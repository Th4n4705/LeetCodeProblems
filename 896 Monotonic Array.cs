public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool isIncreasing = false;
        if (nums[0] < nums[nums.Length - 1])
            isIncreasing = true;
        for(int i = 0; i < nums.Length - 1; i++)
            if ((isIncreasing && nums[i] > nums[i + 1]) || (!isIncreasing && nums[i] < nums[i + 1]))
                return false;
        return true;
    }
}