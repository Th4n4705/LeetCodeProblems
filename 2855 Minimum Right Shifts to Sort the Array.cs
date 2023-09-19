public class Solution {
    public int MinimumRightShifts(IList<int> nums) {
        int counter = nums[^1] > nums[0] ? 1 : 0;
        int res = 0;
        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i] < nums[i - 1])
            {
                counter++;
                if (counter > 1)
                    return -1;
                res = nums.Count - i;
            }
        }
        return res;
    }
}