public class Solution {
    public int SingleNumber(int[] nums) {
        int i = 0;
        int result = 0;
        
        if (nums.Length == 1)
            return nums[0];
        
        while (nums.Length > i)
        {
            result = nums[i]^result;
            i++;
        }
        
        
        return result;
    }
}