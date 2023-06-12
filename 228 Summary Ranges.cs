public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        int? b = null;
        List<string> ans = new();
        for (int i = 0; i < nums.Length; i++)
        {
            b ??= nums[i];
            if (nums.Length <= i + 1 || nums[i + 1] - nums[i] != 1)
            {
                string o = b == nums[i] ? b.ToString() : $"{b.ToString()}->{nums[i].ToString()}";
                ans.Add(o);
                b = null;
            }
        }
        return ans;
    }
}