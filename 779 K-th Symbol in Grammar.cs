public class Solution {
    public int KthGrammar(int n, int k) {
        if (n == 1)
            return 0;
        int lower = KthGrammar (n - 1, (k + 1) / 2);
        if (k % 2 == 0)
            return lower == 1 ? 0 : 1;
        return lower;
    }
}