public class Solution {
    public int MinSteps(int n) {
        if (n == 1)
            return 0;
        int i = 0;
        int f = 2;
        while (n > 1)
        {
            while (n % f == 0)
            {
                i += f;
                n /= f;
            }
            f++;
        }
        return i;
    }
}