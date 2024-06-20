public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        Dictionary<int, int> rank = new();
        foreach (int n in arr.Order())
            rank.TryAdd(n, rank.Count + 1);
        return Array.ConvertAll(arr, n => rank[n]);
    }
}