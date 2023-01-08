public class Solution {
    public int MaximumCount(int[] nums) {
        int neg = 0;
        int pos = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                pos++;
            else if (nums[i] < 0)
                neg++;
        }
        return pos > neg ? pos : neg;
    }
}