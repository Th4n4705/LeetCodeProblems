public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
            if (Array.IndexOf(nums, nums[i] + diff) != -1 && Array.IndexOf(nums, nums[i] + (diff * 2)) != -1)
                counter++;
        return counter;
    }
}