public class Solution {
    public int WinningPlayerCount(int n, int[][] pick) {
        int ans = 0;
        Dictionary<int, int>[] dc =  new Dictionary<int, int>[n];
        for (int i = 0; i < dc.Length; i++)
            dc[i] = new();
        for (int i = 0; i < pick.Length; i++)
            if (!dc[pick[i][0]].TryAdd(pick[i][1], 1))
                dc[pick[i][0]][pick[i][1]]++;
        for (int i = 0; i < dc.Length; i++)
            foreach (var d in dc[i])
                if (i < d.Value)
                {
                    ans++;
                    break;
                }
        return ans;
    }
}