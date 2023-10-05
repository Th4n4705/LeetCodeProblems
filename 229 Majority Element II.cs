public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        Dictionary<int, int> dc = new();
        List<int> ans = new();
        int witness = nums.Length / 3;
        foreach (int num in nums)
            if (dc.ContainsKey(num))
                dc[num]++;
            else
                dc.Add(num, 1);
        foreach (var d in dc)
            if (d.Value > witness)
                ans.Add(d.Key);
        return ans;
    }
}