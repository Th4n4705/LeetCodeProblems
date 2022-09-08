public class Solution {
    public int ArrangeCoins(int n)
    {
        int i = 1;
        int counter = 0;
        
        while (n > 0)
        {
            n -= i;
            i++;
            counter++;
        }
        
        if (n < 0)
            return counter - 1;
        
        return counter;
    }
}