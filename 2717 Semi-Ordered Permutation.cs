public class Solution {
    public int SemiOrderedPermutation(int[] nums) {
        int first = Array.IndexOf(nums, 1);
        int last = Array.IndexOf(nums, nums.Length);
        if (first == 0 && last == nums.Length - 1)
            return 0;
        return first + (nums.Length - last - 1) + (last >= first ? 0 : -1);
    }
}