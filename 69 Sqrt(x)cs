public class Solution {
    public int MySqrt(int x) {
        if (x == 1 || x == 0)
            return x;
        
        long i = 1;
        long end = x;
        long result = 0;
        while (i <= end)
        {
            long mid = (i + end) / 2;
            
            if (mid * mid == x)
                return (int)mid;
            
            if (mid * mid < x)
            {
                i = mid + 1;
                result = mid;
            }
            else
                end = mid - 1;
        }
        
        return (int)result;
    }
}