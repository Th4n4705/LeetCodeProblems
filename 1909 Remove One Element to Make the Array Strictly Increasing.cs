public class Solution {
    public bool CanBeIncreasing(int[] nums) {
        int counter = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] >= nums[i])
            {
                counter++;
                if (counter > 1)
                    return false;
                if (i > 1 && nums[i] <= nums[i - 2])
                    nums[i] = nums[i - 1];
            }
        }
        return true;
    }
}