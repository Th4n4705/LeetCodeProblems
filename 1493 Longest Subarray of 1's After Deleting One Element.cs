public class Solution {
    public int LongestSubarray(int[] nums) {
        int zeroCount = 0;
        int longest = 0;
        int start = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            zeroCount += (nums[i] == 0 ? 1 : 0);
            while (zeroCount > 1)
            {
                zeroCount -= (nums[start] == 0 ? 1 : 0);
                start++;
            }
            longest = Math.Max(longest, i - start);
        }
        return longest;
    }
}