public class Solution {
    public int RepeatedNTimes(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            int counter = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    counter++;
                if (counter == nums.Length / 2)
                    return nums[i];
            }
        }
        return 0;
    }
}