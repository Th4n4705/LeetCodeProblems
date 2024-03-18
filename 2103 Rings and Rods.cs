public class Solution {
    public int CountPoints(string rings) {
        Dictionary<int, HashSet<char>> dc = new();
        for (int i = 0; i < rings.Length; i += 2)
        {
            if (!dc.TryGetValue(rings[i + 1], out var ls))
                dc[rings[i + 1]] = [];
            dc[rings[i + 1]].Add(rings[i]);
        }
        return dc.Keys.Count(key => dc[key].Count == 3);
    }
}