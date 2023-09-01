public class Solution {
    public int[] CountBits(int n) {
        int[] res = new int[n + 1];
        for (int i = 0; i < n + 1; i++)
            res[i] = Convert.ToString(i, 2).Count(b => b == '1');
        return res;
    }
}