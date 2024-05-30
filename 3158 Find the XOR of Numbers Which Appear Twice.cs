public class Solution {
    public int DuplicateNumbersXOR(int[] nums) {
        int ans = 0;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 1; i++)
            if (nums[i] == nums[i + 1])
                ans ^= nums[i];
        return ans;
    }
}