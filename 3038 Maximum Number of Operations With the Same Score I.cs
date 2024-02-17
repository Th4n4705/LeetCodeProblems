public class Solution {
    public int MaxOperations(int[] nums) {
        int ans = 1;
        int sum = nums[0] + nums[1];
        for (int i = 3; i < nums.Length; i += 2)
            if (nums[i - 1] + nums[i] == sum)
                ans++;
            else
                break;
        return ans;
    }
}