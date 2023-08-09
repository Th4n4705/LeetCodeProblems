public class Solution {
    public int MinimizeMax(int[] nums, int p) {
        Array.Sort(nums);
        int left = 0;
        int right = nums[nums.Length - 1] - nums[0];
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (MinimizeMax_Helper(nums, p, mid))
                right = mid;
            else
                left = mid + 1;
        }
        return left;
    }

    private bool MinimizeMax_Helper(int[] nums, int p, int mid)
    {
        int counter = 0;
        for (int i = 0; i < nums.Length - 1 &&  counter < p;)
            if (nums[i + 1] - nums[i] <= mid)
            {
                counter++;
                i += 2;
            }
            else
                i++;
        return counter >= p;
    }
}