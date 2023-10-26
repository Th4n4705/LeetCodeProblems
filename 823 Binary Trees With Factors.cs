public class Solution {
    public int NumFactoredBinaryTrees(int[] arr) {
        Array.Sort(arr);
        long ans = 0;
        Dictionary<int, long> dc = new();
        foreach (int i in arr)
        {
            dc[i] = 1;
            foreach (int j in arr)
                if (i % j == 0 && dc.ContainsKey(i / j))
                    dc[i] += dc[j] * dc[i / j];
        }
        foreach (long x in dc.Values)
            ans += x;
        return (int)(ans % (Math.Pow(10, 9) + 7));
    }
}