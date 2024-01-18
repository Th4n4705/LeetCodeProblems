public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
        Array.Sort(nums);
        if (k % 2 == 0 && nums[0] >= 0)
            return nums.Sum();
        if (k % 2 != 0 && nums[0] >= 0)
        {
            nums[0] *= -1;
            return nums.Sum();
        }
        int i = 0;
        while (k > 0 && i < nums.Length && nums[i] <= 0)
        {
            nums[i] *= -1;
            i++;
            k--;
        }
        Array.Sort(nums);
        if (k % 2 != 0)
            nums[0] *= -1;
        return nums.Sum();
    }
}