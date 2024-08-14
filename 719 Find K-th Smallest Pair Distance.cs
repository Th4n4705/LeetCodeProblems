public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        Array.Sort(nums);
        int high = nums[nums.Length - 1] - nums[0];
        int low = 0;
        while (low < high)
        {
            int mid = ((high - low) / 2) + low;
            if (PairsCounter(nums, mid) >= k)
                high = mid;
            else
                low = mid + 1;
        }
        return low;
    }

    int PairsCounter(int[] nums, int mid)
    {
        int counter = 0;
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            while (k < nums.Length && nums[k] - nums[i] <= mid)
                k++;
            counter += k - i - 1;
        }
        return counter;
    }
}