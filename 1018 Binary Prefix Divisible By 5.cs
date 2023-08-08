public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        int x = 0;
        bool[] ans = new bool[nums.Length];
        for (int i = 0; i < nums.Length; i++)
            ans[i] = (x = (x * 2 + nums[i]) % 10) % 5 == 0;
        return ans;
    }
}