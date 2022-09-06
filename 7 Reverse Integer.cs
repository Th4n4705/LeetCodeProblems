public class Solution {
    public int Reverse(int x)
    {
        int sign = 1;
        
        if (x % 10 > 2 && x.ToString().Length > 9 || x == -2147483648)
            return 0;
        
        if (x < 0)
        {
            sign = -1;
            x = x * sign;
        }
        
        if (x < 10)
            return x * sign;
        
        int result = RecursionReverse (x, 0);
        
        if (result < 0)
            return 0;
        
        return result * sign;
        
    }
    
    public int RecursionReverse (int x, int reversed)
    {
        reversed = (reversed * 10) + (x % 10);
        
        if (x == 0)
            return 0;
        
        if (x < 10)
            return reversed;

        return RecursionReverse (x / 10, reversed);
    }
}