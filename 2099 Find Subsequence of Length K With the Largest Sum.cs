public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        Dictionary<int, int> dc = new();
        for (int i = 0; i < nums.Length; i++)
            dc.Add(i, nums[i]);
        var sortedDc = dc.OrderByDescending(d => d.Value);
        Dictionary<int, int> dcK = new();
        foreach (var d in sortedDc)
        {   
            if (k == 0)
                break;
            dcK.Add(d.Key, d.Value);
            k--;
        }
        var ansDc = dcK.OrderBy(d => d.Key);
        int[] ans = new int[ansDc.Count()];
        for (int i = 0; i < ans.Length; i++)
            ans[i] = ansDc.ElementAt(i).Value;
        return ans;
    }
}