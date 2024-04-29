public class Solution {
    public int MinOperations(int[] nums, int k) {
        int xor = 0;
        foreach (int n in nums)
            xor ^= n;
        if (xor == k)
            return 0;
        return BitsCounter(xor ^ k);
    }

    int BitsCounter(int n)
    {
        int counter = 0;
        while (n != 0)
        {
            counter += n & 1;
            n >>= 1;
        }
        return counter;
    }
}