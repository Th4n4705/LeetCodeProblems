public class Solution {
    public int MinMaxGame(int[] nums) {
        if (nums.Length == 1)
            return nums[0];
        int[] res = new int[nums.Length / 2];
        for (int i = 0; i < res.Length; i++)
            if (i % 2 == 0)
                res[i] = Math.Min(nums[i * 2], nums[(i * 2) + 1]);
            else
                res[i] = Math.Max(nums[i * 2], nums[(i * 2) + 1]);
        return MinMaxGame(res);
    }
}