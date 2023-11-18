public class Solution {
    public IList<int> MinSubsequence(int[] nums) {
        Array.Sort(nums);
        List<int> ans = new();
        int sum = nums.Sum();
        if (nums.Length == 1)
        {
            ans.Add(nums[0]);
            return ans;
        }
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (ans.Count == 0)
                ans.Add(nums[i]);
            if (sum - ans.Sum() < ans.Sum())
                return ans;
            else
            {
                if (i >= 1)
                    ans.Add(nums[i - 1]);
                if (sum - ans.Sum() < ans.Sum())
                    return ans;
            }
        }
        return ans;
    }
}