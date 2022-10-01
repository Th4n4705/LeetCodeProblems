public class Solution {
    public int MaximumDifference(int[] nums) {
        int i = 0;
        int counter = nums[1] - nums[0];
        
        while (i < nums.Length)
        {
            int j = i + 1;
            while (j < nums.Length)
            {
                if (nums[j] - nums[i] > counter)
                    counter = nums[j] - nums[i];
                
                j++;
            }

            i++;
        }
        
        if (counter <= 0)
            return -1;
        return counter;
    }
}