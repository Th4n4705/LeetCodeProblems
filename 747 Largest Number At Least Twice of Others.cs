public class Solution {
    public int DominantIndex(int[] nums) {
        int max = nums.Max();
        foreach (int n in nums)
            if (n != max && max / 2 < n)
                return -1;
        return Array.IndexOf(nums, max);
    }
}