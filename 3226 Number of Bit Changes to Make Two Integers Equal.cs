public class Solution {
    public int MinChanges(int n, int k) {
        int counter = 0;
        while (n > 0 || k > 0)
        {
            int nbits = n & 1;
            int kbits = k & 1;
            if (nbits != kbits && nbits == 1)
                counter++;
            if (nbits != kbits && nbits != 1)
                return -1;
            n >>= 1;
            k >>= 1;
        }
        return counter;
    }
}