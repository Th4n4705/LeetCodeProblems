public class Solution {
    public int NumberOfCuts(int n) {
        if (n == 1)
            return 0;
        else if (n == 2)
            return 1;
        else if (n % 2 == 0)
            return n / 2;
        return n;
    }
}