public class Solution {
    public bool Check(int[] nums) {
        int counter = 0;
        for (int i = 0; i < nums.Length - 1; i++)
            if (nums[i] > nums[i + 1])
                counter++;
        if (nums[nums.Length - 1] > nums[0])
            counter++;
        return counter <= 1;
    }
}