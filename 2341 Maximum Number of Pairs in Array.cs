public class Solution {
    public int[] NumberOfPairs(int[] nums) {
        int counter = 0;
        int[] ans = new int[2];
        Dictionary<int, int> dc = new();
        for (int i = 0; i < nums.Length; i++)
            if (dc.ContainsKey(nums[i]))
                dc[nums[i]]++;
            else
                dc.Add(nums[i], 1);
        foreach (int item in dc.Values)
        {
            ans[0] += item / 2;
            ans[1] += item % 2;
        }
        return ans;
    }
}