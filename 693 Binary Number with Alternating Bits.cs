public class Solution {
    public bool HasAlternatingBits(int n) {
        while (n != 0)
        {
            int lastBit = n & 1;
            int secondBit = (n >> 1) & 1;
            if ((lastBit ^ secondBit) == 0)
                return false;
            n = n >> 1;
        }
        return true;
    }
}