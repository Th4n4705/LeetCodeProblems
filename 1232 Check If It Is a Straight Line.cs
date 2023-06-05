public class Solution {
    public bool CheckStraightLine(int[][] c) {
        if (c.Length == 2)
            return true;
        for (int i = 0; i < c.Length - 2; i++)
        {
            int l = (c[i + 2][1] - c[i][1]) * (c[i + 1][0] - c[i][0]);
            int r = (c[i + 1][1] - c[i][1]) * (c[i + 2][0] - c[i][0]);
            if (l != r)
                return false;
        }
        return true;
    }
}