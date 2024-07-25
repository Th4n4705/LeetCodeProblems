public class Solution {
    public int[] SortArray(int[] nums) {
        int start = nums.Length / 2;
        int end = nums.Length;
        while (end > 1)
        {
            if (start > 0)
                --start;
            else
            {
                --end;
                (nums[0], nums[end]) = (nums[end], nums[0]);
            }
            int a = start;
            while (a * 2 + 1 < end)
            {
                int b = a * 2 + 1;
                if (b + 1 < end && nums[b] < nums[b + 1])
                    ++b;
                if (nums[a] < nums[b])
                {
                    (nums[b], nums[a]) = (nums[a], nums[b]);
                    a = b;
                }
                else
                    break;
            }
        }
        return nums;
    }
}