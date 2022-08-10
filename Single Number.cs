public class Solution {
    public int SingleNumber(int[] nums) {
        int i = 0;
        int j;
        
        if (nums.Length == 1)
            return nums[0];
        
        while (nums.Length > i)
        {
            j = i + 1;
            while (nums.Length > j)
            {
                if (nums[i] == nums[j])
                {
                    nums[i] = -30001;
                    nums[j] = -30001;
                }
                j++;
            }
            if (nums[i] != -30001)
                return nums[i];
            i++;
        }
        
        return nums[i];
    }
}