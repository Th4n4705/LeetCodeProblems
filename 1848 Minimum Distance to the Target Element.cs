public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int ans = Int32.MaxValue;
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == target && ans > Math.Abs(i - start))
                ans = Math.Abs(i - start);
        return ans;
    }
}