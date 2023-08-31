public class Solution {
    public int FindClosestNumber(int[] nums) {
        int pos = int.MaxValue;
        int neg = int.MinValue;
        foreach (int n in nums)
        {
            if (n >= 0)
                pos = Math.Min(pos, n);
            else
                neg = Math.Max(neg, n);
        }
        return -pos >= neg ? pos : neg;
    }
}