public class Solution {
    public int AddDigits(int num) {
        int rest = 0;
        int sum = 0;
        while (num > 0)
        {
            rest = num % 10;
            num = num / 10;
            sum += rest;
            if (num == 0 && sum > 9)
            {
                num = sum;
                sum = 0;
            }
        }
        return sum;
    }
}