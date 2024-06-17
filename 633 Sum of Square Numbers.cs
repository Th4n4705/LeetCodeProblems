public class Solution {
    public bool JudgeSquareSum(int c) {
        int left = 0;
        int right = (int) Math.Sqrt(c);
        while (left <= right)
        {
            long sum = (long)(left * left) + (long)(right * right);
            if (sum == c)
                return true;
            else if (sum < c)
                left++;
            else
                right--;
        }
        return false;
    }
}