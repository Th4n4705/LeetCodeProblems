public class Solution {
    public int FindMiddleIndex(int[] nums) {
        int  sum = 0;
        int leftSide = 0;
        
        for (int i = 0; i < nums.Length; i++)
            sum += nums[i];
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSide == sum  - leftSide - nums[i])
                return i;
            
            leftSide += nums[i];
        }
        
        return -1;
    }
}