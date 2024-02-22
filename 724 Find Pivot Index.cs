public class Solution {
    public int PivotIndex(int[] nums) {
        int leftSum = 0;
        int rightSum = 0;
        for (int i = 1; i < nums.Length; i++)
            rightSum += nums[i];
        for (int i = 0; i < nums.Length; i++)
        {
            if (rightSum == leftSum)
                return i;
            if (i + 1 < nums.Length)
                rightSum -= nums[i + 1];
            leftSum += nums[i];
        }
        return -1;
    }
}