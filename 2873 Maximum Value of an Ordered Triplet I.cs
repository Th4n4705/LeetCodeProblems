public class Solution {
    public long MaximumTripletValue(int[] nums) {
        long ans = 0;
        for (int i = 0; i < nums.Length - 2; i++)
            for (int j = i + 1; j < nums.Length - 1; j++)
                for (int k = j + 1; k < nums.Length; k++)
                {
                    int max = nums.Max();
                    if (nums[i] > max && nums[k] > max)
                        break;
                    long tmp = (long)(nums[i] - nums[j]) * (long)nums[k];
                    ans = Math.Max(ans, tmp);
                }
        return ans;
    }
}