public class Solution {
    public bool IsPowerOfTwo(int n) {
        int i = 0;
        double pow;
        while (i <= n/2)
        {pow = Math.Pow(2, i);
            if (pow == n)
                return true;
            else if (pow > n)
                break;
            i++;
        }
                return false;
    }
}