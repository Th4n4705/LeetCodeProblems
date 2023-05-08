public class Solution {
    public int[] DistinctDifferenceArray(int[] nums) {
        int[] ans = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
            ans[i] = nums[..(i + 1)].Distinct().Count() - nums[(i + 1)..].Distinct().Count();
        return ans;
    }
}