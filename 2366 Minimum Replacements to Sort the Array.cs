public class Solution {
    public long MinimumReplacement(int[] nums) {
        long res = 0;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            long n = (long)(nums[i] + nums[i + 1] - 1) / (long)nums[i + 1];
            res += n - 1;
            nums[i] = nums[i] / (int)n;
        }
        return res;
    }
}