public class Solution {
    public int MajorityElement(int[] nums)
    {
        int i = 0;
        
        while (i < nums.Length)
        {
            if (Counter(nums, nums[i]) > (nums.Length / 2))
                return nums[i];
            i++;
        }
        return 0;
    }
    
    public int Counter(int[] nums, int target)
    {
        int i = 0;
        int counter = 0;
        
        while (i < nums.Length)
        {
            if (nums[i] == target)
                counter++;
            i++;
        }
        return counter;
    }
}