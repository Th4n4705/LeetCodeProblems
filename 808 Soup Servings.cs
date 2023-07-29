public class Solution {
    public double SoupServings(int n) {
        if (n > 4800)
            return 1;
        double[,] dp = new double[4801, 4801];
        return Soup_Helper (n, n, 0, dp);
    }

    private double Soup_Helper(int s1, int s2, double ans, double[,] dp)
    {
        if (s1 <= 0 && s2 <= 0)
            return 0.5;
        if (s1 <= 0)
            return 1;
        if (s2 <= 0)
            return 0;
        if (dp[s1, s2] != 0)
            return dp[s1, s2];
        return dp[s1, s2] = 0.25 * (ans + Soup_Helper(s1 - 100, s2, ans, dp) + 
        Soup_Helper(s1 - 75, s2 - 25, ans, dp) + Soup_Helper(s1 - 50, s2 - 50, ans, dp) + 
        Soup_Helper(s1 - 25, s2 - 75, ans, dp));
    }
}