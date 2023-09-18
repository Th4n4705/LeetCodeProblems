public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        Dictionary<int, int> dc = new ();
        for (int i = 0; i < mat.Length; i++)
        {
            int counter = 0;
            for (int j = 0; j < mat[i].Length; j++)
                if (mat[i][j] == 1)
                    counter++;
                else
                    break;
            dc.Add(i, counter);
        }
        List<int> ans = new();
        dc = dc.OrderBy(x => x.Value).ToDictionary(d => d.Key, d => d.Value);
        return dc.Take(k).Select(d=> d.Key).ToArray();
    }
}