public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int i = 0;
        int maxCounter = 0;
        
        if (nums.Length == 1)
        {
            if (nums[0] == 1)
                return 1;
            return 0;
        }
        
        while (i < nums.Length)
        {
            if (nums[i] == 1)
            {
                int j = i;
                int counter = 0;
                while (j < nums.Length)
                {
                    if (nums[i] == nums[j])
                        counter++;
                    else
                        break;
                    j++;
                }
                if (counter > maxCounter)
                    maxCounter = counter;
                if (j == nums.Length)
                    break;
                i += (j - i) - 1;
            }
            i++;
        }
        
        return maxCounter;
    }
}