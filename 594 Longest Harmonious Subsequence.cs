public class Solution {
    public int FindLHS(int[] nums) {
        Dictionary<int, int> dc = new();
        int l = 0;
        foreach (int n in nums)
            if (dc.ContainsKey(n))
                dc[n]++;
            else
                dc[n] = 1;
        foreach (var k in dc)
            if (dc.ContainsKey(k.Key + 1))
                l = Math.Max(l, k.Value + dc[k.Key + 1]);
        return l;
    }
}