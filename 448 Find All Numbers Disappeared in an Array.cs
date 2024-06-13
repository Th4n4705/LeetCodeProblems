public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        foreach (int n in nums)
        {
            int i = Math.Abs(n) - 1;
            if (nums[i] > 0)
                nums[i] = -nums[i];
        }
        List<int> ans = new();
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] > 0)
                ans.Add(i + 1);
        return ans;
    }
}