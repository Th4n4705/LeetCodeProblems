public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> ans = new();
        foreach (int n in nums)
        {
            int i = Math.Abs(n) - 1;
            if (nums[i] < 0)
                ans.Add(i + 1);
            else
                nums[i] = -nums[i];
        }
        return ans;
    }
}