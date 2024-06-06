public class Solution {
    public int[] SortByBits(int[] arr) {
        Dictionary<int, List<int>> dc = new();
        foreach (int i in arr)
        {
            int counter = Convert.ToString(i, 2).Count(c => c == '1');
            if (!dc.ContainsKey(counter))
                dc[counter] = new List<int>();
            dc[counter].Add(i);
        }
        List<int> ans = new();
        foreach (var k in dc.Keys.OrderBy(d => d))
        {
            dc[k].Sort();
            ans.AddRange(dc[k]);
        }
        return ans.ToArray();
    }
}