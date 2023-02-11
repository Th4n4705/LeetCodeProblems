public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int sum = 0;
        int sum2 = 0;
        foreach (var n in nums)
            sum += n;
        foreach (var n in nums)
        {
            int k = n;
            while (k > 0)
            {
                int j = k % 10;
                k /= 10;
                sum2 += j;
            }
        }
        return sum - sum2;
    }
}