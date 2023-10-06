public class Solution {
    public int IntegerBreak(int n) {
        if (n < 4)
            return n - 1;
        int[] l = new int[n + 1];
        l[2] = 2;
        l[3] = 3;
        for (int i = 4; i <= n; i++)
            l[i] = Math.Max(l[i - 2] * 2, l[i - 3] * 3);
        return l[n];
    }
}