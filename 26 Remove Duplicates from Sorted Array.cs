public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 1;
        int previouse = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != previouse)
            {
                nums[k] = nums[i];
                k++;
            }
            previouse = nums[i];
        }
        return k;
    }
}