public class Solution {
    public int SumOfEncryptedInt(int[] nums) {
        int ans = 0;
        foreach (int n in nums)
            ans += Encrypting(n);
        return ans;
    }

    int Encrypting(int n)
    {
        int max = 0;
        int i = 0;
        while (n > 0)
        {
            max = Math.Max(max, n % 10);
            n /= 10;
            i++;
        }
        for (; i > 0; i--)
            n = n * 10 + max;
        return n;
    }
}