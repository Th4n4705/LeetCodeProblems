public class Solution {
    public int[] FindIndices(int[] nums, int indexDifference, int valueDifference) {
        for (int i = 0; i < nums.Length - indexDifference; i++)
            for (int j = i + indexDifference; j < nums.Length; j++)
                if (Math.Abs(nums[i] - nums[j]) >= valueDifference)
                    return new[] {i, j};
        return new[] {-1, -1};
    }
}