public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int index = -1;
        int[] ans = new int[2];
        int[] f = new int[nums.Length - 2];
        for (int i = 0; i < nums.Length; i++)
        {
            if (f[nums[i]] > 0)
            {
                index++;
                ans[index] = nums[i];
                continue;
            }
            f[nums[i]] = 1;
        }
        return ans;
    }
}