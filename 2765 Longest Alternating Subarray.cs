public class Solution {
    public int AlternatingSubarray(int[] nums) {
        int ans = -1;
        for (int i = 1; i < nums.Length;)
        {
            if (nums[i - 1] + 1 != nums[i++])
                continue;
            ans = Math.Max(ans, 2);
            for (int j = 3; i < nums.Length && nums[i] == nums[i - 2]; i++, j++)
                ans = Math.Max(ans, j);
        }
        return ans;
    }
}