public class Solution {
    public void MoveZeroes(int[] nums) {
        int left = 0;
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] != 0)
            {
                (nums[left], nums[i]) = (nums[i], nums[left]);
                left++;
            }
    }
}