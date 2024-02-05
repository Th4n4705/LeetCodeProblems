public class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int counter = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            nums[0] += nums[i];
            if (nums[0] == 0)
                counter++;
        }
        return counter;
    }
}