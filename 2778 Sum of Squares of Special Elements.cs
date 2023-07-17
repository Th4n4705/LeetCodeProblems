public class Solution {
    public int SumOfSquares(int[] nums)
    {
        int squares = 0;
        for (int i = 0; i < nums.Length; i++)
            if (nums.Length % (i + 1) == 0)
                squares += nums[i] * nums[i];
        return squares;
    }
}