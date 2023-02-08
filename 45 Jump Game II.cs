public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length == 1)
            return 0;
        int max = 0;
        int current = 0;
        int count = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            max =  Math.Max(max, nums[i] + i);
            if (current == i)
            {
                current = max;
                count++;
            }
            if (current > nums.Length - 1)
                return count;
        }
        return count;
    }
}