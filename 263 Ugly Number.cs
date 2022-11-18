public class Solution {
    public bool IsUgly(int n) {
        if (n <= 0)
            return false;
        
        int[] primary = {2,3,5};
        for (int i = 0;i < primary.Length;i++)
        {
            while (n % primary[i] == 0 && n != 0)
                n /= primary[i];
        }
        return (n == 1);
    }
}