public class Solution {
    public int SumCounts(IList<int> nums) {
        int ans = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            HashSet<int> hs = new();
            for (int j = i; j < nums.Count; j++)
            {
                hs.Add(nums[j]);
                ans += hs.Count * hs.Count;
            }
        }
        return ans;
    }
}