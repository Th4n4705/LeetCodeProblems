public class Solution {
    public int UniquePaths(int m, int n) {
        long ans = 1;
        for (int i = 1; i < m; i++)
            ans = ans * (n + i - 1) / i;
        return (int)ans;
    }
}