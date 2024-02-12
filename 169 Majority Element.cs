public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dc = new();
        foreach (int n in nums)
            if (dc.ContainsKey(n))
                dc[n]++;
            else
                dc.Add(n, 1);
        return dc.Where(kvp => kvp.Value == dc.Max(kvp => kvp.Value)).Select(kvp => kvp.Key).First();
    }
}