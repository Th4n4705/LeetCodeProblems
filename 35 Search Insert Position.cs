public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target)
                return i;
            else if (nums[i] < target && nums.Length - i > 1 && nums[i + 1] > target)
                return i + 1;
        }
        if (nums[nums.Length - 1] < target)
            return nums.Length;
        return 1;
    }
}