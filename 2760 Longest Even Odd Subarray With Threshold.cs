public class Solution {
    public int LongestAlternatingSubarray(int[] nums, int threshold) {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 != 0 || nums[i] > threshold)
                continue ;
            int counter = 0;
            bool even = true;
            for (int j = i; j < nums.Length; j++)
                if (nums[j] > threshold)
                {
                    i = j;
                    break;
                }
                else if ((nums[j] % 2 == 0) != even)
                {
                    i = j - 1;
                    break;
                }
                else
                {
                    counter++;
                    even = ! even;
                }
            result = Math.Max(result, counter);
        }
        return result;
    }
}