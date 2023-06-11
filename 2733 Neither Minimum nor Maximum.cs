public class Solution {
    public int FindNonMinOrMax(int[] nums) {
        Array.Sort(nums);
        if (nums.Length <= 2)
            return -1;
        else if (nums.Length == 3)
            return nums[1];
        int i = 1;
        int j = nums.Length - 2;
        while (i <= j)
        {
            i++;
            j--;
        }
        return nums[j];
    }
}