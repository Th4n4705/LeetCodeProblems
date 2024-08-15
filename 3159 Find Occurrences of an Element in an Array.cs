public class Solution {
    public int[] OccurrencesOfElement(int[] nums, int[] queries, int x) {
        int[] ans = new int[queries.Length];
        Dictionary<int, int> dc = new ();
        int y = 1;
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == x)
            {
                dc.Add(y, i);
                y++;
            }
        for (int i = 0; i < ans.Length; i++)
            if (dc.ContainsKey(queries[i]))
                ans[i] = dc[queries[i]];
            else
                ans[i] = -1;
        return ans;
    }
}