public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] concatenatedArray = new int[nums.Length * 2];
        int j = 0;
        
        for (int i = 0; i < concatenatedArray.Length; i++)
        {
            if (i >= nums.Length && j == i)
                j = i - nums.Length;
            concatenatedArray [i] = nums[j];
            j++;
        }
        
        return concatenatedArray;
    }
}