public class Solution {
    public int MissingInteger(int[] nums) {
        int sum = nums[0];
        for (int i = 0; i < nums.Length - 1; i++)
            if (nums[i] + 1 == nums[i + 1])
                sum += nums[i + 1];
            else
                break;
        while (nums.Contains(sum))
            sum++;
        return sum;
    }
}