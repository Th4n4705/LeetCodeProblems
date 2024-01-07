public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        Dictionary<int, int> dc = new();
        foreach (var dimension in dimensions)
        {
            int area = dimension[0] * dimension[0] + dimension[1] * dimension[1];
            if (!dc.ContainsKey(area))
                dc.Add(area, 0);
            dc[area] = Math.Max (dc[area], dimension[0] * dimension[1]);
        }
        return dc[dc.Keys.Max()];
    }
}