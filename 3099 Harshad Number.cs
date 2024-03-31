public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        if (x < 10)
            return x;
        int harshad = 0;
        int tmp = x;
        while (x > 0)
        {
            harshad += x % 10;
            x /= 10;
        }
        return (tmp % harshad) == 0 ? harshad : -1;
    }
}