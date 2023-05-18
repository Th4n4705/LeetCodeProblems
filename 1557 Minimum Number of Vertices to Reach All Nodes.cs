public class Solution {
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) {
        HashSet<int> hs = new();
        foreach (var edge in edges)
            hs.Add(edge[1]);
        List<int> ls = new();
        for (int i = 0; i < n; i++)
            if (!hs.Contains(i))
                ls.Add(i);
        return ls;
    }
}