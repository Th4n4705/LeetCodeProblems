public class Solution {
    public int DiagonalPrime(int[][] nums) {
        int max = 0;
        int n = nums.Length;
        for (int i = 0, j = n - 1; i < n; i++, j--)
        {
            if (nums[i][i] > 1 && IsPrime(nums[i][i]))
                max = Math.Max(max, nums[i][i]);
            if (nums[i][j] > 1 && IsPrime(nums[i][j]))
                max = Math.Max(max, nums[i][j]);
        }
        return max;
    }

    private bool IsPrime(int n)
    {
        for (int i = (int)Math.Sqrt(n); i > 1; i--)
            if (n % i == 0)
                return false;
        return true;
    }
}