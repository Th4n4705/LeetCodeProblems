public class Solution {
    public int PivotInteger(int n) {
        if (n == 1)
            return 1;
        int i = 1;
        int j = n;
        int sumi = i;
        int sumj = j;
        while (i < j)
        {
            if (sumi < sumj)
                sumi += ++i;
            else
                sumj += --j;
            if (sumi == sumj && i + 1 == j - 1 && j != n)
                return i + 1;
        }
        return -1;
    }
}