public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        int max = 1;
        int counter = 1;
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] > nums[i - 1])
                counter++;
            else
            {
                max = Math.Max(max, counter);
                counter = 1;
            }
        return Math.Max(max, counter);
    }
}