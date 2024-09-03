public class Solution {
    public int GenerateKey(int num1, int num2, int num3) {
        int ans = 0;
        int fact = 1000;
        for (int i = 0; i < 4; i++)
        {
            int div = fact;
            int minDigit = Math.Min(Math.Min(num1 / div, num2 / div), num3 / div);
            ans += minDigit * fact;
            num1 %= div;
            num2 %= div;
            num3 %= div;
            fact /= 10;
        }
        return ans;
    }
}