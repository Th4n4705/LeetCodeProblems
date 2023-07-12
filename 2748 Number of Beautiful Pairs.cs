public class Solution {
    public int CountBeautifulPairs(int[] nums) {
        int pairs = 0;
        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (IsBeauty(nums[i], nums[j]))
                    pairs++;
        return pairs;
    }

    private bool IsBeauty(int n, int n2)
    {
        int digit0 = 0;
        while (n > 0)
        {
            digit0 = n % 10;
            n = n / 10;
        }
        int digit1 = n2 % 10;
        if (GCD(digit0, digit1) == 1)
            return true;
        return false;
    }

    private int GCD (int a, int b)
    {
        while (a>0)
            (a, b) = (b%a, a);
        return b;
    }
}