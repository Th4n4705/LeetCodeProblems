public class Solution {
    public int CommonFactors(int a, int b) {
        int  counter = 0;
        int factor = a;
        
        if (factor > b)
            factor = b;
        
        while (factor > 0)
        {
            if (a % factor == 0 && b % factor == 0)
                counter++;
            factor--;
        }
        
        return counter;
    }
}