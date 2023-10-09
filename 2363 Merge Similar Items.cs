public class Solution {
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) {
        Dictionary<int, int> dc = new();
        foreach (int[] item in items1.Concat(items2))
        {
            int value = item[0];
            int weight = item[1];
            if (!dc.ContainsKey(value))
                dc[value] = 0;
            dc[value] += weight;
        }
        return dc.OrderBy(d => d.Key).Select(d => new int[] {d.Key, d.Value}).ToArray();
    }
}