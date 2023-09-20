public class Solution {
    public int MinOperations(int[] nums, int x) {
        int t = nums.Sum() - x;
        if (t == 0)
            return nums.Length;
        int counter = 0;
        int sum = 0;
        int j = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
            while (j <= i && sum > t)
            {
                sum -= nums[j];
                j++;
            }
            if (sum == t)
                counter = Math.Max(counter, i - j + 1);
        }
        return counter != 0 ? nums.Length - counter : -1;
    }
}
