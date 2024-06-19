public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int ans = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            int x = Math.Abs(points[i + 1][0] - points[i][0]);
            int y = Math.Abs(points[i + 1][1] - points[i][1]);
            ans += Math.Max(x, y);
        }
        return ans;
    }
}