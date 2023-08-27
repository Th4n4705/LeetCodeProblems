public class Solution {
    public int FurthestDistanceFromOrigin(string moves) {
        int l = 0;
        int r = 0;
        int t = 0;
        foreach (char m in moves)
            if (m == 'L')
                l++;
            else if (m == 'R')
                r++;
            else
                t++;
        return Math.Abs(l - r) + t;
    }
}