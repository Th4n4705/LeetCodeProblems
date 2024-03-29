public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        int max = nums.Max();
        long ans = 0;
        int start = 0;
        int maxInRange = 0;
        for (int end = 0; end < nums.Length; end++)
        {
            if (nums[end] == max)
                maxInRange++;
            while (k == maxInRange)
            {
                if (nums[start] == max)
                    maxInRange--;
                start++;
            }
            ans += start;
        }
        return ans;
    }
}