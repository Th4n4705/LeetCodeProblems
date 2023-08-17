public class Solution {
    public int AccountBalanceAfterPurchase(int p) {
        if (p == 0 || p == 100)
            return p == 100 ? 0 : 100;
        if (p % 10 >= 5)
            return 100 - (10 + p - p % 10);
        return 100 - (p - p % 10);
    }
}