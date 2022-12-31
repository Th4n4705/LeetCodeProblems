public class Solution {
    public int[] RunningSum(int[] nums) {
        List<int> ls = new();
        ls.Add(nums[0]);
        for (int i = 1; i < nums.Length; i++)
            ls.Add(ls[i - 1] + nums[i]);
        return ls.ToArray();
    }
}