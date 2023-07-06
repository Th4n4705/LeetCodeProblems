public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int min = int.MaxValue;
        int sum = 0;
        int left = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            while (sum >= target)
            {
                min = Math.Min(min, i - left + 1);
                sum -= nums[left];
                left++;
            }
        }
        return min != int.MaxValue ? min : 0;
    }
}