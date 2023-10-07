public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        Dictionary<int, int> dc = new();
        List<int[]> ls = new();
        foreach (var n in nums1)
            dc.Add(n[0],n[1]);
        foreach (var n in nums2)
            if (!dc.ContainsKey(n[0]))
                dc.Add(n[0], n[1]);
            else
                dc[n[0]] += n[1];
        while (dc.Count > 0)
        {
            ls.Add(new int[] {dc.Keys.Min(), dc[dc.Keys.Min()]});
            dc.Remove(dc.Keys.Min());
        }
        return ls.ToArray();
    }
}