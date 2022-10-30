public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        Array.Sort(nums);
        int min = nums[nums.Length - 1] - nums[0];
        
        for (int i = 0; i < nums.Length; i++)
            if ( i + k - 1 < nums.Length && nums[i + k -  1] - nums[i] < min)
                min = nums[i + k -  1] - nums[i];
        
        return min;
    }
}