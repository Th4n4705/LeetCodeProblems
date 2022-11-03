public class Solution {
    public int FindGCD(int[] nums) {
        Array.Sort(nums);
        int min = nums[0];
        int max = nums[nums.Length - 1];
        
        if (min == max)
            return min;
        
        int i = min;
        while (i >= 1)
        {
            if (min % i == 0 && max % i == 0)
                return i;
            i--;
        }
        return 1;
    }
}