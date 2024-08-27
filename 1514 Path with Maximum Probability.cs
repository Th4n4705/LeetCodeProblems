public class Solution {
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node) {
        double[] dp = new double[n];
        dp[start_node] = 1;
        for (int i = 0; i < n - 1; i++)
        {
            bool checker = false;
            for (int j = 0; j < edges.Length; j++)
            {
                int u = edges[j][0];
                int v = edges[j][1];
                if (dp[u] * succProb[j] > dp[v])
                {
                    dp[v] = dp[u] * succProb[j];
                    checker = true;
                }
                if (dp[v] * succProb[j] > dp[u])
                {
                    dp[u] = dp[v] * succProb[j];
                    checker = true;
                }
            }
            if (!checker)
                break;
        }
        return dp[end_node];
    }
}