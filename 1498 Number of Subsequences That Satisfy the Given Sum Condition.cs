public class Solution {
    public int NumSubseq(int[] nums, int target) {
        Array.Sort(nums);
        int ans = 0;
        int mod = 1_000_000_007;
        int b = 0;
        int l = nums.Length - 1;
        int[] pows = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
            pows[i] = i != 0 ? pows[i - 1] * 2 % mod : 1;
        while (b <= l)
            if (nums[b] + nums[l] > target)
                l--;
            else
                ans = (ans + pows[l - b++]) % mod;
        return ans;
    }
}