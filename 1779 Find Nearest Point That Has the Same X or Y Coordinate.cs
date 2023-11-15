public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
        int ans = -1;
        int minDist = int.MaxValue;
        int i = 0;
        foreach (int[] p in points)
        {
            if (p[0] == x || p[1] == y)
            {
                int minCalc = Math.Abs(x - p[0]) + Math.Abs(y - p[1]);
                if (minDist > minCalc)
                {
                    ans = i;
                    minDist = minCalc;
                }
            }
            i++;
        }
        return ans;
    }
}