public class Solution {
    public int[] SingleNumber(int[] nums) {
        Dictionary<int, int> dc = new();
        foreach (int n in nums)
            if (dc.ContainsKey(n))
                dc[n]++;
            else
                dc[n] = 1;
        List<int> ans = new();
        foreach (var pair in dc)
            if (pair.Value == 1)
                ans.Add(pair.Key);
        return ans.ToArray();
    }
}