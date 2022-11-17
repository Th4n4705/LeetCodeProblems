public class Solution {
    public int AverageValue(int[] nums) {
        int counter = 0;
        int total = 0;
        
        for (int i = 0; i< nums.Length; i++)
        {
            if (nums[i] % 2 == 0 && nums[i] % 3 == 0)
            {
                counter++;
                total += nums[i];
            }
        }
        
        if (counter == 0)
            return 0;
        return total / counter;
    }
}