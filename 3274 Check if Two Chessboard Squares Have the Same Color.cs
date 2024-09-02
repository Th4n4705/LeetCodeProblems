public class Solution {
    public bool CheckTwoChessboards(string coordinate1, string coordinate2) {
        int c1 = 1;
        int c2 = 1;
        if (((coordinate1[0] - 'a') % 2 + (coordinate1[1] - '1') % 2) % 2 == 0)
            c1 = 0;
        if (((coordinate2[0] - 'a') % 2 + (coordinate2[1] - '1') % 2) % 2 == 0)
            c2 = 0;
        return c1 == c2;
    }
}