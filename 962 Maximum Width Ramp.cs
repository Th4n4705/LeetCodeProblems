public class Solution {
    public int MaxWidthRamp(int[] nums) {
        int ans = 0;
        int minValue = int.MaxValue;
        List<int> ls = new();
        for (int i = 0; i < nums.Length; i++)
            ls.Add(i);
        ls.Sort((x, y) => nums[x] == nums[y] ? x.CompareTo(y) : nums[x].CompareTo(nums[y]));
        foreach (int i in ls)
        {
            ans = Math.Max(ans, i - minValue);
            minValue = Math.Min(minValue, i);
        }
        return ans;
    }
}