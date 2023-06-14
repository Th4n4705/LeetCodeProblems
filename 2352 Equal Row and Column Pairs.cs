public class Solution {
    public int EqualPairs(int[][] g) {
        int ans = 0;
        for (int i = 0; i < g.Length; i++)
            for (int j = 0; j < g.Length; j++)
                for (int k = 0; k < g.Length; k++)
                    if (g[i][k] != g[k][j])
                        break;
                    else if (k == g.Length - 1)
                        ans++;
        return ans;
    }
}