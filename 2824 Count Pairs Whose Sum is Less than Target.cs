public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        int ans = 0;
        for (int i = 0; i < nums.Count - 1; i++)
            for (int j = i + 1; j < nums.Count; j++)
                if (nums[i] + nums[j] < target)
                    ans++;
        return ans;
    }
}