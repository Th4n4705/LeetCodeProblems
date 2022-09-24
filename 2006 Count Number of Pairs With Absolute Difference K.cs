public class Solution {
    public int CountKDifference(int[] nums, int k)
    {
        int counter = 0;
        int i = 0;
        
        while (i < nums.Length)
        {
            int j = 0;
            while (j < nums.Length)
            {
                if (nums[i] - nums[j] == k)
                    counter++;
                
                j++;
            }
            i++;
        }
        
        return counter;
    }
}