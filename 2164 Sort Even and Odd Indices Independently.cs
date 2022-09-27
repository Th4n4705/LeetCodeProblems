public class Solution {
    public int[] SortEvenOdd(int[] nums) {
        int i = 0;
        int j = 1;
        
        while (i < nums.Length && j < nums.Length)
        {
            int  i2 = i;
            int  j2 = j;
            while (i2 < nums.Length || j2 < nums.Length)
            {
                int tmp;
                if (i2 < nums.Length && nums[i] > nums[i2])
                {
                    tmp = nums[i];
                    nums[i] = nums[i2];
                    nums[i2] = tmp;
                }
                if (j2 < nums.Length  && nums[j] < nums[j2])
                {
                    tmp = nums[j];
                    nums[j] = nums[j2];
                    nums[j2] = tmp;
                }
                
                
                i2 = i2 + 2;
                j2 = j2 + 2;
            }
            j = j + 2;
            i = i + 2;
        }
        
        return nums;
    }
}