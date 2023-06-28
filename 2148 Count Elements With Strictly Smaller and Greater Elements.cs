public class Solution {
    public int CountElements(int[] nums) {
        if (nums.Length < 3)
            return 0;
        int min = nums.Min();
        int max = nums.Max();
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
            if (max > nums[i] && nums[i] > min)
                counter++;
        return counter;
    }
}