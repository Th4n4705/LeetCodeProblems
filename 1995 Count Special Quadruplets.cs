public class Solution {
    public int CountQuadruplets(int[] nums) {
        int  counter = 0;
        
        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                for (int k = j + 1; k < nums.Length; k++)
                    for (int l = k + 1; l < nums.Length; l++)
                        if (nums[i] + nums[j] + nums[k] == nums[l])
                            counter++;
        
        return counter;

    }
}