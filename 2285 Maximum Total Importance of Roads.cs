public class Solution {
    public long MaximumImportance(int n, int[][] roads) {
        long ans = 0;
        long[] nodes = new long[n];
        foreach (int[] r in roads)
        {
            nodes[r[0]]++;
            nodes[r[1]]++;
        }
        Array.Sort(nodes, (a, b) => b.CompareTo(a));
        for (int i = 0; i < n; i++)
            ans += nodes[i] * (n - i);
        return ans;
    }
}