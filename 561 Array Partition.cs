public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        int ans = 0;
        for (int i = nums.Length - 2; 0 <= i; i -= 2)
            ans += nums[i];
        return ans;
    }
}